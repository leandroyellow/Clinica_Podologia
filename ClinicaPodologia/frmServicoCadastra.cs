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
    public partial class frmServicoCadastra : Form
    {
        
        public frmServicoCadastra()
        {
            InitializeComponent();
        }
        public int id_prof;
        public int permi;
        public ClassServico servico_carrega;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbProfissional.Text.Length < 1 ||
                 txtTipoServico.Text.Length < 1 ||
                 txtValorServico.Text.Length < 1 )
            {
                MessageBox.Show("Preencha o(s) campo(s) obrigatório(s)", "Campo obrigatório em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClassServico servico = new ClassServico();
            servico.ID_Profissional = (int)cmbProfissional.SelectedValue;
            servico.Tipo = txtTipoServico.Text;
            servico.Valor = Convert.ToDecimal(txtValorServico.Text.Replace(".", ","));
            

            if (txtID.Text == "")
            {
                txtID.Text = Convert.ToString(servico.Salvar());

                txtID.Clear();
                txtTipoServico.Clear();
                txtValorServico.Clear();
                
            }
            else
            {
                servico.ID_TipoServico = Convert.ToInt32(txtID.Text);
                servico.Atualiza();
                this.Close();
            }
        }

        private void frmServicoCadastra_Load(object sender, EventArgs e)
        {
            ClassUsuario profissional = new ClassUsuario();
            cmbProfissional.DataSource = profissional.Pesquisa_Profissional();
            cmbProfissional.DisplayMember = "Nome";
            cmbProfissional.ValueMember = "ID";

            cmbProfissional.SelectedValue = id_prof;

            if (permi == 1)
            {
                cmbProfissional.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmServicoCadastra_Shown(object sender, EventArgs e)
        {
            if (servico_carrega != null)
            {
                txtID.Text = servico_carrega.ID_TipoServico.ToString();
                txtTipoServico.Text = servico_carrega.Tipo;
                txtValorServico.Text = Convert.ToDecimal (servico_carrega.Valor).ToString();
                cmbProfissional.SelectedValue = servico_carrega.ID_Profissional;
                
            }

            if (txtID.Text != "")
            {
                btnSalvar.Text = "Atualizar";
                this.Text = "Atualizar Usuário";
            }
        }

        private void mskValorServico_Click(object sender, EventArgs e)
        {
            txtValorServico.SelectionStart = 1;
        }

        private void txtValorServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }
    }
}
