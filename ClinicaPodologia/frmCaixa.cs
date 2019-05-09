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
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
        }
        public int cod_profis;
        public int permi;

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            ClassUsuario profissional = new ClassUsuario();
            cmbProfissional.DisplayMember = "Nome";
            cmbProfissional.ValueMember = "ID";
            cmbProfissional.DataSource = profissional.Pesquisa_Profissional();

            cmbProfissional.SelectedValue = cod_profis;

            if (permi == 1)
            {
                cmbProfissional.Enabled = true;
            }

            AtualizaTotais();
        }

        private void AtualizaTotais()
        {
            decimal creditos = 0;
            decimal debitos = 0;
            decimal saldo = 0;

            ClassRecebimento totaliza_creditos = new ClassRecebimento();
            creditos = Convert.ToDecimal(totaliza_creditos.PesquisaCreditos(dtpIni.Value, dtpFim.Value, Convert.ToInt32(cmbProfissional.SelectedValue.ToString())).Rows[0]["creditos"]);

            txtEntrada.Text = creditos.ToString();

            ClassPagamento totaliza_debitos = new ClassPagamento();
            debitos = Convert.ToDecimal(totaliza_debitos.PesquisaDebitos(dtpIni.Value, dtpFim.Value, Convert.ToInt32(cmbProfissional.SelectedValue.ToString())).Rows[0]["Débitos"]);

            txtSaida.Text = debitos.ToString();

            saldo = creditos - debitos;

            txtSaldo.Text = saldo.ToString();

            if (saldo < 0)
            {
                txtSaldo.ForeColor = Color.Red;
            }
            else
            {
                txtSaldo.ForeColor = Color.Lime;
            }

            //txtSaldo.Text = Convert.ToString(Convert.ToDecimal(txtEntrada.Text) - Convert.ToDecimal(txtSaida.Text));




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            ClassRecebimento Receber = new ClassRecebimento();
            chtCaixa.DataSource = Receber.ListaGraficoCaixa(dtpIni.Value, dtpFim.Value, Convert.ToInt32(cmbProfissional.SelectedValue.ToString())).DefaultView;
            chtCaixa.Titles.Clear();
            chtCaixa.Titles.Add("Saldo por mês");
            chtCaixa.Series[0].XValueMember = "ANO/MES";
            chtCaixa.Series[0].YValueMembers = "CREDITO";
            chtCaixa.Series[1].XValueMember = "ANO/MES";
            chtCaixa.Series[1].YValueMembers = "DEBITO";
            chtCaixa.DataBind();
            AtualizaTotais();
            
        }

        private void dtpIni_ValueChanged(object sender, EventArgs e)
        {
            AtualizaTotais();
        }

        private void dtpFim_ValueChanged(object sender, EventArgs e)
        {
            AtualizaTotais();
        }

        private void btnContasAPagar_Click(object sender, EventArgs e)
        {
            frmContasPagar frm = new frmContasPagar();
            frm.permi = permi;
            frm.prof = cod_profis;
            frm.ShowDialog();
            AtualizaTotais();
        }

        private void btnContasAReceber_Click(object sender, EventArgs e)
        {
            frmContasReceber frm = new frmContasReceber();
            frm.cod_prof_frmcontareceber = cod_profis;
            frm.permi = permi;
            frm.ShowDialog();
            AtualizaTotais();
        }

        private void cmbProfissional_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaTotais();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorio frm = new frmRelatorio();
            frm.ShowDialog();
        }

        private void ck3D_CheckedChanged(object sender, EventArgs e)
        {
            if(ck3D.Checked == true)
            {
                chtCaixa.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
            else
            {
                chtCaixa.ChartAreas[0].Area3DStyle.Enable3D = false;
            }
        }

        private void btnRelatorioGeral_Click(object sender, EventArgs e)
        {
            frmRelatorioTotal frm = new frmRelatorioTotal();
            frm.ShowDialog();
        }
    }
}
