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
    public class ClassAtendimento
    {

        public int ID_ContaRecebe { set; get; }
        public decimal ValorRecebe { set; get; }
        public string TipoPagamento { set; get; }
        public int Parcelamento { set; get; }
        public DateTime Data { set; get; }
        public int ID_Servico { set; get; }
        public int ID_Agenda { set; get; }
        public decimal Valor { set; get; }
        public string Tipo { set; get; }
        public int ID_Atendimento { set; get; }
        public int ID_Profissional { set; get; }
        public int ID_Cliente { set; get; }
        public string NomeCliente { set; get; }
        public string NomeProfissional { set; get; }


        conectaBD BD = new conectaBD();



        public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO Profissional (Nome, Especialidade, Celular, Permissao, Login, Senha) " +
                                        " values ('{0}','{1}','{2}','{3}','{4}','{5}' )", ID_Cliente) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    String cod = Convert.ToString(id);

                    MessageBox.Show(String.Format("Profissional cadastrado com sucesso!\nID do Profissional é {0}", cod));

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

                BD._sql = String.Format("UPDATE Profissional SET Nome = '{0}', Especialidade = '{1}', Celular = '{2}', Permissao = '{3}', Login = '{4}', Senha = '{5}' " +
                    "  WHERE ID_Profissional = '{6}'",  ID_Profissional);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao atualizar profissional", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Profissional atualizado com sucesso!", "Atualizado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public DataTable PesquisaPorNome(String nome_pesquisa)
        {
            try
            {


                BD._sql = "SELECT ID_Profissional as 'Id', Nome as 'Nome', Especialidade as 'Especialidade', Celular as 'Celular', Permissao as 'Permissão', Login as 'Login', Senha as 'Senha' " +
               "  FROM Profissional" +
               "  WHERE Nome LIKE '%" + nome_pesquisa + "%'";

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

        public DataTable Pesquisa_Profissional()
        {
            try
            {


                BD._sql = "SELECT ID_Profissional as 'Id', Nome as 'Nome' " +
               "  FROM Profissional";

                return BD.ExecutaSelect();


            }
            catch (Exception)
            {

            }

            return null;

        }

        public DataTable Login_Profissional()
        {
            try
            {


                BD._sql = "SELECT Nome, ID_Profissional FROM Profissional";

                return BD.ExecutaSelect();


            }
            catch (Exception)
            {

            }

            return null;

        }

    }
}
