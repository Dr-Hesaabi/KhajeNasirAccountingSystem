using Microsoft.Reporting.WinForms;
using System;


namespace KhajeNasirAccountingSystemReportClient.Forms
{
    public partial class DatabaseLogs : MasterForm
    {
        public DatabaseLogs()
        {
            InitializeComponent();
        }

        private void DatabaseLogs_Load(object sender, EventArgs e)
        {
           DatabaseLogsModelBindingSource.DataSource = MVVM.DatabaseLogs.Get();
            this.reportViewer1.RefreshReport();
        }
    }
}
