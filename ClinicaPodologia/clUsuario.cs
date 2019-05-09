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
    public class ClassUsuario
    {

        public int ID_Profissional { set; get; }
        public string Nome { set; get; }
        public string Especialidade { set; get; }
        public string Celular { set; get; }
        public int Permissao { set; get; }
        public string Login { set; get; }
        public string Senha { set; get; }
        public DateTime AtendimentoInicio { set; get; }
        public DateTime AtendimentoFim { set; get; }


        conectaBD BD = new conectaBD();



        public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO Profissional (Nome, Especialidade, Celular, Permissao, Login, Senha, AtendimentoInicio, AtendimentoFim) " +
                                        " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}' )", Nome, Especialidade, Celular, Permissao, Login, Senha, AtendimentoInicio.ToShortTimeString(), AtendimentoFim.ToShortTimeString()) + "; SELECT SCOPE_IDENTITY();";

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

                BD._sql = String.Format("UPDATE Profissional SET Nome = '{0}', Especialidade = '{1}', Celular = '{2}', Permissao = '{3}', Login = '{4}', Senha = '{5}', AtendimentoInicio = '{6}', AtendimentoFim = '{7}' " +
                    "  WHERE ID_Profissional = '{8}'", Nome, Especialidade, Celular, Permissao, Login, Senha, AtendimentoInicio, AtendimentoFim, ID_Profissional);

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


                BD._sql = "SELECT ID_Profissional as 'Id', Nome as 'Nome', Especialidade as 'Especialidade', Celular as 'Celular', Permissao as 'Permissão', Login as 'Login', Senha as 'Senha', AtendimentoInicio as 'Início de atendimento', AtendimentoFim as 'Final de atendimento' " +
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


                BD._sql = "SELECT Login, ID_Profissional FROM Profissional order by Login";

                return BD.ExecutaSelect();


            }
            catch (Exception)
            {

            }

            return null;

        }

    }
}

