namespace ClinicaPodologia
{
    partial class frmRelatorioTotal
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClinicaPodoDataSet = new ClinicaPodologia.ClinicaPodoDataSet();
            this.VW_DEBITO_CREDITOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VW_DEBITO_CREDITOTableAdapter = new ClinicaPodologia.ClinicaPodoDataSetTableAdapters.VW_DEBITO_CREDITOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaPodoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_DEBITO_CREDITOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VW_DEBITO_CREDITOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ClinicaPodologia.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ClinicaPodoDataSet
            // 
            this.ClinicaPodoDataSet.DataSetName = "ClinicaPodoDataSet";
            this.ClinicaPodoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VW_DEBITO_CREDITOBindingSource
            // 
            this.VW_DEBITO_CREDITOBindingSource.DataMember = "VW_DEBITO_CREDITO";
            this.VW_DEBITO_CREDITOBindingSource.DataSource = this.ClinicaPodoDataSet;
            // 
            // VW_DEBITO_CREDITOTableAdapter
            // 
            this.VW_DEBITO_CREDITOTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioTotal";
            this.Text = "frmRelatorioTotal";
            this.Load += new System.EventHandler(this.frmRelatorioTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaPodoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_DEBITO_CREDITOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VW_DEBITO_CREDITOBindingSource;
        private ClinicaPodoDataSet ClinicaPodoDataSet;
        private ClinicaPodoDataSetTableAdapters.VW_DEBITO_CREDITOTableAdapter VW_DEBITO_CREDITOTableAdapter;
    }
}