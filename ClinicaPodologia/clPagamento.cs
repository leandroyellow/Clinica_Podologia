using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace ClinicaPodologia
{
    public class ClassPagamento
    {

        public int ID_Despesa { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public int ID_Profissional { get; set; }


        conectaBD BD = new conectaBD();

        public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO Despesa (Tipo,Valor,Data, ID_Profissional) " +
                                        " values ('{0}',{1},'{2}','{3}')", Tipo, Valor, Data.ToShortDateString(), ID_Profissional ) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    

                    MessageBox.Show("Despesa Adicionada!");

                    //, "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Despesa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        }

        public void Apagar()
        {

        }

        public DataTable PesquisaDebitos(DateTime dataini, DateTime datafim, int cod)
        {
            try
            {
                BD._sql = "SELECT isnull(sum(D.Valor),0) as Débitos " +
                               "FROM Despesa D " +
                               "INNER JOIN Profissional P ON D.ID_Profissional = P.ID_Profissional " +
                               "WHERE D.Data BETWEEN '" + dataini + "' AND '" + datafim + "' AND P.ID_Profissional = " + cod + "";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ListaGraficoCaixa(DateTime dataini, DateTime datafim, int cod)
        {
            try
            {
                BD._sql = "SELECT MONTH(D.Data) AS 'MêsDebito', SUM(D.Valor) AS 'Débito' " +
                               "FROM Despesa D INNER JOIN Profissional P ON D.ID_Profissional = P.ID_Profissional " +
                               "WHERE D.Data BETWEEN '" + dataini + "' AND '" + datafim + "' " +
                               "AND P.ID_Profissional = " + cod + " " +
                               "GROUP BY MONTH (D.Data)";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
                return null;
            }
        }













    }
}