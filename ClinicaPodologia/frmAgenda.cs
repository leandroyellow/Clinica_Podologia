using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ClinicaPodologia
{
    public partial class frmAgenda : Form
    {
        CultureInfo culture = new CultureInfo("pt-BR");
        
        public frmAgenda()
        {
            InitializeComponent();

        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

            lblAno.Text = Convert.ToString (DateTime.Now.Year);
            lblDia.Text = Convert.ToString (DateTime.Now.Day);
            lblMes.Text = dtfi.GetMonthName  (DateTime.Now.Month);
            lblSemana.Text = dtfi.GetDayName(DateTime.Now.DayOfWeek);
        }

        private void cldAgenda_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

            lblAno.Text = Convert.ToString(cldAgenda.SelectionStart.Year);
            lblDia.Text = Convert.ToString(cldAgenda.SelectionStart.Day);
            lblMes.Text = dtfi.GetMonthName(Convert.ToInt32(cldAgenda.SelectionStart.Month));
            lblSemana.Text = dtfi.GetDayName(cldAgenda.SelectionStart.DayOfWeek);
        }
    }
}
