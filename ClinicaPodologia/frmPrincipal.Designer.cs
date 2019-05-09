namespace ClinicaPodologia
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTrocaUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministracaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastroUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.fluxoDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAssistencia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.AdministracaoToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.serviçosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1148, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTrocaUsuario,
            this.alterarSenhaToolStripMenuItem,
            this.tsmSair});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // tsmTrocaUsuario
            // 
            this.tsmTrocaUsuario.Name = "tsmTrocaUsuario";
            this.tsmTrocaUsuario.Size = new System.Drawing.Size(150, 22);
            this.tsmTrocaUsuario.Text = "Trocar Usuário";
            this.tsmTrocaUsuario.Click += new System.EventHandler(this.tsmTrocaUsuario_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            // 
            // tsmSair
            // 
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.Size = new System.Drawing.Size(150, 22);
            this.tsmSair.Text = "Sair";
            this.tsmSair.Click += new System.EventHandler(this.tsmSair_Click);
            // 
            // AdministracaoToolStripMenuItem
            // 
            this.AdministracaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastroUsuario,
            this.fluxoDeCaixaToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.AdministracaoToolStripMenuItem.Name = "AdministracaoToolStripMenuItem";
            this.AdministracaoToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.AdministracaoToolStripMenuItem.Text = "Administração";
            // 
            // tsmCadastroUsuario
            // 
            this.tsmCadastroUsuario.Name = "tsmCadastroUsuario";
            this.tsmCadastroUsuario.Size = new System.Drawing.Size(189, 22);
            this.tsmCadastroUsuario.Text = "Usuário";
            this.tsmCadastroUsuario.Click += new System.EventHandler(this.tsmCadastroUsuario_Click);
            // 
            // fluxoDeCaixaToolStripMenuItem
            // 
            this.fluxoDeCaixaToolStripMenuItem.Name = "fluxoDeCaixaToolStripMenuItem";
            this.fluxoDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.fluxoDeCaixaToolStripMenuItem.Text = "Fluxo de caixa";
            this.fluxoDeCaixaToolStripMenuItem.Click += new System.EventHandler(this.fluxoDeCaixaToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.backupToolStripMenuItem.Text = "Backup e Restauração";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAssistencia,
            this.tsmSobre});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // tsmAssistencia
            // 
            this.tsmAssistencia.Name = "tsmAssistencia";
            this.tsmAssistencia.Size = new System.Drawing.Size(132, 22);
            this.tsmAssistencia.Text = "Assistência";
            this.tsmAssistencia.Click += new System.EventHandler(this.tsmAssistencia_Click);
            // 
            // tsmSobre
            // 
            this.tsmSobre.Name = "tsmSobre";
            this.tsmSobre.Size = new System.Drawing.Size(132, 22);
            this.tsmSobre.Text = "Sobre";
            this.tsmSobre.Click += new System.EventHandler(this.tsmSobre_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgenda.BackColor = System.Drawing.Color.Transparent;
            this.btnAgenda.BackgroundImage = global::ClinicaPodologia.Properties.Resources.agenda2;
            this.btnAgenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgenda.FlatAppearance.BorderSize = 0;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Location = new System.Drawing.Point(548, 420);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(90, 90);
            this.btnAgenda.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnAgenda, "Agenda");
            this.btnAgenda.UseVisualStyleBackColor = false;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaixa.BackColor = System.Drawing.Color.Transparent;
            this.btnCaixa.BackgroundImage = global::ClinicaPodologia.Properties.Resources.caixa4;
            this.btnCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Location = new System.Drawing.Point(714, 420);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(90, 90);
            this.btnCaixa.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnCaixa, "Caixa");
            this.btnCaixa.UseVisualStyleBackColor = false;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = global::ClinicaPodologia.Properties.Resources.Saida;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(1046, 420);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 90);
            this.btnSair.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCliente.BackgroundImage = global::ClinicaPodologia.Properties.Resources.ab893f9074d536e3e940d61f0fc62b39_usu__rios_assinam_vermelho_by_vexels;
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Location = new System.Drawing.Point(880, 420);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(90, 90);
            this.btnCliente.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnCliente, "Cliente");
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHora,
            this.lblData});
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1148, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(44, 21);
            this.lblHora.Text = "Hora";
            this.lblHora.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // lblData
            // 
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(42, 21);
            this.lblData.Text = "Data";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaPodologia.Properties.Resources.meuSPAco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 560);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmTrocaUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.ToolStripMenuItem AdministracaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroUsuario;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAssistencia;
        private System.Windows.Forms.ToolStripMenuItem tsmSobre;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem fluxoDeCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
    }
}