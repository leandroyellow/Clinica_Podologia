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
    public partial class frmClienteProntuario : Form
    {
        public frmClienteProntuario()
        {
            InitializeComponent();
        }

        public ClassProntuario prontuario_cliente_carrega;

        private void frmClienteProntuario_Shown(object sender, EventArgs e)
        {
            if (prontuario_cliente_carrega != null)
            {
                if (prontuario_cliente_carrega.Prontuario != null )
                {
                    
                    txtID.Text = prontuario_cliente_carrega.ID_Prontuario.ToString();
                    rtProntuario.Text = prontuario_cliente_carrega.Prontuario;
                }

                txtID_Cliente.Text = prontuario_cliente_carrega.ID_Cliente.ToString();
                txtNome.Text = prontuario_cliente_carrega.NomeCliente;



            }

            if (txtID.Text != "")
            {
                btnSalvar.Text = "Atualizar";
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (rtProntuario.Text.Length < 1 )
            {
                MessageBox.Show("Preencha o(s) campo(s) obrigatório(s)", "Campo obrigatório em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClassProntuario usuario = new ClassProntuario();
            usuario.Prontuario = rtProntuario.Text;
            usuario.ID_Cliente = Convert.ToInt16(txtID_Cliente.Text);
            

            if (txtID.Text == "")
            {
                txtID.Text = Convert.ToString(usuario.Salvar());

                this.Close();
            }
            else
            {
                usuario.ID_Cliente = Convert.ToInt32(txtID_Cliente.Text);
                usuario.Atualiza();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFonte_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            rtProntuario.SelectionFont = fontDialog1.Font;
            
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rtProntuario.SelectionColor = colorDialog1.Color;
        }
    }
}
