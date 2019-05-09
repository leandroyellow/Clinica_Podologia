using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaPodologia
{
    public partial class frmAgendaGravar : Form
    {
        public int Agendamento_Profissional;
        int row = 0;
        public int permicao;
        public ClassAgenda carrega_agenda;
        public frmAgendaGravar()
        {
            InitializeComponent();
        }



        private void frmAgendarConsulta_Load(object sender, EventArgs e)
        {
            ClassUsuario profissional = new ClassUsuario();
            cmbProfissional.DisplayMember = "Nome";
            cmbProfissional.ValueMember = "Id";
            cmbProfissional.DataSource = profissional.Pesquisa_Profissional();

            cmbProfissional.SelectedValue = Agendamento_Profissional;


            ClassCliente cliente = new ClassCliente();
            cmbCliente.DataSource = cliente.Pesquisa_Cliente();
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "id";

            ClassServico servico = new ClassServico();
            cmbServico.DataSource = servico.Pesquisa_Servico(Agendamento_Profissional);
            cmbServico.DisplayMember = "Tipo";
            cmbServico.ValueMember = "Id";

            if (permicao == 1)
            {
                cmbProfissional.Enabled = true;
            }

            // cria as colunas
            //dgvAgenda.Columns.Add("ID_Agenda", "Código da Agenda");
            dgvAgenda.Columns.Add("Dia", "Dia");
            dgvAgenda.Columns.Add("Hora", "Hora");
            dgvAgenda.Columns.Add("TempoConsulta", "Duração da Consulta");
            dgvAgenda.Columns.Add("ID_Cliente", "Código do Cliente");
            dgvAgenda.Columns.Add("NomeCliente", "Nome do Cliente");
            dgvAgenda.Columns.Add("ID_Servico", "Código do Serviço");
            


            // alinhamento
            dgvAgenda.Columns["Dia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAgenda.Columns["Hora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAgenda.Columns["TempoConsulta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // formato

            dgvAgenda.EnableHeadersVisualStyles = false;
            dgvAgenda.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(153, 182, 255);
            dgvAgenda.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvAgenda.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgvAgenda.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            dgvAgenda.Columns["ID_Cliente"].Visible = false;
            dgvAgenda.Columns["ID_Servico"].Visible = false;
            dgvAgenda.Columns["Dia"].Resizable = DataGridViewTriState.False;
            dgvAgenda.Columns["Dia"].Width = 90;
            dgvAgenda.Columns["Hora"].Resizable = DataGridViewTriState.False;
            dgvAgenda.Columns["Hora"].Width = 95;
            dgvAgenda.Columns["TempoConsulta"].Resizable = DataGridViewTriState.False;
            dgvAgenda.Columns["TempoConsulta"].Width = 200;
            dgvAgenda.Columns["NomeCliente"].Resizable = DataGridViewTriState.False;
            dgvAgenda.Columns["NomeCliente"].Width = 250;
            


        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmClienteCadastro frm = new frmClienteCadastro();
            frm.permissao = permicao;
            frm.ShowDialog();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (cmbCliente.Text.Length < 1 ||
                cmbProfissional.Text.Length < 1 ||
                nudDuracao.Text.Length < 1 ||
                cmbServico.Text.Length < 1)
            {
                MessageBox.Show("Preencha o(s) campo(s) obrigatório(s)", "Campo obrigatório em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //row = dgvAgenda.Rows.Count - 1;

            // cria uma linha

            //dgvAgenda.Rows.Add();


            // seta os valores


            ClassAgenda verificar = new ClassAgenda();
            verificar.HoraInicio = Convert.ToDateTime(dtpHora.Value.ToShortTimeString());
            verificar.HoraFim = Convert.ToDateTime(dtpHora.Value.AddMinutes((double)nudDuracao.Value - 1).ToShortTimeString());
            verificar.ID_Servico = (int)cmbServico.SelectedValue;
            verificar.Dia = Convert.ToDateTime(dtpData.Value.ToShortDateString());
            verificar.ID_Cliente = (int)cmbCliente.SelectedValue;
            verificar.ID_Profissional = (int)cmbProfissional.SelectedValue;
            DataTable dt = verificar.VerificaAgenda();
            DataTable dt2 = verificar.VerificaTodasAgendas();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Já possui cliente às " + dtpHora.Value.AddMinutes((double)nudDuracao.Value).ToShortTimeString() + "\nNão é possivel fazer este agendamento neste período de tempo!");



            }

            else if (dt2.Rows.Count > 0)
            {
                string prof = dt2.Rows[0]["Profissional"].ToString();

                MessageBox.Show("O cliente " + cmbCliente.Text + ",\njá está agendado em " + prof + "!");

            }

            else
            {
                for (int i = 0; i < nudDuracao.Value; i = i + 15)
                {
                    row = dgvAgenda.Rows.Count - 1;

                    dgvAgenda.Rows.Add();

                    dgvAgenda[0, row].Value = dtpData.Text;
                    dgvAgenda[1, row].Value = dtpHora.Value.AddMinutes(i).ToShortTimeString();
                    dgvAgenda[2, row].Value = nudDuracao.Value;
                    dgvAgenda[3, row].Value = cmbCliente.SelectedValue;
                    dgvAgenda[4, row].Value = cmbCliente.Text;
                    dgvAgenda[5, row].Value = cmbServico.SelectedValue;
                    
                }
            }

            //apagar os campos
            cmbCliente.Text = "";
            cmbCliente.Focus();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha_selecionada = dgvAgenda.SelectedRows;




            if (linha_selecionada.Count != 1)
            {
                MessageBox.Show("Selecione pelo menos 1 registro para ser removido.");
            }



            else if ((dgvAgenda.Rows.Count - 1) != dgvAgenda.CurrentRow.Index)
            {
                dgvAgenda.Rows.RemoveAt(dgvAgenda.CurrentRow.Index);
            }
            else
                MessageBox.Show("Selecione uma linha válida");

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvAgenda.Rows.Count < 1)
            {
                MessageBox.Show("Preencha o(s) campo(s) obrigatório(s)", "Campo obrigatório em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ClassAgenda atribuicao = new ClassAgenda();



            if (txtID.Text == "")
            {
                foreach (DataGridViewRow row in dgvAgenda.Rows)
                {
                    if (!row.IsNewRow)
                    {

                        atribuicao.Dia = Convert.ToDateTime (row.Cells[0].Value.ToString());
                        atribuicao.Hora = Convert.ToDateTime(row.Cells[1].Value.ToString());
                        atribuicao.TempoConsulta = Convert.ToInt16(row.Cells[2].Value.ToString());
                        atribuicao.ID_Cliente = Convert.ToInt16(row.Cells[3].Value.ToString());
                        atribuicao.ID_Servico = Convert.ToInt16(row.Cells[5].Value.ToString());
                        atribuicao.ID_Profissional = (int)cmbProfissional.SelectedValue;

                        //atribuicao.Salvar();
                        //this.Close();
                        txtID.Text = Convert.ToString(atribuicao.Salvar());

                    }
                }
                this.Close();

            }
            else
            {

                atribuicao.ID_Agenda = Convert.ToInt32(txtID.Text);
                atribuicao.Atualiza();
                this.Close();

            }
        }

        private void frmAgendaGravar_Shown(object sender, EventArgs e)
        {
            if(carrega_agenda != null)
            {
                dtpData.Text = carrega_agenda.Dia.ToString();
                dtpHora.Text = carrega_agenda.Hora.ToString();
            }
             
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbProfissional_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(permicao == 1 && Convert.ToInt32(cmbProfissional.Text.Length.ToString()) > 1)
            {
                ClassServico servico = new ClassServico();
                cmbServico.DataSource = servico.Pesquisa_Servico(Convert.ToInt32(cmbProfissional.SelectedValue.ToString()));
                cmbServico.DisplayMember = "Tipo";
                cmbServico.ValueMember = "Id";
            }
        }

        
    }
}
