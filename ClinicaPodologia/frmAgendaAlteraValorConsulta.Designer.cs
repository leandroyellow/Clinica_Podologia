namespace ClinicaPodologia
{
    partial class frmAgendaAlteraValorConsulta
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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtID_Agenda = new System.Windows.Forms.TextBox();
            this.txtDataConsulta = new System.Windows.Forms.TextBox();
            this.txtPagamentoEfetuado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(130, 48);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(99, 32);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Novo Valor: R$";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(130, 6);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 26);
            this.txtValor.TabIndex = 2;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(25, 48);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 32);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtID_Agenda
            // 
            this.txtID_Agenda.Location = new System.Drawing.Point(295, 12);
            this.txtID_Agenda.Name = "txtID_Agenda";
            this.txtID_Agenda.Size = new System.Drawing.Size(100, 20);
            this.txtID_Agenda.TabIndex = 4;
            this.txtID_Agenda.Visible = false;
            // 
            // txtDataConsulta
            // 
            this.txtDataConsulta.Location = new System.Drawing.Point(295, 38);
            this.txtDataConsulta.Name = "txtDataConsulta";
            this.txtDataConsulta.Size = new System.Drawing.Size(100, 20);
            this.txtDataConsulta.TabIndex = 5;
            this.txtDataConsulta.Visible = false;
            // 
            // txtPagamentoEfetuado
            // 
            this.txtPagamentoEfetuado.Location = new System.Drawing.Point(295, 64);
            this.txtPagamentoEfetuado.Name = "txtPagamentoEfetuado";
            this.txtPagamentoEfetuado.Size = new System.Drawing.Size(100, 20);
            this.txtPagamentoEfetuado.TabIndex = 6;
            this.txtPagamentoEfetuado.Visible = false;
            // 
            // frmAgendaAlteraValorConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 98);
            this.Controls.Add(this.txtPagamentoEfetuado);
            this.Controls.Add(this.txtDataConsulta);
            this.Controls.Add(this.txtID_Agenda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgendaAlteraValorConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Valor";
            this.Shown += new System.EventHandler(this.frmAgendaAlteraValorConsulta_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtID_Agenda;
        private System.Windows.Forms.TextBox txtDataConsulta;
        private System.Windows.Forms.TextBox txtPagamentoEfetuado;
    }
}