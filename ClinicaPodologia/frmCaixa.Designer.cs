namespace ClinicaPodologia
{
    partial class frmCaixa
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.lblSaida = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.lblTotalEntrada = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.btnContasAReceber = new System.Windows.Forms.Button();
            this.btnContasAPagar = new System.Windows.Forms.Button();
            this.cmbProfissional = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chtCaixa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ck3D = new System.Windows.Forms.CheckBox();
            this.btnRelatorioGeral = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSaldo
            // 
            this.txtSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSaldo.BackColor = System.Drawing.Color.White;
            this.txtSaldo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSaldo.Location = new System.Drawing.Point(697, 549);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(155, 26);
            this.txtSaldo.TabIndex = 31;
            // 
            // lblSaldo
            // 
            this.lblSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(617, 552);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(84, 19);
            this.lblSaldo.TabIndex = 30;
            this.lblSaldo.Text = "Saldo: R$";
            // 
            // txtSaida
            // 
            this.txtSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSaida.BackColor = System.Drawing.Color.White;
            this.txtSaida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaida.ForeColor = System.Drawing.Color.Red;
            this.txtSaida.Location = new System.Drawing.Point(464, 549);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.ReadOnly = true;
            this.txtSaida.Size = new System.Drawing.Size(147, 26);
            this.txtSaida.TabIndex = 29;
            // 
            // lblSaida
            // 
            this.lblSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSaida.AutoSize = true;
            this.lblSaida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaida.Location = new System.Drawing.Point(321, 552);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(145, 19);
            this.lblSaida.TabIndex = 28;
            this.lblSaida.Text = "Total de saída: R$";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEntrada.BackColor = System.Drawing.Color.White;
            this.txtEntrada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.ForeColor = System.Drawing.Color.Lime;
            this.txtEntrada.Location = new System.Drawing.Point(170, 549);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.ReadOnly = true;
            this.txtEntrada.Size = new System.Drawing.Size(145, 26);
            this.txtEntrada.TabIndex = 27;
            // 
            // lblTotalEntrada
            // 
            this.lblTotalEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalEntrada.AutoSize = true;
            this.lblTotalEntrada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEntrada.Location = new System.Drawing.Point(8, 552);
            this.lblTotalEntrada.Name = "lblTotalEntrada";
            this.lblTotalEntrada.Size = new System.Drawing.Size(166, 19);
            this.lblTotalEntrada.TabIndex = 26;
            this.lblTotalEntrada.Text = "Total de entrada:  R$";
            // 
            // dtpFim
            // 
            this.dtpFim.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFim.Location = new System.Drawing.Point(499, 112);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(317, 26);
            this.dtpFim.TabIndex = 25;
            this.dtpFim.ValueChanged += new System.EventHandler(this.dtpFim_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "a ";
            // 
            // dtpIni
            // 
            this.dtpIni.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIni.Location = new System.Drawing.Point(170, 113);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(296, 25);
            this.dtpIni.TabIndex = 23;
            this.dtpIni.Value = new System.DateTime(2019, 2, 23, 0, 0, 0, 0);
            this.dtpIni.ValueChanged += new System.EventHandler(this.dtpIni_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fluxo de Caixa entre:";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(559, 48);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 50);
            this.btnSair.TabIndex = 21;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.Location = new System.Drawing.Point(442, 48);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(100, 50);
            this.btnGerarRelatorio.TabIndex = 20;
            this.btnGerarRelatorio.Text = "Gerar relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // btnContasAReceber
            // 
            this.btnContasAReceber.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContasAReceber.Location = new System.Drawing.Point(325, 48);
            this.btnContasAReceber.Name = "btnContasAReceber";
            this.btnContasAReceber.Size = new System.Drawing.Size(100, 50);
            this.btnContasAReceber.TabIndex = 19;
            this.btnContasAReceber.Text = "Contas a receber";
            this.btnContasAReceber.UseVisualStyleBackColor = true;
            this.btnContasAReceber.Click += new System.EventHandler(this.btnContasAReceber_Click);
            // 
            // btnContasAPagar
            // 
            this.btnContasAPagar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContasAPagar.Location = new System.Drawing.Point(208, 48);
            this.btnContasAPagar.Name = "btnContasAPagar";
            this.btnContasAPagar.Size = new System.Drawing.Size(100, 50);
            this.btnContasAPagar.TabIndex = 18;
            this.btnContasAPagar.Text = "Contas a pagar";
            this.btnContasAPagar.UseVisualStyleBackColor = true;
            this.btnContasAPagar.Click += new System.EventHandler(this.btnContasAPagar_Click);
            // 
            // cmbProfissional
            // 
            this.cmbProfissional.Enabled = false;
            this.cmbProfissional.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfissional.FormattingEnabled = true;
            this.cmbProfissional.Location = new System.Drawing.Point(208, 13);
            this.cmbProfissional.Name = "cmbProfissional";
            this.cmbProfissional.Size = new System.Drawing.Size(451, 26);
            this.cmbProfissional.TabIndex = 32;
            this.cmbProfissional.SelectedIndexChanged += new System.EventHandler(this.cmbProfissional_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chtCaixa
            // 
            this.chtCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Name = "ChartArea1";
            this.chtCaixa.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtCaixa.Legends.Add(legend1);
            this.chtCaixa.Location = new System.Drawing.Point(12, 162);
            this.chtCaixa.Name = "chtCaixa";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.Name = "Crédito";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Débito";
            this.chtCaixa.Series.Add(series1);
            this.chtCaixa.Series.Add(series2);
            this.chtCaixa.Size = new System.Drawing.Size(866, 367);
            this.chtCaixa.TabIndex = 33;
            this.chtCaixa.Text = "chart1";
            // 
            // ck3D
            // 
            this.ck3D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ck3D.AutoSize = true;
            this.ck3D.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck3D.Location = new System.Drawing.Point(775, 507);
            this.ck3D.Name = "ck3D";
            this.ck3D.Size = new System.Drawing.Size(103, 22);
            this.ck3D.TabIndex = 34;
            this.ck3D.Text = "Gráfico 3D";
            this.ck3D.UseVisualStyleBackColor = true;
            this.ck3D.CheckedChanged += new System.EventHandler(this.ck3D_CheckedChanged);
            // 
            // btnRelatorioGeral
            // 
            this.btnRelatorioGeral.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioGeral.Location = new System.Drawing.Point(674, 48);
            this.btnRelatorioGeral.Name = "btnRelatorioGeral";
            this.btnRelatorioGeral.Size = new System.Drawing.Size(100, 50);
            this.btnRelatorioGeral.TabIndex = 35;
            this.btnRelatorioGeral.Text = "Gráfico Comparativo";
            this.btnRelatorioGeral.UseVisualStyleBackColor = true;
            this.btnRelatorioGeral.Click += new System.EventHandler(this.btnRelatorioGeral_Click);
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 596);
            this.Controls.Add(this.btnRelatorioGeral);
            this.Controls.Add(this.ck3D);
            this.Controls.Add(this.chtCaixa);
            this.Controls.Add(this.cmbProfissional);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.lblTotalEntrada);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpIni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.btnContasAReceber);
            this.Controls.Add(this.btnContasAPagar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fluxo de Caixa";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label lblTotalEntrada;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Button btnContasAReceber;
        private System.Windows.Forms.Button btnContasAPagar;
        private System.Windows.Forms.ComboBox cmbProfissional;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCaixa;
        private System.Windows.Forms.CheckBox ck3D;
        private System.Windows.Forms.Button btnRelatorioGeral;
    }
}