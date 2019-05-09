using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace ClinicaPodologia
{
    public partial class frmLogin : Form
    {
        //frmPrincipal frm;
        public frmLogin()//frmPrincipal principal)
        {
            InitializeComponent();
            RestaurarDBPadraoCasoNaoExista();
            //frm = principal;
        }

        private int podologo;
        private int biomedico;
        private int manicure;
        private int estetica;
        private int permissao, profissional;
        public int permi
        {
            get { return permissao; }
            set { permissao = value; }
        }
        public int podo
        {
            get { return podologo; }
            set { podologo = value; }
        }
        public int bio
        {
            get { return biomedico; }
            set { biomedico = value; }
        }
        public int mani
        {
            get { return manicure; }
            set { manicure = value; }
        }
        public int est
        {
            get { return estetica; }
            set { estetica = value; }
        }
        int logado = 0;
        string login, senha;


        private void btEntrar_Click(object sender, EventArgs e)
        {
            permi = 0;
            //bio = 0;
            //est = 0;
            //mani = 0;
            //podo = 0;

            
            login = cmbLogin.Text;
            senha = txtSenha.Text;

            try
            {
                string connetionString;
                connetionString = "DATA SOURCE=.\\sqlexpress; Initial Catalog=ClinicaPodo;Persist Security Info=True;User ID=sa;Password=senac";
                SqlConnection conexao;
                conexao = new SqlConnection(connetionString);

                SqlCommand command = new SqlCommand();
                conexao.Open();
                command.Connection = conexao;

                DataTable dt = new DataTable();

                command.CommandText = "SELECT Senha, Permissao, ID_Profissional FROM Profissional WHERE login = '" + login + "'";
                dt.Load(command.ExecuteReader());

                senha = dt.Rows[0]["senha"].ToString();
                permissao = Convert.ToInt32(dt.Rows[0]["Permissao"].ToString());
                profissional = Convert.ToInt32(dt.Rows[0]["ID_Profissional"].ToString());

                /*                if (permissao == 5)
                                {
                                    podologo = Convert.ToInt32(dt.Rows[0]["ID_Profissional"].ToString());
                                }
                                if (permissao == 2)
                                {
                                    biomedico = Convert.ToInt32(dt.Rows[0]["ID_Profissional"].ToString());
                                }
                                if (permissao == 4)
                                {
                                    manicure = Convert.ToInt32(dt.Rows[0]["ID_Profissional"].ToString());
                                }
                                if (permissao == 3)
                                {
                                    estetica = Convert.ToInt32(dt.Rows[0]["ID_Profissional"].ToString());
                                }
                                */


                command.Dispose();
                conexao.Close();
                conexao.Dispose();


                if (cmbLogin.Text == login && txtSenha.Text == senha)
                {
                    logado = 1;

                    if (logado == 1)
                    {
                        frmPrincipal frm = new frmPrincipal();
                        frm.permi = permissao;
                        frm.cod_profissiona = profissional;
                        //this.Close();
                        frm.ShowDialog();
                        txtSenha.Text = "";
                        frmLogin_Load(sender, e);
                    }

                    
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch
            {
                MessageBox.Show("Usuário ou senha inválidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
//            frm.podo = podologo;
  //          frm.bio = biomedico;
    //        frm.est = estetica;
      //      frm.mani = manicure;
            //frm.permi = permissao;
            //frm.cod_profissiona = profissional;


        }
    


        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btEntrar_Click(null, null);
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ClassUsuario login = new ClassUsuario();
            cmbLogin.DataSource = login.Login_Profissional();
            cmbLogin.DisplayMember = "Login";
            cmbLogin.ValueMember = "ID_Profissional";
            cmbLogin.SelectedValue = 0;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logado == 0)
            {
                Application.Exit();
            }
        }

        private bool VerificaSeBancoJaExiste()
        {
            bool retorno = false;

            try
            {
                using (var conn = new System.Data.SqlClient.SqlConnection(@"Server=.\SQLEXPRESS;Database=master;Trusted_Connection=True;"))
                {
                    conn.Open();
                    using (var comm = conn.CreateCommand())
                    {
                        comm.CommandText = "SELECT 1 FROM SYS.DATABASES WHERE NAME LIKE 'ClinicaPodo'";
                        var valor = comm.ExecuteScalar();

                        if (valor != null && valor != DBNull.Value && Convert.ToInt32(valor).Equals(1))
                        {
                            retorno = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return retorno;
        }

        private void DescobrirDiretoriosPadrao(out string diretorioDados, out string diretorioLog, out string diretorioBackup)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection(@"Server=.\SQLEXPRESS;Database=master;Trusted_Connection=True;"))
            {
                var serverConnection = new Microsoft.SqlServer.Management.Common.ServerConnection(connection);
                var server = new Microsoft.SqlServer.Management.Smo.Server(serverConnection);
                diretorioDados = !string.IsNullOrWhiteSpace(server.Settings.DefaultFile) ? server.Settings.DefaultFile : (!string.IsNullOrWhiteSpace(server.DefaultFile) ? server.DefaultFile : server.MasterDBPath);
                diretorioLog = !string.IsNullOrWhiteSpace(server.Settings.DefaultLog) ? server.Settings.DefaultLog : (!string.IsNullOrWhiteSpace(server.DefaultLog) ? server.DefaultLog : server.MasterDBLogPath);
                diretorioBackup = !string.IsNullOrWhiteSpace(server.Settings.BackupDirectory) ? server.Settings.BackupDirectory : server.BackupDirectory;
            }
        }

       

        private void RestaurarDBPadrao()
        {
            try
            {
                string diretorioDados, diretorioLog, diretorioBackup;
                DescobrirDiretoriosPadrao(out diretorioDados, out diretorioLog, out diretorioBackup);

                using (var conn = new System.Data.SqlClient.SqlConnection(@"Server=.\SQLEXPRESS;Database=master;Trusted_Connection=True;"))
                {
                    conn.Open();
                    using (var comm = conn.CreateCommand())
                    {
                        var caminhoCompletoBackup = System.IO.Path.Combine(diretorioBackup, "clinicapodo.bak");
                        var caminhoCompletoDados = System.IO.Path.Combine(diretorioDados, "ClinicaPodo.mdf");
                        var caminhoCompletoLog = System.IO.Path.Combine(diretorioLog, "ClinicaPodo_Log.ldf");
                        System.IO.File.Copy("clinicapodo.bak", caminhoCompletoBackup, true);
                        comm.CommandText =
                             @"RESTORE DATABASE clinicapodo " +
                             @"FROM DISK = N'" + caminhoCompletoBackup + "' " +
                             @"WITH FILE = 1, " +
                             @"MOVE N'clinicapodo' TO N'" + caminhoCompletoDados + "', " +
                             @"MOVE N'clinicapodo_LOG' TO N'" + caminhoCompletoLog + "', " +
                             @"NOUNLOAD, REPLACE, STATS = 10";
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RestaurarDBPadraoCasoNaoExista()
        {
            try
            {
                var bancoExiste = VerificaSeBancoJaExiste();

                if (!bancoExiste)
                {
                    RestaurarDBPadrao();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
