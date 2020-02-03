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
    public partial class AllPeople : MasterForm
    {
        public AllPeople()
        {
            InitializeComponent();
        }

        private void AllPeople_Load(object sender, EventArgs e)
        {
            AllPeopleModelBindingSource.DataSource = MVVM.AllPeople.Get();
            this.reportViewer1.RefreshReport();
        }
    }
}
