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
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            ClassUsuario pesquisa_profissional = new ClassUsuario();
            dgvPesquisa.DataSource = pesquisa_profissional.PesquisaPorNome(txtNome.Text);
            dgvPesquisa.AutoResizeColumns();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha_selecionada = dgvPesquisa.SelectedRows;


            if (linha_selecionada.Count != 1)
            {
                MessageBox.Show("Selecione pelo menos 1 registro para ser removido.");
            }
            else
            {
                ClassUsuario apaga_profissional = new ClassUsuario();
                apaga_profissional.Apagar(Convert.ToInt32(linha_selecionada[0].Cells[0].Value.ToString()));
                txtNome_TextChanged(sender, e);

            }
        }
    }
}
