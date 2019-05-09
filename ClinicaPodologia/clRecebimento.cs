using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace ClinicaPodologia
{
    public class ClassRecebimento
    {

        public int ID_ContaRecebe { set; get; }
        public decimal ValorRecebe { set; get; }
        public string TipoPagamento { set; get; }
        public int Parcelamento { set; get; }
        public DateTime DataConsulta { set; get; }
        public DateTime DataPagamento { set; get; }
        public int ID_Servico { set; get; }
        public int ID_Agenda { set; get; }
        //public decimal Valor { set; get; }
        //public string Tipo { set; get; }
        //public int ID_Atendimento { set; get; }
        public int ID_Profissional { set; get; }
        public int ID_Cliente { set; get; }
        public string NomeCliente { set; get; }
        public string NomeProfissional { set; get; }
        public byte PagamentoEfetuado { set; get; }


        conectaBD BD = new conectaBD();



        public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO ContaRecebe (ValorRecebe, ID_Agenda, DataConsulta, PagamentoEfetuado) " +
                                        " values ('{0}','{1}','{2}','{3}')", ValorRecebe, ID_Agenda, DataConsulta.ToShortDateString(), PagamentoEfetuado) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    

                    MessageBox.Show("Dados armazenados em caixa com sucesso", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //, "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Profissional", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;

        }

        public void Atualiza()
        {
            try
            {
                int exOK = 0;

                BD._sql = String.Format("UPDATE ContaRecebe SET TipoPagamento = '{0}', Parcelamento = '{1}', DataPagamento = '{2}', PagamentoEfetuado = '{3}' " +
                    "  WHERE ID_ContaRecebe = '{4}'", TipoPagamento, Parcelamento, DataPagamento.ToShortDateString(), PagamentoEfetuado,  ID_ContaRecebe);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao salvar pagamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Pagamento realizado com sucesso!", "Atualizado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public DataTable PesquisaCreditos(DateTime dataini, DateTime datafim, int cod)
        {
            try
            {
                BD._sql = "SELECT isnull(sum(CR.ValorRecebe),0) as creditos " +
                                 "FROM ContaRecebe CR " +
                                 "LEFT JOIN Agendamento AG ON CR.ID_Agenda = AG.ID_Agenda " +
                                 "RIGHT JOIN Servico S ON AG.ID_Servico = S.ID_Servico " +
                                 "INNER JOIN Atende A ON S.ID_Servico = A.ID_Servico " +
                                 "INNER JOIN Profissional P ON A.ID_Profissional = P.ID_Profissional " +
                                 "WHERE CR.DataPagamento BETWEEN '" + dataini.ToShortDateString() + "' AND '" + datafim.ToShortDateString() + "' " +
                                 "AND P.ID_Profissional = " + cod + "";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void Apagar(int id_apagar)
        {
            try
            {
                int exOK = 0;
                BD._sql = String.Format("DELETE FROM Profissional WHERE ID_Profissional = '{0}'", id_apagar);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao deletar profissional", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Profissional deletado com sucesso!", "Deletado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        public DataTable ListaGraficoCaixa(DateTime dataini, DateTime datafim, int cod)
        {
            try
            {
                BD._sql = "SELECT CAST(ANO AS VARCHAR)+'/'+CAST(MES AS VARCHAR) AS 'ANO/MES' , SUM(DEBITO) AS DEBITO, SUM(CREDITO) AS CREDITO " +
                                   "FROM (SELECT ANO,MES, ISNULL(CASE TIPO WHEN 'd' THEN SUM(VALOR) END,0) AS DEBITO, ISNULL(CASE TIPO WHEN 'C' THEN SUM(VALOR) END,0) AS CREDITO " +
                                          "FROM (select DATEPART(YYYY,DATA) AS ANO,MES, valor, tipo, ID_Profissional " +
                                                 "from [VW_LISTA_CREDITOS] " +
                                                 "WHERE DATA BETWEEN '" + dataini + "' AND '" + datafim + "' AND ID_Profissional = " + cod + " " +
                                                 "union " +
                                                 "select DATEPART(YYYY,DATA) AS ANO,MES, valor, tipo, ID_Profissional " +
                                                 "from [VW_LISTA_DEBITOS] " +
                                                 "WHERE DATA BETWEEN '" + dataini + "' AND '" + datafim + "' AND ID_Profissional = " + cod + " ) " +
                                           "AS TABELA GROUP BY ANO, MES, TIPO ) " +
                                           "AS TABELA_FORA " +
                                     "GROUP BY ANO,MES ORDER BY ANO, MES";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable RecebePagamento (int cliente, int profissional, byte cod )
        {
            try
            {
                BD._sql = "SELECT CR.DataConsulta AS 'Data da Consulta', CR.ID_ContaRecebe, CR.ID_Agenda, cr.ValorRecebe AS 'Valor a Receber', CASE CR.PagamentoEfetuado WHEN 0 THEN 'Não' ELSE 'Sim' END AS 'Pagamento Efetuado', C.ID_Cliente " +
                    "FROM ContaRecebe CR " +
                    "INNER JOIN Agendamento A ON A.ID_Agenda = CR.ID_Agenda " +
                    "INNER JOIN Realiza R ON A.ID_Agenda = R.ID_Agenda " +
                    "INNER JOIN Cliente C ON R.ID_Cliente = C.ID_Cliente " +
                    "LEFT JOIN Profissional P ON P.ID_Profissional = A.ID_Profissional " +
                    "WHERE C.ID_Cliente = " + cliente + " AND P.ID_Profissional = " + profissional + " AND CR.PagamentoEfetuado = " + cod + "";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable RecebePagamentoAmbas(int cliente, int profissional)
        {
            try
            {
                BD._sql = "SELECT CR.DataConsulta AS 'Data da Consulta', CR.ID_ContaRecebe, CR.ID_Agenda, cr.ValorRecebe AS 'Valor a Receber', CASE CR.PagamentoEfetuado WHEN 0 THEN 'Não' ELSE 'Sim' END AS 'Pagamento Efetuado', C.ID_Cliente " +
                    "FROM ContaRecebe CR " +
                    "INNER JOIN Agendamento A ON A.ID_Agenda = CR.ID_Agenda " +
                    "INNER JOIN Realiza R ON A.ID_Agenda = R.ID_Agenda " +
                    "INNER JOIN Cliente C ON R.ID_Cliente = C.ID_Cliente " +
                    "LEFT JOIN Profissional P ON P.ID_Profissional = A.ID_Profissional " +
                    "WHERE C.ID_Cliente = " + cliente + " AND P.ID_Profissional = " + profissional + "";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
