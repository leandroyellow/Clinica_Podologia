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
    public partial class frmClienteConsulta : Form
    {
        public frmClienteConsulta()
        {
            InitializeComponent();
        }

        public int permissao;

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            frmClienteCadastro frm = new frmClienteCadastro();
            frm.permissao = permissao;
            frm.ShowDialog();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            ClassCliente pesquisa_cliente = new ClassCliente();
            dgvPesquisa.DataSource = pesquisa_cliente.PesquisaPorNome(txtNome.Text);
            dgvPesquisa.Columns["ID_Cliente"].Visible = false;
            dgvPesquisa.Columns["Etnia"].Visible = false;
            dgvPesquisa.Columns["Pratica Esporte"].Visible = false;
            dgvPesquisa.Columns["Frequência"].Visible = false;
            dgvPesquisa.Columns["Número do Calçado"].Visible = false;
            dgvPesquisa.Columns["Material do Calçado"].Visible = false;
            dgvPesquisa.Columns["Tipo de Calçado"].Visible = false;
            dgvPesquisa.Columns["Destro ou Canhoto"].Visible = false;
            dgvPesquisa.Columns["Formato da Unha"].Visible = false;
            dgvPesquisa.Columns["Onicoatrofia"].Visible = false;
            dgvPesquisa.Columns["Onicocriptose"].Visible = false;
            dgvPesquisa.Columns["Onicorrexe"].Visible = false;
            dgvPesquisa.Columns["Granuloma"].Visible = false;
            dgvPesquisa.Columns["Onicogrifose"].Visible = false;
            dgvPesquisa.Columns["AlteracaoCor"].Visible = false;
            dgvPesquisa.Columns["Onicolise"].Visible = false;
            dgvPesquisa.Columns["Onicofose"].Visible = false;
            dgvPesquisa.Columns["Onicomicose"].Visible = false;
            dgvPesquisa.Columns["ExostoseUngueal"].Visible = false;
            dgvPesquisa.Columns["PsoriaseUnha"].Visible = false;
            dgvPesquisa.Columns["Ungueal"].Visible = false;
            dgvPesquisa.Columns["AlteracoesLaminas"].Visible = false;
            dgvPesquisa.Columns["HaluxVagusD"].Visible = false;
            dgvPesquisa.Columns["HaluxVagusE"].Visible = false;
            dgvPesquisa.Columns["HaluxRigidusD"].Visible = false;
            dgvPesquisa.Columns["HaluxRigidusE"].Visible = false;
            dgvPesquisa.Columns["DedosGarrasMartelo"].Visible = false;
            dgvPesquisa.Columns["EsporaoCalcaneo"].Visible = false;
            dgvPesquisa.Columns["Perodactilia"].Visible = false;
            dgvPesquisa.Columns["PeCavo"].Visible = false;
            dgvPesquisa.Columns["PePlano"].Visible = false;
            dgvPesquisa.Columns["AlteracaoOrtopedica"].Visible = false;
            dgvPesquisa.Columns["CirurgiaMMII"].Visible = false;
            dgvPesquisa.Columns["TratamentoMedicamento"].Visible = false;
            dgvPesquisa.Columns["Alergico"].Visible = false;
            dgvPesquisa.Columns["AlergicoSim"].Visible = false;
            dgvPesquisa.Columns["PatologiaAdquirida"].Visible = false;
            dgvPesquisa.Columns["Diabete"].Visible = false;
            dgvPesquisa.Columns["Etilista"].Visible = false;
            dgvPesquisa.Columns["Tabagismo"].Visible = false;
            dgvPesquisa.Columns["DST"].Visible = false;
            dgvPesquisa.Columns["FamiliaDiabete"].Visible = false;
            dgvPesquisa.Columns["AlteracaoPressao"].Visible = false;
            dgvPesquisa.Columns["GravidezLactacao"].Visible = false;
            dgvPesquisa.Columns["Cardiopatia"].Visible = false;
            dgvPesquisa.Columns["OutrasPatologias"].Visible = false;
            dgvPesquisa.Columns["Bromidrose"].Visible = false;
            dgvPesquisa.Columns["Neuropatica"].Visible = false;
            dgvPesquisa.Columns["Anidrose"].Visible = false;
            dgvPesquisa.Columns["Hiperhidrose"].Visible = false;
            dgvPesquisa.Columns["Disidrose"].Visible = false;
            dgvPesquisa.Columns["Isquemica"].Visible = false;
            dgvPesquisa.Columns["Frieira"].Visible = false;
            dgvPesquisa.Columns["PsoriasePele"].Visible = false;
            dgvPesquisa.Columns["TineaPedis"].Visible = false;
            dgvPesquisa.Columns["MalPerfurante"].Visible = false;
            dgvPesquisa.Columns["Fissuras"].Visible = false;
            dgvPesquisa.Columns["AlteracaoPele"].Visible = false;
            dgvPesquisa.Columns["Monofilamento"].Visible = false;
            dgvPesquisa.Columns["Diapasao"].Visible = false;
            dgvPesquisa.Columns["Digitopressao"].Visible = false;
            dgvPesquisa.Columns["Pulsos"].Visible = false;
            dgvPesquisa.Columns["NormalD"].Visible = false;
            dgvPesquisa.Columns["PalidoD"].Visible = false;
            dgvPesquisa.Columns["CianotipoD"].Visible = false;
            dgvPesquisa.Columns["NormalE"].Visible = false;
            dgvPesquisa.Columns["PalidoE"].Visible = false;
            dgvPesquisa.Columns["CianotipoE"].Visible = false;
            dgvPesquisa.Columns["ID_Prontuario"].Visible = false;
            dgvPesquisa.Columns["Prontuario"].Visible = false;
            dgvPesquisa.AutoResizeColumns();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha_selecionada = dgvPesquisa.SelectedRows;


            if (linha_selecionada.Count != 1)
            {
                MessageBox.Show("Selecione pelo menos 1 registro para ser removido.");
            }
            else if (linha_selecionada[0].Cells[81].Value.ToString() != "")
            {
                MessageBox.Show("Cliente não pode ser excluido pois possui um registro na clínica!");
            }
            else if (linha_selecionada[0].Cells[81].Value.ToString() == "")
            {
                ClassCliente apaga_cliente = new ClassCliente();
                apaga_cliente.Apagar(Convert.ToInt32(linha_selecionada[0].Cells[0].Value.ToString()));
                txtNome_TextChanged(sender, e);

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvPesquisa.SelectedRows;

            if (linha.Count != 1)
            {
                MessageBox.Show("Selecione 1 Cliente para editar", "Cliente não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClassCliente cliente = new ClassCliente();
            cliente.ID_Cliente = Convert.ToInt32(linha[0].Cells[0].Value);
            cliente.Nome = linha[0].Cells[1].Value.ToString();
            cliente.Sexo = linha[0].Cells[2].Value.ToString();
            cliente.CEP = linha[0].Cells[3].Value.ToString();
            cliente.Numero = linha[0].Cells[4].Value.ToString();
            cliente.Logradouro = linha[0].Cells[5].Value.ToString();
            cliente.Bairro = linha[0].Cells[6].Value.ToString();
            cliente.Cidade = linha[0].Cells[7].Value.ToString();
            cliente.UF = linha[0].Cells[8].Value.ToString();
            cliente.Celular = linha[0].Cells[9].Value.ToString();
            cliente.Telefone = linha[0].Cells[10].Value.ToString();
            cliente.Nascimento = Convert.ToDateTime(linha[0].Cells[11].Value);
            cliente.Email = linha[0].Cells[12].Value.ToString();
            cliente.Profissao = linha[0].Cells[13].Value.ToString();
            cliente.Etnia = linha[0].Cells[14].Value.ToString();
            cliente.PraticaEsporte = linha[0].Cells[15].Value.ToString();
            cliente.Frequencia = linha[0].Cells[16].Value.ToString();
            cliente.NumeroCalcado = linha[0].Cells[17].Value.ToString();
            cliente.MaterialCalcado = linha[0].Cells[18].Value.ToString();
            cliente.TipoCalcado = linha[0].Cells[19].Value.ToString();
            cliente.DestroCanhoto = linha[0].Cells[20].Value.ToString();
            cliente.FormatoUnha = linha[0].Cells[21].Value.ToString();
            cliente.Onicoatrofia = Convert.ToInt16 (linha[0].Cells[22].Value);
            cliente.Onicocriptose = Convert.ToInt16 (linha[0].Cells[23].Value);
            cliente.Onicorrexe = Convert.ToInt32(linha[0].Cells[24].Value);
            cliente.Granuloma = Convert.ToInt16(linha[0].Cells[25].Value);
            cliente.Onicogrifose = Convert.ToInt16(linha[0].Cells[26].Value);
            cliente.AlteracaoCor = Convert.ToInt32(linha[0].Cells[27].Value);
            cliente.Onicolise = Convert.ToInt16(linha[0].Cells[28].Value);
            cliente.Onicofose = Convert.ToInt16(linha[0].Cells[29].Value);
            cliente.Onicomicose = Convert.ToInt16(linha[0].Cells[30].Value);
            cliente.ExostoseUngueal = Convert.ToInt16(linha[0].Cells[31].Value);
            cliente.PsoriaseUnha = Convert.ToInt32(linha[0].Cells[32].Value);
            cliente.Ungueal = Convert.ToInt16(linha[0].Cells[33].Value);
            cliente.AlteracoesLaminas = linha[0].Cells[34].Value.ToString();
            cliente.HaluxVagusD = Convert.ToInt32(linha[0].Cells[35].Value);
            cliente.HaluxVagusE = Convert.ToInt16(linha[0].Cells[36].Value);
            cliente.HaluxRigidusD = Convert.ToInt16(linha[0].Cells[37].Value);
            cliente.HaluxRigidusE = Convert.ToInt16(linha[0].Cells[38].Value);
            cliente.DedosGarrasMartelo = Convert.ToInt16(linha[0].Cells[39].Value);
            cliente.EsporaoCalcaneo = Convert.ToInt32(linha[0].Cells[40].Value);
            cliente.Perodactilia = Convert.ToInt16(linha[0].Cells[41].Value);
            cliente.PeCavo = Convert.ToInt16(linha[0].Cells[42].Value);
            cliente.PePlano = Convert.ToInt32(linha[0].Cells[43].Value);
            cliente.AlteracaoOrtopedica = linha[0].Cells[44].Value.ToString();
            cliente.CirurgiaMMII = linha[0].Cells[45].Value.ToString();
            cliente.TratamentoMedicamento = linha[0].Cells[46].Value.ToString();
            cliente.Alergico = linha[0].Cells[47].Value.ToString();
            cliente.AlergicoSim = linha[0].Cells[48].Value.ToString();
            cliente.PatologiaAdquirida = linha[0].Cells[49].Value.ToString();
            cliente.Diabete = linha[0].Cells[50].Value.ToString();
            cliente.Etilista = linha[0].Cells[51].Value.ToString();
            cliente.Tabagismo = linha[0].Cells[52].Value.ToString();
            cliente.DST = linha[0].Cells[53].Value.ToString();
            cliente.FamiliaDiabete = linha[0].Cells[54].Value.ToString();
            cliente.AlteracaoPressao = linha[0].Cells[55].Value.ToString();
            cliente.GravidezLactacao = linha[0].Cells[56].Value.ToString();
            cliente.Cardiopatia = linha[0].Cells[57].Value.ToString();
            cliente.OutrasPatologias = linha[0].Cells[58].Value.ToString();
            cliente.Bromidrose = Convert.ToInt32(linha[0].Cells[59].Value);
            cliente.Neuropatica = Convert.ToInt16(linha[0].Cells[60].Value);
            cliente.Anidrose = Convert.ToInt16(linha[0].Cells[61].Value);
            cliente.Hiperhidrose = Convert.ToInt16(linha[0].Cells[62].Value);
            cliente.Disidrose = Convert.ToInt16(linha[0].Cells[63].Value);
            cliente.Isquemica = Convert.ToInt32(linha[0].Cells[64].Value);
            cliente.Frieira = Convert.ToInt16(linha[0].Cells[65].Value);
            cliente.PsoriasePele = Convert.ToInt16(linha[0].Cells[66].Value);
            cliente.TineaPedis = Convert.ToInt32(linha[0].Cells[67].Value);
            cliente.MalPerfurante = Convert.ToInt16(linha[0].Cells[68].Value);
            cliente.Fissuras = Convert.ToInt16(linha[0].Cells[69].Value);
            cliente.AlteracaoPele = linha[0].Cells[70].Value.ToString();
            cliente.Monofilamento = linha[0].Cells[71].Value.ToString();
            cliente.Diapasao = linha[0].Cells[72].Value.ToString();
            cliente.Digitopressao = linha[0].Cells[73].Value.ToString();
            cliente.Pulsos = linha[0].Cells[74].Value.ToString();
            cliente.NormalD = Convert.ToInt32(linha[0].Cells[75].Value);
            cliente.PalidoD = Convert.ToInt16(linha[0].Cells[76].Value);
            cliente.CianotipoD = Convert.ToInt16(linha[0].Cells[77].Value);
            cliente.NormalE = Convert.ToInt16(linha[0].Cells[78].Value);
            cliente.PalidoE = Convert.ToInt16(linha[0].Cells[79].Value);
            cliente.CianotipoE = Convert.ToInt32(linha[0].Cells[80].Value);



            frmClienteCadastro frm = new frmClienteCadastro();
            frm.cliente_carrega = cliente;
            frm.ShowDialog();
            txtNome_TextChanged(sender, e);

            
        }

        private void btnProntuario_Click(object sender, EventArgs e)
        {
            
            DataGridViewSelectedRowCollection linha = dgvPesquisa.SelectedRows;

            if (linha.Count != 1)
            {
                MessageBox.Show("Selecione 1 Cliente", "Cliente não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (linha[0].Cells[81].Value.ToString() != "")
            {
                ClassProntuario prontuario = new ClassProntuario();
                prontuario.ID_Cliente = Convert.ToInt16 (linha[0].Cells[0].Value);
                prontuario.ID_Prontuario = Convert.ToInt16(linha[0].Cells[81].Value);
                prontuario.Prontuario = linha[0].Cells[82].Value.ToString();
                prontuario.NomeCliente = linha[0].Cells[1].Value.ToString();

                frmClienteProntuario frm = new frmClienteProntuario();
                frm.prontuario_cliente_carrega = prontuario;
                frm.ShowDialog();
                txtNome_TextChanged(sender, e);

            }
            else
            {
                MessageBox.Show  ("Cliente não tem um prontuário");
            }
            

            
            
            
        }

       
    }
}
