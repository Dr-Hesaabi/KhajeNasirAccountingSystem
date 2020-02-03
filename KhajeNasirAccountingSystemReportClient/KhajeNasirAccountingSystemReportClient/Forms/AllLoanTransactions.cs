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
    public partial class AllLoanTransactions : MasterForm
    {
        public AllLoanTransactions()
        {
            InitializeComponent();
        }

        private void AllLoanTransactions_Load(object sender, EventArgs e)
        {
            AllLoanTransactionsModelBindingSource.DataSource = MVVM.AllLoanTransactions.Get();
            this.reportViewer1.RefreshReport();
        }
    }
}
