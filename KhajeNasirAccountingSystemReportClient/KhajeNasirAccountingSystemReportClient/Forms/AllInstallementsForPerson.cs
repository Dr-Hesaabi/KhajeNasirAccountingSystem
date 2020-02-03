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
    public partial class AllInstallementsForPerson : MasterForm
    {
        public AllInstallementsForPerson(string PersonNationalCode)
        {
            NationalCode = PersonNationalCode;
            InitializeComponent();
        }
        public string NationalCode { get; set; }
        private void AllInstallementsForPerson_Load(object sender, EventArgs e)
        {
            Text += NationalCode;
            AllInstallementsForPersonModelBindingSource.DataSource = MVVM.AllInstallementsForPerson.Get(NationalCode);
            this.reportViewer1.RefreshReport();
        }
    }
}