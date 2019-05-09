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
    public partial class frmContaConsulta : Form
    {
        public ClassRecebimento carrega_atendimento;
        public int Cod_Profissional;
        public frmContaConsulta()
        {
            InitializeComponent();
        }

        
        private void frmCaixa_Shown(object sender, EventArgs e)
        {
            if (carrega_atendimento != null)
            {
                dtpDataServico.Value = carrega_atendimento.DataConsulta;
            }
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {

            ClassUsuario profissional = new ClassUsuario();
            cmbProfissional.DataSource = profissional.Pesquisa_Profissional();
            cmbProfissional.DisplayMember = "Nome";
            cmbProfissional.ValueMember = "id";

            cmbProfissional.SelectedValue = Cod_Profissional;

            ClassCliente cliente = new ClassCliente();
            cmbCliente.DataSource = cliente.Pesquisa_Cliente();
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "id";

            cmbCliente.SelectedValue = carrega_atendimento.ID_Cliente;

            ClassServico servico = new ClassServico();
            cmbServico.DisplayMember = "Tipo";
            cmbServico.ValueMember = "ID";
            cmbServico.DataSource = servico.Pesquisa_Servico(carrega_atendimento.ID_Profissional);


            cmbServico.SelectedValue = carrega_atendimento.ID_Servico;

            if(txtID.Text.Length > 0)
            {
                btnSalvar.Enabled = false;
            }
            
        }

        private void cmbServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbServico.SelectedIndex >= 0)
            {
                ClassServico valor = new ClassServico();
                valor.ID_TipoServico = (int)cmbServico.SelectedValue;
                DataTable dt = valor.pesquisa_valor();
                txtValorServico.Text = dt.Rows[0][0].ToString();

            }




        }

       

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.Text.Length < 1 ||
                 cmbProfissional.Text.Length < 1 ||
                 cmbServico.Text.Length < 1 ||
                 dtpDataServico.Text.Length < 1 ||
                 txtValorServico.Text.Length < 1)
            {
                MessageBox.Show("Preencha o(s) campo(s) obrigatório(s)", "Campo obrigatório em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClassRecebimento recebe = new ClassRecebimento();
            recebe.ID_Agenda = (int)cmbServico.SelectedValue;
            recebe.ValorRecebe = Convert.ToDecimal(txtValorServico.Text);
            recebe.DataConsulta = Convert.ToDateTime(dtpDataServico.Text.ToString());
            //recebe.PagamentoEfetuado = rbNao.Checked;
            

            if (txtID.Text == "")
            {
                txtID.Text = Convert.ToString(recebe.Salvar());

                this.Close();
            }
            else
            {
                recebe.ID_Profissional = Convert.ToInt32(txtID.Text);
                recebe.Atualiza();
                this.Close();
            }
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            cmbServico.Enabled = true;
        }
    }
}
