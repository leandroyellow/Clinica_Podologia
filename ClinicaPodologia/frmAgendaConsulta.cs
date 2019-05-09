using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ClinicaPodologia
{
    public partial class frmAgendaConsulta : Form
    {
        CultureInfo culture = new CultureInfo("pt-BR");


        public frmAgendaConsulta()
        {
            InitializeComponent();

        }

        public int Cod_Profissional;
        public int permi;



        private void frmAgenda_Load(object sender, EventArgs e)
        {
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

            lblAno.Text = Convert.ToString(DateTime.Now.Year);
            lblDia.Text = Convert.ToString(DateTime.Now.Day);
            lblMes.Text = dtfi.GetMonthName(DateTime.Now.Month);
            lblSemana.Text = dtfi.GetDayName(DateTime.Now.DayOfWeek);

            ClassUsuario profissional = new ClassUsuario();

            cmbProfissional.DisplayMember = "Nome";
            cmbProfissional.ValueMember = "ID";
            cmbProfissional.DataSource = profissional.Pesquisa_Profissional();

            cmbProfissional.SelectedValue = Cod_Profissional;

            if (permi == 1)
            {
                cmbProfissional.Enabled = true;
            }

            ClassAgenda data = new ClassAgenda();
            dgvAgenda.DataSource = data.PesquisaPorData(cldAgenda.SelectionStart.ToShortDateString(), Cod_Profissional);
            // formato

            dgvAgenda.EnableHeadersVisualStyles = false;
            dgvAgenda.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(153, 182, 255);
            dgvAgenda.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvAgenda.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
            dgvAgenda.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 150);

            foreach (DataGridViewRow row in dgvAgenda.Rows)
            {
                if (row.Cells[1].Value.ToString() != "" && row.Cells[10].Value.ToString() == "")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 128);

                }
                else if (row.Cells[10].Value.ToString() != "")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(147, 201, 255);
                }
            }

            dgvAgenda.Columns[2].Visible = false;
            dgvAgenda.Columns[3].Visible = false;
            dgvAgenda.Columns[4].Visible = false;
            dgvAgenda.Columns[5].Visible = false;
            dgvAgenda.Columns[6].Visible = false;
            dgvAgenda.Columns[7].Visible = false;
            dgvAgenda.Columns[9].Visible = false;
            dgvAgenda.Columns[10].Visible = false;

            dgvAgenda.AutoResizeColumns();

        }



        private void btnIncluir_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha_selecionada = dgvAgenda.SelectedRows;

            if (linha_selecionada.Count != 1)
            {
                MessageBox.Show("Selecione pelo menos 1 horário para incluir na agenda.");
            }



            else if (linha_selecionada[0].Cells[1].Value.ToString() == "")
            {


                ClassAgenda agendamento = new ClassAgenda();
                agendamento.Hora = Convert.ToDateTime(linha_selecionada[0].Cells[0].Value.ToString());
                agendamento.Dia = Convert.ToDateTime(cldAgenda.SelectionStart.ToShortDateString());





                frmAgendaGravar frm = new frmAgendaGravar();


                if (permi != 1)
                {
                    frm.carrega_agenda = agendamento;
                    frm.Agendamento_Profissional = Cod_Profissional;
                    frm.permicao = permi;
                }
                else
                {
                    frm.carrega_agenda = agendamento;
                    frm.Agendamento_Profissional = Convert.ToInt32(cmbProfissional.SelectedValue);
                    frm.permicao = permi;
                }

                frm.ShowDialog();
                cldAgenda_DateChanged(sender, null);


            }
            else if (linha_selecionada[0].Cells[1].Value.ToString() != "")
                MessageBox.Show("Já possui um Cliente agendado neste horário");
        }



        private void btnProntuario_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha_selecionada = dgvAgenda.SelectedRows;

            if (linha_selecionada.Count != 1)
            {
                MessageBox.Show("Selecione pelo menos 1 horário para incluir na agenda.");
            }



            else if (linha_selecionada[0].Cells[5].Value.ToString() == "" && linha_selecionada[0].Cells[1].Value.ToString() != "")
            {


                ClassProntuario agendamento = new ClassProntuario();
                agendamento.NomeCliente = linha_selecionada[0].Cells[1].Value.ToString();
                agendamento.ID_Cliente = Convert.ToInt16(linha_selecionada[0].Cells[2].Value.ToString());


                frmClienteProntuario frm = new frmClienteProntuario();
                frm.prontuario_cliente_carrega = agendamento;
                frm.ShowDialog();
                cldAgenda_DateChanged(sender, null);




            }
            else if (linha_selecionada[0].Cells[5].Value.ToString() != "")
            {

                ClassProntuario agendamento = new ClassProntuario();
                agendamento.NomeCliente = linha_selecionada[0].Cells[1].Value.ToString();
                agendamento.ID_Cliente = Convert.ToInt16(linha_selecionada[0].Cells[2].Value.ToString());
                agendamento.ID_Prontuario = Convert.ToInt16(linha_selecionada[0].Cells[5].Value.ToString());
                agendamento.Prontuario = linha_selecionada[0].Cells[6].Value.ToString();

                frmClienteProntuario frm = new frmClienteProntuario();
                frm.prontuario_cliente_carrega = agendamento;
                frm.ShowDialog();
                cldAgenda_DateChanged(sender, null);

            }
            else if (linha_selecionada[0].Cells[5].Value.ToString() == "")
            {
                MessageBox.Show("Selecione uma linha válida!");
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha_selecionada = dgvAgenda.SelectedRows;


            if (linha_selecionada.Count != 1)
            {
                MessageBox.Show("Selecione pelo menos 1 registro para ser removido.");
            }
            else if (linha_selecionada[0].Cells[7].Value.ToString() == "")
            {
                MessageBox.Show("Selecione 1 linha com agendamento!");
            }
            else if (linha_selecionada[0].Cells[10].Value.ToString() == "")
            {
                ClassAgenda apaga_agendamento = new ClassAgenda();
                apaga_agendamento.Apagar(Convert.ToInt32(linha_selecionada[0].Cells[7].Value.ToString()));
                cldAgenda_DateChanged(sender, null);
            }
            else if (linha_selecionada[0].Cells[10].Value.ToString() != "")
            {
                MessageBox.Show("Não pode ser excluido um agendamento já atendido!");
            }
        }


        private void cldAgenda_DateSelected(object sender, DateRangeEventArgs e)
        {

        }
        private void cldAgenda_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

            lblAno.Text = Convert.ToString(cldAgenda.SelectionStart.Year);
            lblDia.Text = Convert.ToString(cldAgenda.SelectionStart.Day);
            lblMes.Text = dtfi.GetMonthName(Convert.ToInt32(cldAgenda.SelectionStart.Month));
            lblSemana.Text = dtfi.GetDayName(cldAgenda.SelectionStart.DayOfWeek);

            ClassAgenda data = new ClassAgenda();
            dgvAgenda.DataSource = data.PesquisaPorData(cldAgenda.SelectionStart.ToShortDateString(), Convert.ToInt32(cmbProfissional.SelectedValue.ToString()));
            // formato

            dgvAgenda.EnableHeadersVisualStyles = false;
            dgvAgenda.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(153, 182, 255);
            dgvAgenda.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvAgenda.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);


            foreach (DataGridViewRow row in dgvAgenda.Rows)
            {
                if (row.Cells[1].Value.ToString() != "" && row.Cells[10].Value.ToString() == "")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 128);

                }
                else if (row.Cells[10].Value.ToString() != "")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(147, 201, 255);
                }
            }


            dgvAgenda.Columns[2].Visible = false;
            dgvAgenda.Columns[3].Visible = false;
            dgvAgenda.Columns[4].Visible = false;
            dgvAgenda.Columns[5].Visible = false;
            dgvAgenda.Columns[6].Visible = false;
            dgvAgenda.Columns[7].Visible = false;
            dgvAgenda.Columns[9].Visible = false;
            dgvAgenda.Columns[10].Visible = false;

            dgvAgenda.AutoResizeColumns();



        }

        private void btnAtendimento_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha_selecionada = dgvAgenda.SelectedRows;

            if (linha_selecionada.Count != 1)
            {
                MessageBox.Show("Selecione pelo menos 1 agendamento.");
            }



            else if (linha_selecionada[0].Cells[1].Value.ToString() != "" &&
                     linha_selecionada[0].Cells[7].Value.ToString() != "" &&
                     linha_selecionada[0].Cells[3].Value.ToString() != "" &&
                     linha_selecionada[0].Cells[11].Value.ToString() != "" &&
                     linha_selecionada[0].Cells[10].Value.ToString() == "")
            {


                ClassRecebimento recebe = new ClassRecebimento();
                recebe.ID_Agenda = (int)linha_selecionada[0].Cells[7].Value;
                recebe.DataConsulta = Convert.ToDateTime(linha_selecionada[0].Cells[3].Value);
                recebe.ValorRecebe = Convert.ToDecimal(linha_selecionada[0].Cells[11].Value);
                recebe.PagamentoEfetuado = 0;
                recebe.Salvar();




                /*
                frmContaConsulta frm = new frmContaConsulta();

                frm.carrega_atendimento = recebe;
                frm.Cod_Profissional = Cod_Profissional;
                
                frm.ShowDialog();
                */
                cldAgenda_DateChanged(sender, null);


            }
            else if (linha_selecionada[0].Cells[1].Value.ToString() == "")
            {
                MessageBox.Show("Não possui um Cliente agendado neste horário para atendimento!");
            }
            else if (linha_selecionada[0].Cells[10].Value.ToString() != "")
            {
                MessageBox.Show("Consulta Atendida!");
            }

        }

        private void cmbProfissional_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassAgenda data = new ClassAgenda();
            dgvAgenda.DataSource = data.PesquisaPorData(cldAgenda.SelectionStart.ToShortDateString(), Convert.ToInt32(cmbProfissional.SelectedValue.ToString()));
            // formato

            dgvAgenda.EnableHeadersVisualStyles = false;
            dgvAgenda.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(153, 182, 255);
            dgvAgenda.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvAgenda.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);


            foreach (DataGridViewRow row in dgvAgenda.Rows)
            {
                if (row.Cells[1].Value.ToString() != "" && row.Cells[10].Value.ToString() == "")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 128);

                }
                else if (row.Cells[10].Value.ToString() != "")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(147, 201, 255);
                }
            }


            dgvAgenda.Columns[2].Visible = false;
            dgvAgenda.Columns[3].Visible = false;
            dgvAgenda.Columns[4].Visible = false;
            dgvAgenda.Columns[5].Visible = false;
            dgvAgenda.Columns[6].Visible = false;
            dgvAgenda.Columns[7].Visible = false;
            dgvAgenda.Columns[9].Visible = false;
            dgvAgenda.Columns[10].Visible = false;

            dgvAgenda.AutoResizeColumns();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alterarOValorDaConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha_selecionada = dgvAgenda.SelectedRows;

            if (linha_selecionada.Count != 1)
            {
                MessageBox.Show("Selecione pelo menos 1 agendamento.");
            }



            else if (linha_selecionada[0].Cells[1].Value.ToString() != "" &&
                     linha_selecionada[0].Cells[7].Value.ToString() != "" &&
                     linha_selecionada[0].Cells[3].Value.ToString() != "" &&
                     linha_selecionada[0].Cells[11].Value.ToString() != "" &&
                     linha_selecionada[0].Cells[10].Value.ToString() == "")
            {


                ClassRecebimento recebe = new ClassRecebimento();
                recebe.ID_Agenda = (int)linha_selecionada[0].Cells[7].Value;
                recebe.DataConsulta = Convert.ToDateTime(linha_selecionada[0].Cells[3].Value);
                recebe.ValorRecebe = Convert.ToDecimal(linha_selecionada[0].Cells[11].Value);
                recebe.PagamentoEfetuado = 0;






                frmAgendaAlteraValorConsulta frm = new frmAgendaAlteraValorConsulta();
                frm.carrega_agenda = recebe;


                frm.ShowDialog();

                cldAgenda_DateChanged(sender, null);
            }
        }
    }
}
