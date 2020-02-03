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
    public partial class CustomReport1 : MasterForm
    {
        public CustomReport1()
        {
            InitializeComponent();
        }

        /*
        *                           لیست کلی 
        *
        *                                 بر اساس گزارش صندوق امین
        *
        *                             دانشگاه بوعلی سینا
        *
        */


        private void CustomReport1_Load(object sender, EventArgs e)
        {
            CustomReport1ModelBindingSource.DataSource = MVVM.CustomReport1.Get();
            this.reportViewer1.RefreshReport();
        }
    }
}
