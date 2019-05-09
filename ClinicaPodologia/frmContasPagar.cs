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
    public partial class frmContasPagar : Form
    {
        public frmContasPagar()
        {
            InitializeComponent();
        }
        public int prof;
        public int permi;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtTipo.Text.Length < 1 ||
                txtValor.Text.Length < 1)
            {
                MessageBox.Show("Preencha o(s) campo(s) obrigatório(s)", "Campo obrigatório em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClassPagamento conta = new ClassPagamento();

            conta.Tipo = txtTipo.Text;
            conta.Valor = Convert.ToDecimal(txtValor.Text.ToString());
            conta.Data = Convert.ToDateTime(txtData.Text);
            conta.ID_Profissional = Convert.ToInt32(cmbProfissional.SelectedValue.ToString());

            if (txtID.Text == "")
            {
                txtID.Text = Convert.ToString(conta.Salvar());

                this.Close();
            }

            else
            {
                conta.Atualiza();
                btnSalvar.Text = "Atualizar";
                this.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmContasPagar_Load(object sender, EventArgs e)
        {
            ClassUsuario profissional = new ClassUsuario();
            cmbProfissional.DisplayMember = "Nome";
            cmbProfissional.ValueMember = "ID";
            cmbProfissional.DataSource = profissional.Pesquisa_Profissional();

            cmbProfissional.SelectedValue = prof;

            if (permi == 1)
            {
                cmbProfissional.Enabled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_KeyPress_1(object sender, KeyPressEventArgs e)
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
