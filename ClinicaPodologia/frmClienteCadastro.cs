using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Data.SqlClient;

namespace ClinicaPodologia
{
    public partial class frmClienteCadastro : Form
    {
        Bitmap pe_direito;
        Bitmap pe_esquerdo;
        byte[] fotod ;
        byte[] fotoe ;

        const string string_conexao = "DATA SOURCE=.\\sqlexpress; Initial Catalog=ClinicaPodo;Persist Security Info=True;User ID=sa;Password=senac";
        SqlConnection conexao = new SqlConnection(string_conexao);


        public frmClienteCadastro()
        {
            InitializeComponent();
        }

        public int permissao;

        public ClassCliente cliente_carrega;

        private void salvadoispes()
        {
            MemoryStream memoryd = new MemoryStream();
            pe_direito.Save(memoryd, ImageFormat.Bmp);
            byte[] fotod = memoryd.ToArray();


            MemoryStream memorye = new MemoryStream();
            pe_esquerdo.Save(memorye, ImageFormat.Bmp);
            byte[] fotoe = memorye.ToArray();



            SqlCommand comando = new SqlCommand("UPDATE Cliente SET PeDireito = @PeDireito, PeEsquerdo = @PeEsquerdo WHERE ID_Cliente = @ID_Cliente", conexao);

            SqlParameter PeDireito = new SqlParameter("@PeDireito", SqlDbType.Binary);
            SqlParameter PeEsquerdo = new SqlParameter("@PeEsquerdo", SqlDbType.Binary);
            SqlParameter ID_Cliente = new SqlParameter("@ID_Cliente", SqlDbType.Int);




            PeDireito.Value = fotod;
            PeEsquerdo.Value = fotoe;
            ID_Cliente.Value = Convert.ToInt16(txtID.Text);

            comando.Parameters.Add(PeDireito);
            comando.Parameters.Add(PeEsquerdo);
            comando.Parameters.Add(ID_Cliente);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void salvapeesquerdo()
        {
            MemoryStream memorye = new MemoryStream();
            pe_esquerdo.Save(memorye, ImageFormat.Bmp);
            byte[] fotoe = memorye.ToArray();



            SqlCommand comando = new SqlCommand("UPDATE Cliente SET PeEsquerdo = @PeEsquerdo WHERE ID_Cliente = @ID_Cliente", conexao);

            SqlParameter PeEsquerdo = new SqlParameter("@PeEsquerdo", SqlDbType.Binary);
            SqlParameter ID_Cliente = new SqlParameter("@ID_Cliente", SqlDbType.Int);

            PeEsquerdo.Value = fotoe;
            ID_Cliente.Value = Convert.ToInt16(txtID.Text);

            comando.Parameters.Add(PeEsquerdo);
            comando.Parameters.Add(ID_Cliente);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void salvapedireito()
        {
            MemoryStream memoryd = new MemoryStream();
            pe_direito.Save(memoryd, ImageFormat.Bmp);
            byte[] fotod = memoryd.ToArray();

            SqlCommand comando = new SqlCommand("UPDATE Cliente SET PeDireito = @PeDireito  WHERE ID_Cliente = @ID_Cliente", conexao);

            SqlParameter PeDireito = new SqlParameter("@PeDireito", SqlDbType.Binary);
            SqlParameter ID_Cliente = new SqlParameter("@ID_Cliente", SqlDbType.Int);




            PeDireito.Value = fotod;
            ID_Cliente.Value = Convert.ToInt16(txtID.Text);

            comando.Parameters.Add(PeDireito);
            comando.Parameters.Add(ID_Cliente);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void pctDireito_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nome = openFileDialog1.FileName;

                pe_direito = new Bitmap(nome);
                pctDireito.Image = pe_direito;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length < 1 ||
                mskCEP.Text.Length < 1 ||
                txtNumero.Text.Length < 1 ||
                txtEndereco.Text.Length < 1 ||
                txtBairro.Text.Length < 1 ||
                cmbCidade.Text.Length < 1 ||
                cmbUF.Text.Length < 1 ||
                mskCelular.Text.Length < 1 ||
                mskTelefone.Text.Length < 1 ||
                dtpNascimento.Text.Length < 1 ||
                txtEmail.Text.Length < 1 ||
                txtProfissao.Text.Length < 1 ||
                cmbEtinia.Text.Length < 1 )




            {
                MessageBox.Show("Preencha o(s) campo(s) obrigatório(s)", "Campo obrigatório em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClassCliente cliente = new ClassCliente();
            cliente.Nome = txtNome.Text;
            if (rdbMasc.Checked == true)
            {
                cliente.Sexo = "Masculino";
            }
            else
            {
                cliente.Sexo = "Feminino";
            }
            cliente.CEP = mskCEP.Text;
            cliente.Numero = txtNumero.Text;
            cliente.Logradouro = txtEndereco.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = cmbCidade.Text;
            cliente.UF = cmbUF.Text;
            cliente.Celular = mskCelular.Text;
            cliente.Telefone = mskTelefone.Text;
            cliente.Nascimento = Convert.ToDateTime(dtpNascimento.Value);
            cliente.Email = txtEmail.Text;
            cliente.Profissao = txtProfissao.Text;
            cliente.Etnia = cmbEtinia.Text;
            if (rdbSimEsporte.Checked == true)
            {
                cliente.PraticaEsporte = "Sim";
            }
            else
            {
                cliente.PraticaEsporte = "Não";
            }
            cliente.Frequencia = cmbEsporte.Text;
            cliente.NumeroCalcado = txtNumeroCalcado.Text;
            cliente.MaterialCalcado = txtMaterialCalcado.Text;
            cliente.TipoCalcado = txtTipoCalcado.Text;
            if (rdbDestro.Checked)
            {
                cliente.DestroCanhoto = "Destro";
            }
            else
            {
                cliente.DestroCanhoto = "Canhoto";
            }
            cliente.FormatoUnha = cmbFormatoUnha.Text;
            if (ckbOnicoatrofia.Checked)
            {
                cliente.Onicoatrofia = 1;
            }
            if (ckbOnicocriptose.Checked)
            {
                cliente.Onicocriptose = 1;
            }
            if (ckbOnicorrexe.Checked)
            {
                cliente.Onicorrexe = 1;
            }
            if (ckbGranuloma.Checked)
            {
                cliente.Granuloma = 1;
            }
            if (ckbOnicogrifose.Checked)
            {
                cliente.Onicogrifose = 1;
            }
            if (ckbAlteracaoCor.Checked)
            {
                cliente.AlteracaoCor = 1;
            }
            if (ckbOnicolise.Checked)
            {
                cliente.Onicolise = 1;
            }
            if (ckbOnicofose.Checked)
            {
                cliente.Onicofose = 1;
            }
            if (ckbOnicomicose.Checked)
            {
                cliente.Onicomicose = 1;
            }
            if (ckbExostoseUngueal.Checked)
            {
                cliente.ExostoseUngueal = 1;
            }
            if (ckbPsoriaseUnha.Checked)
            {
                cliente.PsoriaseUnha = 1;
            }
            if (ckbUngueal.Checked)
            {
                cliente.Ungueal = 1;
            }
            cliente.AlteracoesLaminas = txtAlteracoesLaminas.Text;

            if (ckbVagusD.Checked)
            {
                cliente.HaluxVagusD = 1;
            }
            if (ckbVagusE.Checked)
            {
                cliente.HaluxVagusE = 1;
            }
            if (ckbRigidusD.Checked)
            {
                cliente.HaluxRigidusD = 1;
            }
            if (ckbRigidusE.Checked)
            {
                cliente.HaluxRigidusE = 1;
            }
            if (ckbGarraMartelo.Checked)
            {
                cliente.DedosGarrasMartelo = 1;
            }
            if (ckbEsporao.Checked)
            {
                cliente.EsporaoCalcaneo = 1;
            }
            if (ckbPerodactilia.Checked)
            {
                cliente.Perodactilia = 1;
            }
            if (ckbCavo.Checked)
            {
                cliente.PeCavo = 1;
            }
            if (ckbPlano.Checked)
            {
                cliente.PePlano = 1;
            }

            cliente.AlteracaoOrtopedica = txtAlteracoesOrtopedicas.Text;
            cliente.CirurgiaMMII = txtMMII.Text;
            cliente.TratamentoMedicamento = txtTratamentoMedicamento.Text;

            if (rdbSimAlergico.Checked)
            {
                cliente.Alergico = "Sim";
            }
            else
            {
                cliente.Alergico = "Não";
            }
            cliente.AlergicoSim = txtAlergico.Text;
            cliente.PatologiaAdquirida = txtPadologiaAdquirida.Text;
            if (rdbSimDiabete.Checked)
            {
                cliente.Diabete = "Sim";
            }
            else
            {
                cliente.Diabete = "Não";
            }
            if (rdbSimEtilista.Checked)
            {
                cliente.Etilista = "Sim";
            }
            else
            {
                cliente.Etilista = "Não";
            }
            if (rdbSimTabagismo.Checked)
            {
                cliente.Tabagismo = "Sim";
            }
            else
            {
                cliente.Tabagismo = "Não";
            }
            if (rdbSimDST.Checked)
            {
                cliente.DST = "Sim";
            }
            else
            {
                cliente.DST = "Não";
            }
            if (rdbSimFamDiabete.Checked)
            {
                cliente.FamiliaDiabete = "Sim";
            }
            else
            {
                cliente.FamiliaDiabete = "Não";
            }
            if (rdbSimPressao.Checked)
            {
                cliente.AlteracaoPressao = "Sim";
            }
            else
            {
                cliente.AlteracaoPressao = "Não";
            }
            if (rdbSimGravidez.Checked)
            {
                cliente.GravidezLactacao = "Sim";
            }
            else
            {
                cliente.GravidezLactacao = "Não";
            }
            if (rdbSimCardiopatia.Checked)
            {
                cliente.Cardiopatia = "Sim";
            }
            else
            {
                cliente.Cardiopatia = "Não";
            }
            cliente.OutrasPatologias = txtOutrasPatologias.Text;

            if (ckbBromidrose.Checked)
            {
                cliente.Bromidrose = 1;
            }
            if (ckbNeuropatica.Checked)
            {
                cliente.Neuropatica = 1;
            }
            if (ckbAnidrose.Checked)
            {
                cliente.Anidrose = 1;
            }
            if (ckbHiperhidrose.Checked)
            {
                cliente.Hiperhidrose = 1;
            }
            if (ckbDisidrose.Checked)
            {
                cliente.Disidrose = 1;
            }

            if (ckbIsquemica.Checked)
            {
                cliente.Isquemica = 1;
            }
            if (ckbFrieira.Checked)
            {
                cliente.Frieira = 1;
            }
            if (ckbPsoriasePele.Checked)
            {
                cliente.PsoriasePele = 1;
            }
            if (ckbTineaPedis.Checked)
            {
                cliente.TineaPedis = 1;
            }
            if (ckbMalPerfurante.Checked)
            {
                cliente.MalPerfurante = 1;
            }
            if (ckbFissuras.Checked)
            {
                cliente.Fissuras = 1;
            }
            cliente.AlteracaoPele = txtAlteracoesPele.Text;
            cliente.Monofilamento = txtMonofilamento.Text;
            cliente.Diapasao = txtDiapasao.Text;
            cliente.Digitopressao = txtDigitopressao.Text;
            cliente.Pulsos = txtPulsos.Text;

            if (ckbNormalDireito.Checked)
            {
                cliente.NormalD = 1;
            }
            if (ckbPalidoDireito.Checked)
            {
                cliente.PalidoD = 1;
            }
            if (ckbCianotipoDireito.Checked)
            {
                cliente.CianotipoD = 1;
            }
            if (ckbNormalEsquerdo.Checked)
            {
                cliente.NormalE = 1;
            }
            if (ckbPalidoEsquerdo.Checked)
            {
                cliente.PalidoE = 1;
            }
            if (ckbCianotipoEsquerdo.Checked)
            {
                cliente.CianotipoE = 1;
            }
            //cliente.PeDireito = pctDireito.Image;
            //cliente.PeEsquerdo = pctEsquerdo.Image;
            

            

            if (txtID.Text == "")
            {
                txtID.Text = Convert.ToString(cliente.Salvar());


                
                if (pe_direito != null && pe_esquerdo != null)
                {
                    salvadoispes();
                }
                else if (pe_direito != null && pe_esquerdo == null)
                {
                    salvapedireito();
                }
                else if(pe_direito == null && pe_esquerdo != null)
                {
                    salvapeesquerdo();
                }

                this.Close();
            }

            else
            {
                cliente.ID_Cliente = Convert.ToInt32(txtID.Text);
                cliente.Atualiza();

                if (pe_direito != null && pe_esquerdo != null)
                {
                    salvadoispes();
                }
                else if (pe_direito != null && pe_esquerdo == null)
                {
                    salvapedireito();
                }
                else if (pe_direito == null && pe_esquerdo != null)
                {
                    salvapeesquerdo();
                }

                this.Close();
            }
        }

        private void pctEsquerdo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nome = openFileDialog1.FileName;

                pe_esquerdo = new Bitmap(nome);
                pctEsquerdo.Image = pe_esquerdo;
            }
        }

        private void frmClienteCadastro_Load(object sender, EventArgs e)
        {
            ClassRegiao uf = new ClassRegiao();
            cmbUF.DataSource = uf.lista_uf();
            cmbUF.DisplayMember = "UF";
            cmbUF.ValueMember = "ID_UF";
            //cmbUF.SelectedValue = 1;

            if (permissao != 5)
            {
                tabControl1.Visible = false;
                this.Size = new Size(917, 255);

            }
            else
            {
                tabControl1.Visible = true;
                this.Size = new Size(917, 683);

            }
        }

        private void cmbUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUF.SelectedIndex >= 0)
            {
                ClassRegiao cidade = new ClassRegiao();
                cmbCidade.DataSource = cidade.lista_cidade(cmbUF.Text);
                cmbCidade.DisplayMember = "Nome_municipio";
                cmbCidade.ValueMember = "UF";
                cmbCidade.SelectedValue = -1;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClienteCadastro_Shown(object sender, EventArgs e)
        {
            if (cliente_carrega != null)
            {
                txtID.Text = cliente_carrega.ID_Cliente.ToString();
                txtNome.Text = cliente_carrega.Nome;
                if (cliente_carrega.Sexo == "Masculino")
                {
                    rdbMasc.Checked = true;
                }
                else
                {
                    rdbFem.Checked = true;
                }
                mskCEP.Text = cliente_carrega.CEP;
                txtNumero.Text = cliente_carrega.Numero;
                txtEndereco.Text = cliente_carrega.Logradouro;
                txtBairro.Text = cliente_carrega.Bairro;
                cmbCidade.Text = cliente_carrega.Cidade;
                cmbUF.Text = cliente_carrega.UF;
                mskCelular.Text = cliente_carrega.Celular ;
                mskTelefone.Text = cliente_carrega.Telefone;
                dtpNascimento.Value = cliente_carrega.Nascimento;
                txtEmail.Text = cliente_carrega.Email;
                txtProfissao.Text = cliente_carrega.Profissao;
                cmbEtinia.Text = cliente_carrega.Etnia;
                if (cliente_carrega.PraticaEsporte == "Sim")
                {
                    rdbSimEsporte.Checked = true;
                }
                else
                {
                    rdbNaoEsporte.Checked = true;
                }
                cmbEsporte.Text = cliente_carrega.Frequencia;
                txtNumeroCalcado.Text = cliente_carrega.NumeroCalcado;
                txtMaterialCalcado.Text = cliente_carrega.MaterialCalcado;
                txtTipoCalcado.Text = cliente_carrega.TipoCalcado;
                if (cliente_carrega.DestroCanhoto == "Destro")
                {
                    rdbDestro.Checked = true;
                }
                else
                {
                    rdbCanhoto.Checked = true;
                }
                cmbFormatoUnha.Text = cliente_carrega.FormatoUnha;
                if (cliente_carrega.Onicoatrofia == 1)
                {
                    ckbOnicoatrofia.Checked = true;
                }
                if (cliente_carrega.Onicocriptose == 1)
                {
                    ckbOnicocriptose.Checked = true;
                }
                if (cliente_carrega.Onicorrexe == 1)
                {
                    ckbOnicorrexe.Checked = true;
                }
                if (cliente_carrega.Granuloma == 1)
                {
                    ckbGranuloma.Checked = true;
                }
                if (cliente_carrega.Onicogrifose == 1)
                {
                    ckbOnicogrifose.Checked = true;
                }
                if (cliente_carrega.AlteracaoCor == 1)
                {
                    ckbAlteracaoCor.Checked = true;
                }
                if (cliente_carrega.Onicolise == 1)
                {
                    ckbOnicolise.Checked = true;
                }
                if (cliente_carrega.Onicofose == 1)
                {
                    ckbOnicofose.Checked = true;
                }
                if (cliente_carrega.Onicomicose == 1)
                {
                    ckbOnicomicose.Checked = true;
                }
                if (cliente_carrega.ExostoseUngueal == 1)
                {
                    ckbExostoseUngueal.Checked = true;
                }
                if (cliente_carrega.PsoriaseUnha == 1)
                {
                    ckbPsoriaseUnha.Checked = true;
                }
                if (cliente_carrega.Ungueal == 1)
                {
                    ckbUngueal.Checked = true;
                }
                txtAlteracoesLaminas.Text = cliente_carrega.AlteracoesLaminas;

                if (cliente_carrega.HaluxVagusD == 1)
                {
                    ckbVagusD.Checked = true;
                }
                if (cliente_carrega.HaluxVagusE == 1)
                {
                    ckbVagusE.Checked = true;
                }
                if (cliente_carrega.HaluxRigidusD == 1)
                {
                    ckbRigidusD.Checked = true;
                }
                if (cliente_carrega.HaluxRigidusE == 1)
                {
                    ckbRigidusE.Checked = true;
                }
                if (cliente_carrega.DedosGarrasMartelo == 1)
                {
                    ckbGarraMartelo.Checked = true;
                }
                if (cliente_carrega.EsporaoCalcaneo == 1)
                {
                    ckbEsporao.Checked = true;
                }
                if (cliente_carrega.Perodactilia == 1)
                {
                    ckbPerodactilia.Checked = true;
                }
                if (cliente_carrega.PeCavo == 1)
                {
                    ckbCavo.Checked = true;
                }
                if (cliente_carrega.PePlano == 1)
                {
                    ckbPlano.Checked = true;
                }

                txtAlteracoesOrtopedicas.Text = cliente_carrega.AlteracaoOrtopedica;
                txtMMII.Text = cliente_carrega.CirurgiaMMII;
                txtTratamentoMedicamento.Text = cliente_carrega.TratamentoMedicamento;

                if (cliente_carrega.Alergico == "Sim")
                {
                    rdbSimAlergico.Checked = true;
                }
                else
                {
                    rdbNaoAlergico.Checked = true;
                }
                txtAlergico.Text = cliente_carrega.AlergicoSim;
                txtPadologiaAdquirida.Text = cliente_carrega.PatologiaAdquirida;
                if (cliente_carrega.Diabete == "Sim")
                {
                    rdbSimDiabete.Checked = true;
                }
                else
                {
                    rdbNaoDiabete.Checked = true;
                }
                if (cliente_carrega.Etilista == "Sim")
                {
                    rdbSimEtilista.Checked = true;
                }
                else
                {
                    rdbNaoEtilista.Checked = true;
                }
                if (cliente_carrega.Tabagismo == "Sim")
                {
                    rdbSimTabagismo.Checked = true;
                }
                else
                {
                    rdbNaoTabagismo.Checked = true;
                }
                if (cliente_carrega.DST == "Sim")
                {
                    rdbSimDST.Checked = true;
                }
                else
                {
                    rdbNaoDST.Checked = true;
                }
                if (cliente_carrega.FamiliaDiabete == "Sim")
                {
                    rdbSimFamDiabete.Checked = true;
                }
                else
                {
                    rdbNaoFamDiabete.Checked = true;
                }
                if (cliente_carrega.AlteracaoPressao =="Sim")
                {
                    rdbSimPressao.Checked = true;
                }
                else
                {
                    rdbNaoPressao.Checked = true;
                }
                if (cliente_carrega.GravidezLactacao == "Sim")
                {
                    rdbSimGravidez.Checked = true;
                }
                else
                {
                    rdbNaoGravidez.Checked = true;
                }
                if (cliente_carrega.Cardiopatia == "sim")
                {
                    rdbSimCardiopatia.Checked = true;
                }
                else
                {
                    rdbNaoCardiopatia.Checked = true;
                }
                txtOutrasPatologias.Text = cliente_carrega.OutrasPatologias;

                if (cliente_carrega.Bromidrose == 1)
                {
                    ckbBromidrose.Checked = true;
                }
                if (cliente_carrega.Neuropatica == 1)
                {
                    ckbNeuropatica.Checked = true;
                }
                if (cliente_carrega.Anidrose == 1)
                {
                    ckbAnidrose.Checked = true;
                }
                if (cliente_carrega.Hiperhidrose == 1)
                {
                    ckbHiperhidrose.Checked = true;
                }
                if (cliente_carrega.Disidrose == 1)
                {
                    ckbDisidrose.Checked = true;
                }

                if (cliente_carrega.Isquemica == 1)
                {
                    ckbIsquemica.Checked = true;
                }
                if (cliente_carrega.Frieira == 1)
                {
                    ckbFrieira.Checked = true;
                }
                if (cliente_carrega.PsoriasePele == 1)
                {
                    ckbPsoriasePele.Checked = true;
                }
                if (cliente_carrega.TineaPedis == 1)
                {
                    ckbTineaPedis.Checked = true;
                }
                if (cliente_carrega.MalPerfurante == 1)
                {
                    ckbMalPerfurante.Checked = true;
                }
                if (cliente_carrega.Fissuras == 1)
                {
                    ckbFissuras.Checked = true;
                }
                txtAlteracoesPele.Text = cliente_carrega.AlteracaoPele;
                txtMonofilamento.Text = cliente_carrega.Monofilamento;
                txtDiapasao.Text = cliente_carrega.Diapasao;
                txtDigitopressao.Text = cliente_carrega.Digitopressao;
                txtPulsos.Text = cliente_carrega.Pulsos;

                if (cliente_carrega.NormalD == 1)
                {
                    ckbNormalDireito.Checked = true;
                }
                if (cliente_carrega.PalidoD == 1)
                {
                    ckbPalidoDireito.Checked = true;
                }
                if (cliente_carrega.CianotipoD == 1)
                {
                    ckbCianotipoDireito.Checked = true;
                }
                if (cliente_carrega.NormalE == 1)
                {
                    ckbNormalEsquerdo.Checked = true;
                }
                if (cliente_carrega.PalidoE == 1)
                {
                    ckbPalidoEsquerdo.Checked = true;
                }
                if (cliente_carrega.CianotipoE == 1)
                {
                    ckbCianotipoEsquerdo.Checked = true;
                }

                SqlCommand comando = new SqlCommand("SELECT ID_Cliente, PeDireito, PeEsquerdo FROM Cliente WHERE ID_Cliente = @ID_Cliente", conexao);

                SqlParameter ID_Cliente = new SqlParameter("@ID_Cliente", SqlDbType.Int);

                ID_Cliente.Value = txtID.Text;

                comando.Parameters.Add(ID_Cliente);

                try
                {
                    conexao.Open();

                    SqlDataReader reader = comando.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        byte[] pedireito = (byte[])(reader[1]);
                        byte[] peesquerdo = (byte[])(reader[2]);
                        if (pedireito == null)
                        {
                            pctDireito.Image = null;
                        }
                        else
                        {
                            MemoryStream memoryd = new MemoryStream(pedireito);
                            pctDireito.Image = Image.FromStream(memoryd);
                        }
                        if (peesquerdo == null)
                        {
                            pctEsquerdo.Image = null;
                        }
                        else
                        {
                            MemoryStream memorye = new MemoryStream(peesquerdo);
                            pctEsquerdo.Image = Image.FromStream(memorye);
                        }
                    }

                }
                catch (Exception E)
                {
                    MessageBox.Show("Cliente não possui imagem!");
                }
                finally
                {
                    conexao.Close();
                }

            }
            if (txtID.Text != "")
            {
                btnSalvar.Text = "Atualizar";
                this.Text = "Atualizar Usuário";
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nome = openFileDialog1.FileName;

                pe_esquerdo = new Bitmap(nome);
                pctEsquerdo.Image = pe_esquerdo;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nome = openFileDialog1.FileName;

                pe_direito = new Bitmap(nome);
                pctDireito.Image = pe_direito;
            }
        }
    }
}

