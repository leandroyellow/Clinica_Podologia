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
    public partial class frmUsuarioConsulta : Form
    {
        public frmUsuarioConsulta()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            ClassUsuario pesquisa_profissional = new ClassUsuario();
            dgvPesquisa.DataSource = pesquisa_profissional.PesquisaPorNome(txtNome.Text);
            dgvPesquisa.Columns[4].Visible = false;
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

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            frmUsuarioCadastra frm = new frmUsuarioCadastra();
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvPesquisa.SelectedRows;

            if (linha.Count != 1)
            {
                MessageBox.Show("Selecione 1 profissional para editar", "Profissional não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClassUsuario usuario = new ClassUsuario();
            usuario.ID_Profissional = Convert.ToInt32(linha[0].Cells[0].Value);
            usuario.Nome = linha[0].Cells[1].Value.ToString();
            usuario.Especialidade = linha[0].Cells[2].Value.ToString();
            usuario.Celular = linha[0].Cells[3].Value.ToString();
            usuario.Permissao = Convert.ToInt16 (linha[0].Cells[4].Value);
            usuario.Login = linha[0].Cells[5].Value.ToString();
            usuario.Senha = linha[0].Cells[6].Value.ToString();

            frmUsuarioCadastra editar = new frmUsuarioCadastra();
            editar.usuario_carrega = usuario;
            editar.ShowDialog();
            txtNome_TextChanged(sender, e);

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
