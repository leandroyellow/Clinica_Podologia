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
    public partial class frmAgendaAlteraValorConsulta : Form
    {
        public frmAgendaAlteraValorConsulta()
        {
            InitializeComponent();
        }
        public ClassRecebimento carrega_agenda;

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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ClassRecebimento recebimento = new ClassRecebimento();
            recebimento.ValorRecebe = Convert.ToDecimal(txtValor.Text);
            recebimento.DataConsulta = Convert.ToDateTime(txtDataConsulta.Text);
            recebimento.ID_Agenda = Convert.ToInt32(txtID_Agenda.Text);
            recebimento.PagamentoEfetuado = Convert.ToByte(txtPagamentoEfetuado.Text);
            recebimento.Salvar();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgendaAlteraValorConsulta_Shown(object sender, EventArgs e)
        {
            if (carrega_agenda != null)
            {
                txtID_Agenda.Text = carrega_agenda.ID_Agenda.ToString();
                txtDataConsulta.Text = carrega_agenda.DataConsulta.ToShortDateString();
                txtPagamentoEfetuado.Text = Convert.ToString(carrega_agenda.PagamentoEfetuado);
                txtValor.Text = Convert.ToString(carrega_agenda.ValorRecebe);
                
            }
        }
    }
}
