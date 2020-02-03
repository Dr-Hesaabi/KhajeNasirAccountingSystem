using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhajeNasirAccountingSystemWindowsFormClient
{
    public partial class InsertCheque : DefaultPopUp
    {
        public InsertCheque()
        {
            InitializeComponent();
        }
        public string MyMode { get; set; }
        public Guid? MyId { get; set; }

        private void InsertCheque_Load(object sender, EventArgs e)
        {
            if (MyMode == "Edit" && MyId != null)
            {
                textBox1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Amount.Text == "" || PayTo.Text == "")
            {
                MessageBox.Show("همه فیلد ها باید پر شود");
            }
            else
            {
                ChequeService.ChequeServiceClient a = new ChequeService.ChequeServiceClient();
                if (MyMode == "Edit" && MyId != null)
                {
                    Guid idd = Guid.NewGuid();
                    a.UpdateCheque(idd, decimal.Parse(Amount.Text), PayTo.Text, Data.NationalCode, dateTimePicker1.Value.Date, textBox1.Text);
                    MessageBox.Show("تغییرات چک با موفقیت ثبت شد");
                }
                else
                {
                    Guid idd = Guid.NewGuid();
                    a.InsertCheque(idd, decimal.Parse(Amount.Text), PayTo.Text, Data.NationalCode, dateTimePicker1.Value.Date);
                    MessageBox.Show("چک با موفقیت ثبت شد");
                    ChequeReportForm f = new ChequeReportForm();
                    f.Id = idd;
                    f.ShowDialog();
                }
                this.Close();
            }
        }
    }
}
