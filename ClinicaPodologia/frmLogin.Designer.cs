namespace ClinicaPodologia
{
    partial class frmLogin
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
            this.GroupBoxMain = new System.Windows.Forms.GroupBox();
            this.cmbLogin = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.PictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.GroupBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxMain
            // 
            this.GroupBoxMain.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxMain.Controls.Add(this.cmbLogin);
            this.GroupBoxMain.Controls.Add(this.btnSair);
            this.GroupBoxMain.Controls.Add(this.btnEntrar);
            this.GroupBoxMain.Controls.Add(this.txtSenha);
            this.GroupBoxMain.Controls.Add(this.LabelPassword);
            this.GroupBoxMain.Controls.Add(this.LabelUserName);
            this.GroupBoxMain.Controls.Add(this.PictureBoxLogin);
            this.GroupBoxMain.Location = new System.Drawing.Point(2, 76);
            this.GroupBoxMain.Name = "GroupBoxMain";
            this.GroupBoxMain.Size = new System.Drawing.Size(368, 177);
            this.GroupBoxMain.TabIndex = 17;
            this.GroupBoxMain.TabStop = false;
            // 
            // cmbLogin
            // 
            this.cmbLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLogin.FormattingEnabled = true;
            this.cmbLogin.Location = new System.Drawing.Point(128, 39);
            this.cmbLogin.Name = "cmbLogin";
            this.cmbLogin.Size = new System.Drawing.Size(230, 26);
            this.cmbLogin.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSair.Location = new System.Drawing.Point(246, 114);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 48);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEntrar.Location = new System.Drawing.Point(128, 114);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(112, 48);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "&Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Red;
            this.txtSenha.Location = new System.Drawing.Point(128, 85);
            this.txtSenha.MaxLength = 30;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(232, 26);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.TextChanged += new System.EventHandler(this.clSenha_TextChanged);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Calibri", 12F);
            this.LabelPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelPassword.Location = new System.Drawing.Point(60, 88);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(52, 19);
            this.LabelPassword.TabIndex = 2;
            this.LabelPassword.Text = "Senha:";
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Font = new System.Drawing.Font("Calibri", 12F);
            this.LabelUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelUserName.Location = new System.Drawing.Point(64, 42);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(48, 19);
            this.LabelUserName.TabIndex = 0;
            this.LabelUserName.Text = "Login:";
            // 
            // PictureBoxLogin
            // 
            this.PictureBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxLogin.ErrorImage = null;
            this.PictureBoxLogin.Image = global::ClinicaPodologia.Properties.Resources.login_users;
            this.PictureBoxLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PictureBoxLogin.InitialImage = null;
            this.PictureBoxLogin.Location = new System.Drawing.Point(8, 16);
            this.PictureBoxLogin.Name = "PictureBoxLogin";
            this.PictureBoxLogin.Size = new System.Drawing.Size(48, 56);
            this.PictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogin.TabIndex = 0;
            this.PictureBoxLogin.TabStop = false;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoEllipsis = true;
            this.LabelHeader.BackColor = System.Drawing.Color.Transparent;
            this.LabelHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelHeader.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LabelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LabelHeader.Image = global::ClinicaPodologia.Properties.Resources.fundo_azul_degrade;
            this.LabelHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeader.Location = new System.Drawing.Point(0, 0);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(374, 73);
            this.LabelHeader.TabIndex = 16;
            this.LabelHeader.Text = "Faça seu Login";
            this.LabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelHeader.UseMnemonic = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 261);
            this.Controls.Add(this.GroupBoxMain);
            this.Controls.Add(this.LabelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.GroupBoxMain.ResumeLayout(false);
            this.GroupBoxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label LabelHeader;
        public System.Windows.Forms.GroupBox GroupBoxMain;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnEntrar;
        public System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.Label LabelPassword;
        internal System.Windows.Forms.Label LabelUserName;
        public System.Windows.Forms.PictureBox PictureBoxLogin;
        private System.Windows.Forms.ComboBox cmbLogin;
    }
}