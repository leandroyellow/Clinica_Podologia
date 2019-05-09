using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaPodologia
{
    public partial class frmUsuarioCadastra : Form
    {
        public frmUsuarioCadastra()
        {
            InitializeComponent();
        }

        public ClassUsuario usuario_carrega;

        private void cmbEspecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspecialidade.Text == "Administrador")
            {
                txtPermissao.Text = "1";
            }
            else if (cmbEspecialidade.Text == "Biomédico")
            {
                txtPermissao.Text = "2";
            }
            else if (cmbEspecialidade.Text == "Esteticista")
            {
                txtPermissao.Text = "3";
            }
            else if (cmbEspecialidade.Text == "Manicure")
            {
                txtPermissao.Text = "4";
            }
            else if (cmbEspecialidade.Text == "Podólogo")
            {
                txtPermissao.Text = "5";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length < 1 ||
                 cmbEspecialidade.Text.Length < 1 ||
                 mskCelular.Text.Length < 1 ||
                 txtLogin.Text.Length < 1 ||
                 txtSenha.Text.Length < 1)
            {
                MessageBox.Show("Preencha o(s) campo(s) obrigatório(s)", "Campo obrigatório em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClassUsuario usuario = new ClassUsuario();
            usuario.Nome = txtNome.Text;
            usuario.Especialidade = cmbEspecialidade.Text;
            usuario.Celular = mskCelular.Text;
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Permissao = Convert.ToInt16(txtPermissao.Text);
            usuario.AtendimentoInicio = Convert.ToDateTime(dtpInicio.Value.ToString("HH:mm"));
            usuario.AtendimentoFim = Convert.ToDateTime(dtpFim.Value.ToString("HH:mm"));

            if (txtID.Text == "")
            {
                txtID.Text = Convert.ToString(usuario.Salvar());

                txtID.Clear();
                txtNome.Clear();
                cmbEspecialidade.SelectedValue = -1;
                mskCelular.Clear();
                txtLogin.Clear();
                txtSenha.Clear();
                txtPermissao.Clear();
            }
            else
            {
                usuario.ID_Profissional = Convert.ToInt32(txtID.Text);
                usuario.Atualiza();
                this.Close();
            }
        }

        private void frmUsuarioCadastra_Shown(object sender, EventArgs e)
        {
            if (usuario_carrega != null)
            {
                txtID.Text = usuario_carrega.ID_Profissional.ToString();
                txtNome.Text = usuario_carrega.Nome;
                cmbEspecialidade.Text = usuario_carrega.Especialidade;
                mskCelular.Text = usuario_carrega.Celular;
                txtPermissao.Text = usuario_carrega.Permissao.ToString();
                txtLogin.Text = usuario_carrega.Login;
                txtSenha.Text = usuario_carrega.Senha;
                //dtpInicio.Text = usuario_carrega.AtendimentoInicio.ToString();
                //dtpFim.Text = usuario_carrega.AtendimentoFim.ToString();
            }

            if (txtID.Text != "")
            {
                btnSalvar.Text = "Atualizar";
                this.Text = "Atualizar Usuário";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbEspecialidade_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
