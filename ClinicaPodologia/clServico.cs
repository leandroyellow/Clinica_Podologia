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
    public class ClassServico
    {

        public int ID_Profissional { set; get; }
        public string Tipo { set; get; }
        public decimal Valor { set; get; }
        public int ID_TipoServico { set; get; }



        conectaBD BD = new conectaBD();



        public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO Servico (Tipo, Valor) " +
                                        " values ('{0}','{1}' )", Tipo, Valor) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    int id2 = 0;
                    try
                    {
                        BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO Atende (ID_Profissional, ID_Servico) " +
                                                                "VALUES ('{0}','{1}') ", ID_Profissional, id) + "; SELECT SCOPE_IDENTITY();";

                        BD.ExecutaComando(false, out id2);

                        if (id2 > 0)
                        {
                            String cod = Convert.ToString(id);

                            MessageBox.Show(String.Format("Serviço cadastrado com sucesso!\nID do Serviço é {0}", cod));
                        }

                        else
                        {
                            MessageBox.Show("Erro ao cadastrar Serviço de Atendimento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return id2;

                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Serviço", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                BD._sql = String.Format("UPDATE Servico SET Tipo = '{0}', Valor = {1} " +
                    "  WHERE ID_Servico = '{2}'", Tipo, Valor.ToString().Replace(",", "."), ID_TipoServico);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao atualizar serviço", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Serviço atualizado com sucesso!", "Atualizado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public DataTable PesquisaPorNome(String nome_pesquisa, int cod)
        {
            try
            {


                BD._sql = "select distinct  id, Tipo, Valor, cod_profissional " +
                    "from (select s.ID_Servico as 'id', s.Tipo, s. Valor, p.ID_Profissional as 'cod_profissional'  " +
                    "from Servico s " +
                    "inner join Atende a on s.ID_Servico = a.ID_Servico " +
                    "inner join Profissional p on a.ID_Profissional = p.ID_Profissional " +
                    "where Tipo LIKE '%"+nome_pesquisa+"%' AND p.ID_Profissional = "+cod+") as tabela " +
                    "left join Agendamento a on a.ID_Servico = id ";

                return BD.ExecutaSelect();


            }
            catch (Exception)
            {

            }

            return null;

        }

        public void Apagar(int id_apagar)
        {
            try
            {
                int exOK = 0;
                BD._sql = String.Format("DELETE FROM Atende WHERE ID_Servico = '{0}'", id_apagar);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao deletar Atende", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        int exOK2 = 0;
                        BD._sql = String.Format("DELETE FROM Servico WHERE ID_Servico = '{0}'", id_apagar);

                        exOK2 = BD.ExecutaComando(false);

                        if(exOK2 < 0)
                        {
                            MessageBox.Show("Erro ao deletar serviço", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Serviço deletado com sucesso!", "Deletado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        public DataTable Pesquisa_Servico(int cod)
        {
            try
            {


                BD._sql = "SELECT S.ID_Servico as 'Id', S.Tipo as 'Tipo' " +
                    "FROM Servico S INNER JOIN Atende Ad ON Ad.ID_Servico = S.ID_Servico " +
                    "INNER JOIN Profissional Pf ON Pf.ID_Profissional = Ad.ID_Profissional " +
                    "WHERE  Pf.ID_Profissional = " + cod + "";

                return BD.ExecutaSelect();


            }
            catch (Exception)
            {

            }

            return null;

        }

        public DataTable pesquisa_valor()
        {
            try
            {


                BD._sql = "SELECT  Valor FROM Servico WHERE ID_Servico = " + ID_TipoServico + " ";

                return BD.ExecutaSelect();


            }
            catch (Exception)
            {

            }

            return null;

        }
        public DataTable pesquisa_ID_agenda()
        {
            try
            {
                BD._sql = "select count(*) as contador from Agendamento where ID_Servico = " + ID_TipoServico + " ";

               return  BD.ExecutaSelect();
            }
            catch (Exception)
            {

            }

            return null;
        }

    }
}

