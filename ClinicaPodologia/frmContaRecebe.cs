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
    public partial class frmContaRecebe : Form
    {
        public ClassRecebimento carrega_atendimento;
        public int Cod_Profissional;
        public frmContaRecebe()
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
            cmbServico.DataSource = servico.Pesquisa_Servico(carrega_atendimento.ID_Profissional);
            cmbServico.DisplayMember = "Tipo";
            cmbServico.ValueMember = "ID";

            cmbServico.SelectedValue = carrega_atendimento.ID_Servico;
        }

        private void cmbServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbServico.SelectedIndex > 0)
            {
                ClassServico valor = new ClassServico();
                valor.ID_TipoServico = (int)cmbServico.SelectedValue;
                DataTable dt = valor.pesquisa_valor();
                txtValorServico.Text = dt.Rows[0]["valor"].ToString();

            }




        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }
    }
}
