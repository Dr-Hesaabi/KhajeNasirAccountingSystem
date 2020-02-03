using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhajeNasirAccountingSystemReportClient.Forms
{
    public partial class AllUnPermittedDeposits : MasterForm
    {
        public AllUnPermittedDeposits()
        {
            InitializeComponent();
        }

        private void AllUnPermittedDeposits_Load(object sender, EventArgs e)
        {
            AllDepositTransactionsModelBindingSource.DataSource = MVVM.AllUnPermittedDeposits.Get();
            this.reportViewer1.RefreshReport();
        }
    }
}
