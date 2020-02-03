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
    public partial class AllPermittedLoans : MasterForm
    {
        public AllPermittedLoans()
        {
            InitializeComponent();
        }

        private void AllPermittedLoans_Load(object sender, EventArgs e)
        {
            AllPermittedLoansModelBindingSource.DataSource = MVVM.AllLoanTransactions.Get().Where(x => !x.AdminPermission).ToList();
            this.reportViewer1.RefreshReport();
        }
    }
}
