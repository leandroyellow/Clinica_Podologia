namespace ClinicaPodologia
{
    partial class frmContasReceber
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
            this.dgvContaRecebe = new System.Windows.Forms.DataGridView();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.dtpDataPagamento = new System.Windows.Forms.DateTimePicker();
            this.cmbProfissional = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoPagamento = new System.Windows.Forms.ComboBox();
            this.nudParcelamento = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbReceber = new System.Windows.Forms.RadioButton();
            this.rbPagar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContaRecebe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelamento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContaRecebe
            // 
            this.dgvContaRecebe.AllowUserToAddRows = false;
            this.dgvContaRecebe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContaRecebe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContaRecebe.Location = new System.Drawing.Point(12, 163);
            this.dgvContaRecebe.Name = "dgvContaRecebe";
            this.dgvContaRecebe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContaRecebe.Size = new System.Drawing.Size(860, 210);
            this.dgvContaRecebe.TabIndex = 0;
            this.dgvContaRecebe.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContaRecebe_CellMouseUp);
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(121, 44);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(410, 26);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // dtpDataPagamento
            // 
            this.dtpDataPagamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPagamento.Location = new System.Drawing.Point(171, 86);
            this.dtpDataPagamento.Name = "dtpDataPagamento";
            this.dtpDataPagamento.Size = new System.Drawing.Size(122, 26);
            this.dtpDataPagamento.TabIndex = 2;
            // 
            // cmbProfissional
            // 
            this.cmbProfissional.Enabled = false;
            this.cmbProfissional.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfissional.FormattingEnabled = true;
            this.cmbProfissional.Location = new System.Drawing.Point(121, 12);
            this.cmbProfissional.Name = "cmbProfissional";
            this.cmbProfissional.Size = new System.Drawing.Size(410, 26);
            this.cmbProfissional.TabIndex = 3;
            this.cmbProfissional.SelectedIndexChanged += new System.EventHandler(this.cmbProfissional_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Profissional:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cliente:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(47, 122);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 7;
            this.txtID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data de Pagamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(540, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de Pagamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(580, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Parcelamento:";
            // 
            // cmbTipoPagamento
            // 
            this.cmbTipoPagamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPagamento.FormattingEnabled = true;
            this.cmbTipoPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Débito",
            "Crédito",
            "Cheque"});
            this.cmbTipoPagamento.Location = new System.Drawing.Point(695, 28);
            this.cmbTipoPagamento.Name = "cmbTipoPagamento";
            this.cmbTipoPagamento.Size = new System.Drawing.Size(177, 26);
            this.cmbTipoPagamento.TabIndex = 11;
            // 
            // nudParcelamento
            // 
            this.nudParcelamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudParcelamento.Location = new System.Drawing.Point(695, 61);
            this.nudParcelamento.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudParcelamento.Name = "nudParcelamento";
            this.nudParcelamento.Size = new System.Drawing.Size(66, 26);
            this.nudParcelamento.TabIndex = 12;
            this.nudParcelamento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(768, 379);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 33);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(581, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Valor Total: R$";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(695, 93);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(86, 26);
            this.txtValorTotal.TabIndex = 15;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(658, 379);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(104, 33);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rbReceber);
            this.groupBox1.Controls.Add(this.rbPagar);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(299, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 80);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação do cliente";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(176, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 20);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Ambas";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbReceber
            // 
            this.rbReceber.AutoSize = true;
            this.rbReceber.Location = new System.Drawing.Point(19, 48);
            this.rbReceber.Name = "rbReceber";
            this.rbReceber.Size = new System.Drawing.Size(135, 20);
            this.rbReceber.TabIndex = 1;
            this.rbReceber.Text = "Contas recebidas";
            this.rbReceber.UseVisualStyleBackColor = true;
            this.rbReceber.CheckedChanged += new System.EventHandler(this.rbReceber_CheckedChanged);
            // 
            // rbPagar
            // 
            this.rbPagar.AutoSize = true;
            this.rbPagar.Checked = true;
            this.rbPagar.Location = new System.Drawing.Point(19, 25);
            this.rbPagar.Name = "rbPagar";
            this.rbPagar.Size = new System.Drawing.Size(122, 20);
            this.rbPagar.TabIndex = 0;
            this.rbPagar.TabStop = true;
            this.rbPagar.Text = "Contas a pagar";
            this.rbPagar.UseVisualStyleBackColor = true;
            this.rbPagar.CheckedChanged += new System.EventHandler(this.rbPagar_CheckedChanged);
            // 
            // frmContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.nudParcelamento);
            this.Controls.Add(this.cmbTipoPagamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProfissional);
            this.Controls.Add(this.dtpDataPagamento);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.dgvContaRecebe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmContasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contas a Receber";
            this.Load += new System.EventHandler(this.frmContasReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContaRecebe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelamento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContaRecebe;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.DateTimePicker dtpDataPagamento;
        private System.Windows.Forms.ComboBox cmbProfissional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoPagamento;
        private System.Windows.Forms.NumericUpDown nudParcelamento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbReceber;
        private System.Windows.Forms.RadioButton rbPagar;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}