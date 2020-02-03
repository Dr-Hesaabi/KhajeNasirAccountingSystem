using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhajeNasirAccountingSystemReportClient.Compoents
{
    public partial class RexaDatePicker : DateTimePicker
    {
        public RexaDatePicker()
        {
            InitializeComponent();
        }

        public RexaDatePicker(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            Format = DateTimePickerFormat.Custom;
            CustomFormat = "yyyy - MMMM - dd";
           
        }
    }
}
