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
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            var server = new Microsoft.SqlServer.Management.Smo.Server(txtServidor.Text);
            var backup = new Microsoft.SqlServer.Management.Smo.Backup();
            backup.Database = txtDatabase.Text;
            backup.Incremental = false;
            string nomeArquivoBackup = string.Format("{0}_{1:yyyy-MM-dd_HH&mm}.bak", txtDatabase.Text, DateTime.Now);
            backup.Devices.AddDevice(nomeArquivoBackup, Microsoft.SqlServer.Management.Smo.DeviceType.File);
            backup.SqlBackup(server);
            MessageBox.Show(string.Format("Backup '{0}' concluído com sucesso.", nomeArquivoBackup), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbBackup_DropDown(object sender, EventArgs e)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection(string.Format("Server={0};Database={1};Trusted_Connection=True;", txtServidor.Text, txtDatabase.Text)))
            {
                connection.Open();

                using (var command = new System.Data.SqlClient.SqlCommand(
                    "SELECT physical_device_name FROM msdb.dbo.backupmediafamily " +
                    "INNER JOIN msdb.dbo.backupset ON msdb.dbo.backupmediafamily.media_set_id = msdb.dbo.backupset.media_set_id " +
                    "WHERE (msdb.dbo.backupset.database_name LIKE @DatabaseName)", connection))
                {
                    command.Parameters.AddWithValue("DatabaseName", txtDatabase.Text);

                    using (var reader = command.ExecuteReader())
                    {
                        var table = new DataTable();
                        table.Load(reader);
                        table.Columns.Add("FriendlyName");
                        foreach (DataRow row in table.Rows)
                        {
                            row["FriendlyName"] = System.IO.Path.GetFileName(row["physical_device_name"].ToString());
                        }
                        if (cmbBackup.DataSource != null && cmbBackup.DataSource is DataTable)
                        {
                            var oldTable = ((DataTable)cmbBackup.DataSource);
                            cmbBackup.DataSource = null;
                            oldTable.Dispose();
                        }
                        cmbBackup.DataSource = table;
                        cmbBackup.DisplayMember = "FriendlyName";
                        cmbBackup.ValueMember = "physical_device_name";
                    }
                }
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            var server = new Microsoft.SqlServer.Management.Smo.Server(txtServidor.Text);
            var restore = new Microsoft.SqlServer.Management.Smo.Restore();
            restore.Database = txtDatabase.Text;
            restore.Devices.AddDevice(cmbBackup.SelectedValue.ToString(), Microsoft.SqlServer.Management.Smo.DeviceType.File);
            server.KillAllProcesses(txtDatabase.Text);
            restore.SqlRestore(server);
            MessageBox.Show(string.Format("Backup '{0}' restaurado com sucesso.", cmbBackup.Text), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    
    }
}
