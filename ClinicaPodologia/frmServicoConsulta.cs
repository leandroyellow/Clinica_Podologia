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
    public partial class frmServicoConsulta : Form
    {
        public frmServicoConsulta()
        {
            InitializeComponent();
        }
        public int cod_profis;
        public int permi;

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            frmServicoCadastra frm = new frmServicoCadastra();
            frm.id_prof = cod_profis;
            frm.permi = permi;
            frm.ShowDialog();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            ClassServico pesquisa_servico = new ClassServico();
            dgvPesquisa.DataSource = pesquisa_servico.PesquisaPorNome(txtNome.Text, cod_profis);
            dgvPesquisa.Columns[0].Visible = false;
            dgvPesquisa.Columns[3].Visible = false;
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
                ClassServico servico = new ClassServico();
                servico.ID_TipoServico = (int)linha_selecionada[0].Cells[0].Value;

               
                DataTable dt = servico.pesquisa_ID_agenda();
                

                if (Convert.ToInt32(dt.Rows[0]["contador"].ToString()) <= 0)
                {
                    ClassServico apaga_servico = new ClassServico();
                    apaga_servico.Apagar(Convert.ToInt32(linha_selecionada[0].Cells[0].Value.ToString()));
                    txtNome_TextChanged(sender, e);
                }
                else
                {
                    MessageBox.Show("Serviço não pode ser removido.");
                }
                
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvPesquisa.SelectedRows;

            if (linha.Count != 1)
            {
                MessageBox.Show("Selecione 1 serviço para editar", "Serviço não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClassServico servico = new ClassServico();
            servico.ID_TipoServico = Convert.ToInt32(linha[0].Cells[0].Value);
            servico.Tipo = linha[0].Cells[1].Value.ToString();
            servico.Valor = Convert.ToDecimal (linha[0].Cells[2].Value.ToString());
            servico.ID_Profissional = (int)linha[0].Cells[3].Value;
            

            frmServicoCadastra editar = new frmServicoCadastra();
            editar.servico_carrega = servico;
            editar.permi = permi;
            editar.ShowDialog();
            txtNome_TextChanged(sender, e);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
