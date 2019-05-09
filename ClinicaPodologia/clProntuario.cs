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
    public class ClassProntuario
    {

        public int ID_Cliente { set; get; }
        public string Prontuario { set; get; }
        public string NomeCliente { set; get; }
        public int ID_Prontuario { set; get; }



        conectaBD BD = new conectaBD();



        public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO Prontuario (ID_Cliente, Prontuario) " +
                                        " values ('{0}','{1}' )", ID_Cliente, Prontuario) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    String cod = Convert.ToString(id);

                    MessageBox.Show(String.Format("Prontuário cadastrado com sucesso!"));

                    //, "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Prontuario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                BD._sql = String.Format("UPDATE Prontuario SET ID_Cliente = '{0}', Prontuario = '{1}' " +
                    "  WHERE ID_Cliente = '{2}'", ID_Cliente, Prontuario, ID_Cliente);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao atualizar Prontuario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Prontuario atualizado com sucesso!", "Atualizado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


    }
}