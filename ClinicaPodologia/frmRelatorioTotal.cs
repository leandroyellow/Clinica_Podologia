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
    public partial class frmRelatorioTotal : Form
    {
        public frmRelatorioTotal()
        {
            InitializeComponent();
        }

        private void frmRelatorioTotal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ClinicaPodoDataSet.VW_DEBITO_CREDITO'. Você pode movê-la ou removê-la conforme necessário.
            this.VW_DEBITO_CREDITOTableAdapter.Fill(this.ClinicaPodoDataSet.VW_DEBITO_CREDITO);

            this.reportViewer1.RefreshReport();
        }
    }
}
