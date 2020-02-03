using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhajeNasirAccountingSystemReportClient.Compoents
{
    public partial class RexaGridView : DataGridView
    {
        public RexaGridView()
        {
            InitializeComponent();
        }

        public RexaGridView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void RexaGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {


            for (int i = 0; i < (sender as DataGridView).Rows.Count; i++)
            {
                if (i % 2 == 0)
                    (sender as DataGridView).Rows[i].DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.LightGray };
            }
        }
    }
}