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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int cod_prof_frmcontareceber;
        public int permi;
        private void Form2_Load(object sender, EventArgs e)
        {
            ClassUsuario profissional = new ClassUsuario();
            cmbProfissional.DisplayMember = "Nome";
            cmbProfissional.ValueMember = "ID";
            cmbProfissional.DataSource = profissional.Pesquisa_Profissional();

            cmbProfissional.SelectedValue = cod_prof_frmcontareceber;

            ClassCliente cliente = new ClassCliente();
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "Id";
            cmbCliente.DataSource = cliente.Pesquisa_Cliente();

            if (permi == 1)
            {
                cmbProfissional.Enabled = true;
            }
        }
    }
}
