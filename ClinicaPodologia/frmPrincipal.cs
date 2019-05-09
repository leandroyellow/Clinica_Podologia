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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //        public int podo ;
        //      public int bio ;
        //    public int mani ;
        // public int est ;
        public int permi;
        public int cod_profissiona;

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Responda:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            frmAgendaConsulta frm = new frmAgendaConsulta();

            /*   if (bio > 1)
               {
                   frm.Cod_Profissional = bio;
               }
               if (est > 1)
               {
                   frm.Cod_Profissional = est;
               }
               if (mani > 1)
               {
                   frm.Cod_Profissional = mani;
               }
               if (podo > 1)
               {
                   frm.Cod_Profissional = podo;
               }
               if (permi == 1)
               {
                   frm.Cod_Profissional = permi;
               }
               */
            frm.Cod_Profissional = cod_profissiona;
            frm.permi = permi;
            frm.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            frmCaixa frm = new frmCaixa();
            frm.cod_profis = cod_profissiona;
            frm.permi = permi;
            frm.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmClienteConsulta frm = new frmClienteConsulta();
            frm.permissao = permi;
            frm.ShowDialog();
        }

        private void tsmTrocaUsuario_Click(object sender, EventArgs e)
        {
            //frmPrincipal_Load(sender, e);
            this.Close();
        
        }

        private void tsmCadastroUsuario_Click(object sender, EventArgs e)
        {
            frmUsuarioConsulta frm = new frmUsuarioConsulta();
            frm.ShowDialog();
        }

        private void tsmEditarUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmAssistencia_Click(object sender, EventArgs e)
        {
            frmAssistencia frm = new frmAssistencia();
            frm.ShowDialog();
        }

        private void tsmSobre_Click(object sender, EventArgs e)
        {
            frmSobre frm = new frmSobre();
            frm.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //frmLogin login = new frmLogin(this);
            //login.ShowDialog(this);


            
            if (permi == 1)
            {
                this.BackgroundImage = ClinicaPodologia.Properties.Resources.meuSPAco;
                this.tsmCadastroUsuario.Visible = true;
                this.backupToolStripMenuItem.Visible = true;
            }
            if (permi == 2)
            {
                this.BackgroundImage = ClinicaPodologia.Properties.Resources.biomedicina;
                this.tsmCadastroUsuario.Visible = false;
                this.backupToolStripMenuItem.Visible = false;
            }
            if (permi == 3)
            {
                this.BackgroundImage = ClinicaPodologia.Properties.Resources.Estetica;
                this.tsmCadastroUsuario.Visible = false;
                this.backupToolStripMenuItem.Visible = false;
            }
            if (permi == 4)
            {
                this.BackgroundImage = ClinicaPodologia.Properties.Resources.manicure;
                this.tsmCadastroUsuario.Visible = false;
                this.backupToolStripMenuItem.Visible = false;
            }
            if (permi == 5)
            {
                this.BackgroundImage = ClinicaPodologia.Properties.Resources.fundo;
                this.tsmCadastroUsuario.Visible = false;
                this.backupToolStripMenuItem.Visible = false;
            }

            

            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicoConsulta frm = new frmServicoConsulta();
            frm.cod_profis = cod_profissiona;
            frm.permi = permi;
            frm.ShowDialog();
        }

        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaixa frm = new frmCaixa();
            frm.cod_profis = cod_profissiona;
            frm.ShowDialog();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackup frm = new frmBackup();
            frm.ShowDialog();
        }
    }
}
