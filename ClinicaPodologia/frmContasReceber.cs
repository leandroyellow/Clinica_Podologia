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
    public partial class frmContasReceber : Form
    {
        public frmContasReceber()
        {
            InitializeComponent();
        }
        public int cod_prof_frmcontareceber;
        public int permi;
        decimal valor = 0;

        private void frmContasReceber_Load(object sender, EventArgs e)
        {
            ClassUsuario profissional = new ClassUsuario();
            cmbProfissional.DisplayMember = "Nome";
            cmbProfissional.ValueMember = "ID";
            cmbProfissional.DataSource = profissional.Pesquisa_Profissional();

            cmbProfissional.SelectedValue = cod_prof_frmcontareceber;

            ClassCliente cliente = new ClassCliente();
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "Id";
            cmbCliente.DataSource = cliente.Pesquisa_Cliente();

            if (permi == 1)
            {
                cmbProfissional.Enabled = true;
            }

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (cmbCliente.SelectedIndex >= 0)
           {
                ClassRecebimento recebe = new ClassRecebimento();
                dgvContaRecebe.DataSource = recebe.RecebePagamento(Convert.ToInt32(cmbCliente.SelectedValue), Convert.ToInt32(cmbProfissional.SelectedValue), Convert.ToByte(rbReceber.Checked));

                if (dgvContaRecebe.Columns[0].Name != "marcado")
                {
                    var col = new DataGridViewCheckBoxColumn();
                    col.Name = "marcado";
                    col.HeaderText = "Pagar";
                    col.FalseValue = "0";
                    col.TrueValue = "1";


                    col.CellTemplate.Value = false;
                    col.CellTemplate.Style.NullValue = false;

                    dgvContaRecebe.Columns.Insert(0, col);

                    dgvContaRecebe.ReadOnly = false;

                }
                dgvContaRecebe.Columns[2].Visible = false;
                dgvContaRecebe.Columns[3].Visible = false;
                dgvContaRecebe.Columns[6].Visible = false;


            }
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvContaRecebe.Rows)
            {
                if (row.IsNewRow) continue;
                if (Convert.ToBoolean(row.Cells["marcado"].FormattedValue))
                {
                    ClassRecebimento recebe = new ClassRecebimento();
                    //recebe.ID_Servico = Convert.ToInt32(row.Cells[3].Value.ToString());
                    //recebe.ValorRecebe = Convert.ToDecimal(row.Cells[4].Value.ToString());
                    recebe.TipoPagamento = cmbTipoPagamento.Text;
                    recebe.Parcelamento = (int)nudParcelamento.Value;
                    recebe.DataPagamento = dtpDataPagamento.Value;
                    recebe.PagamentoEfetuado = Convert.ToByte (row.Cells[0].Value.ToString());
                    recebe.ID_ContaRecebe = (int)row.Cells[2].Value;
                    recebe.Atualiza();
                }
            }

            cmbProfissional_SelectedIndexChanged(sender, e);

        }

        

        private void cmbProfissional_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProfissional.SelectedIndex >= 0)
            {
                ClassRecebimento recebe = new ClassRecebimento();
                dgvContaRecebe.DataSource = recebe.RecebePagamento(Convert.ToInt32(cmbCliente.SelectedValue), Convert.ToInt32(cmbProfissional.SelectedValue), Convert.ToByte(rbReceber.Checked));

                if (dgvContaRecebe.Columns[0].Name != "marcado")
                {
                    var col = new DataGridViewCheckBoxColumn();
                    col.Name = "marcado";
                    col.HeaderText = "Pagar";
                    col.FalseValue = "0";
                    col.TrueValue = "1";


                    col.CellTemplate.Value = false;
                    //col.CellTemplate.Style.NullValue = false;

                    dgvContaRecebe.Columns.Insert(0, col);

                    //dgvContaRecebe.ReadOnly = false;

                }
                dgvContaRecebe.Columns[2].Visible = false;
                dgvContaRecebe.Columns[3].Visible = false;
                dgvContaRecebe.Columns[6].Visible = false;

            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private decimal somaValoresConta()
        {
            valor = 0;
            txtValorTotal.Clear();

            foreach (DataGridViewRow row in dgvContaRecebe.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == "1")
                {
                    valor = valor + Convert.ToDecimal(row.Cells[4].Value);

                    txtValorTotal.Text = valor.ToString();

                }

                
            }
            

            return valor;
            

        }

        

        private void dgvContaRecebe_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnSalvar.Focus();
            somaValoresConta();
        }

        private void rbPagar_CheckedChanged(object sender, EventArgs e)
        {
            ClassRecebimento recebe = new ClassRecebimento();
            dgvContaRecebe.DataSource = recebe.RecebePagamento(Convert.ToInt32(cmbCliente.SelectedValue), Convert.ToInt32(cmbProfissional.SelectedValue), Convert.ToByte(rbReceber.Checked));
        }

        private void rbReceber_CheckedChanged(object sender, EventArgs e)
        {
            ClassRecebimento recebe = new ClassRecebimento();
            dgvContaRecebe.DataSource = recebe.RecebePagamento(Convert.ToInt32(cmbCliente.SelectedValue), Convert.ToInt32(cmbProfissional.SelectedValue), Convert.ToByte(rbReceber.Checked));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ClassRecebimento recebe = new ClassRecebimento();
            dgvContaRecebe.DataSource = recebe.RecebePagamentoAmbas(Convert.ToInt32(cmbCliente.SelectedValue), Convert.ToInt32(cmbProfissional.SelectedValue));
        }
    }
}
