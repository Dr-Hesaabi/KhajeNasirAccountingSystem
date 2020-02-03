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
    public partial class AllCheques : MasterForm
    {
        public AllCheques()
        {
            InitializeComponent();
        }

        private void AllCheques_Load(object sender, EventArgs e)
        {
            AllChequesModelBindingSource.DataSource = MVVM.AllCheques.Get();
            this.reportViewer1.RefreshReport();
        }
    }
}
