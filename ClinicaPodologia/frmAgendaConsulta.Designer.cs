namespace ClinicaPodologia
{
    partial class frmAgendaConsulta
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
            this.cldAgenda = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSemana = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alterarOValorDaConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProfissional = new System.Windows.Forms.ComboBox();
            this.btnAtendimento = new System.Windows.Forms.Button();
            this.btnProntuario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cldAgenda
            // 
            this.cldAgenda.Cursor = System.Windows.Forms.Cursors.Default;
            this.cldAgenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cldAgenda.Location = new System.Drawing.Point(12, 318);
            this.cldAgenda.Name = "cldAgenda";
            this.cldAgenda.TabIndex = 0;
            this.cldAgenda.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cldAgenda_DateChanged);
            this.cldAgenda.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cldAgenda_DateSelected);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblMes);
            this.panel1.Controls.Add(this.lblDia);
            this.panel1.Controls.Add(this.lblAno);
            this.panel1.Location = new System.Drawing.Point(12, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 160);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.lblSemana);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 46);
            this.panel2.TabIndex = 2;
            // 
            // lblSemana
            // 
            this.lblSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemana.ForeColor = System.Drawing.Color.White;
            this.lblSemana.Location = new System.Drawing.Point(3, 0);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(231, 46);
            this.lblSemana.TabIndex = 0;
            this.lblSemana.Text = "segunda feira";
            this.lblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMes
            // 
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(-2, 132);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(239, 23);
            this.lblMes.TabIndex = 3;
            this.lblMes.Text = "mes";
            this.lblMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDia
            // 
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(-2, 59);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(239, 73);
            this.lblDia.TabIndex = 2;
            this.lblDia.Text = "33";
            this.lblDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(3, 47);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(35, 13);
            this.lblAno.TabIndex = 1;
            this.lblAno.Text = "label2";
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.AllowUserToAddRows = false;
            this.dgvAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAgenda.Location = new System.Drawing.Point(257, 116);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgenda.Size = new System.Drawing.Size(541, 568);
            this.dgvAgenda.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarOValorDaConsultaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 26);
            // 
            // alterarOValorDaConsultaToolStripMenuItem
            // 
            this.alterarOValorDaConsultaToolStripMenuItem.Name = "alterarOValorDaConsultaToolStripMenuItem";
            this.alterarOValorDaConsultaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.alterarOValorDaConsultaToolStripMenuItem.Text = "Alterar o valor da consulta";
            this.alterarOValorDaConsultaToolStripMenuItem.Click += new System.EventHandler(this.alterarOValorDaConsultaToolStripMenuItem_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(12, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(147, 31);
            this.btnIncluir.TabIndex = 5;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(12, 49);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(147, 31);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(165, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 98);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente Atendido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horário Ocupado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horário Livre";
            // 
            // cmbProfissional
            // 
            this.cmbProfissional.Enabled = false;
            this.cmbProfissional.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfissional.FormattingEnabled = true;
            this.cmbProfissional.Location = new System.Drawing.Point(313, 19);
            this.cmbProfissional.Name = "cmbProfissional";
            this.cmbProfissional.Size = new System.Drawing.Size(483, 30);
            this.cmbProfissional.TabIndex = 9;
            this.cmbProfissional.SelectedIndexChanged += new System.EventHandler(this.cmbProfissional_SelectedIndexChanged);
            // 
            // btnAtendimento
            // 
            this.btnAtendimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtendimento.Location = new System.Drawing.Point(649, 55);
            this.btnAtendimento.Name = "btnAtendimento";
            this.btnAtendimento.Size = new System.Drawing.Size(147, 31);
            this.btnAtendimento.TabIndex = 10;
            this.btnAtendimento.Text = "Atendimento";
            this.btnAtendimento.UseVisualStyleBackColor = true;
            this.btnAtendimento.Click += new System.EventHandler(this.btnAtendimento_Click);
            // 
            // btnProntuario
            // 
            this.btnProntuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProntuario.Location = new System.Drawing.Point(496, 55);
            this.btnProntuario.Name = "btnProntuario";
            this.btnProntuario.Size = new System.Drawing.Size(147, 31);
            this.btnProntuario.TabIndex = 11;
            this.btnProntuario.Text = "Prontuário";
            this.btnProntuario.UseVisualStyleBackColor = true;
            this.btnProntuario.Click += new System.EventHandler(this.btnProntuario_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAgendaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 696);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProntuario);
            this.Controls.Add(this.btnAtendimento);
            this.Controls.Add(this.cmbProfissional);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cldAgenda);
            this.Name = "frmAgendaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar cldAgenda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProfissional;
        private System.Windows.Forms.Button btnAtendimento;
        private System.Windows.Forms.Button btnProntuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alterarOValorDaConsultaToolStripMenuItem;
    }
}