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
    public partial class AllPermittedDeposits : MasterForm
    {
        public AllPermittedDeposits()
        {
            InitializeComponent();
        }

        private void AllPermittedDeposits_Load(object sender, EventArgs e)
        {
            AllDepositTransactionsModelBindingSource.DataSource = MVVM.AllPermittedDeposits.Get();
            this.reportViewer1.RefreshReport();
        }
    }
}
