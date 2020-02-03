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
    public partial class LoanForAll : DefaultPopUp
    {
        public LoanForAll()
        {
            InitializeComponent();
        }

        private void LoanForAll_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Username.Text = Data.NationalCode;
            f.Username.ReadOnly = true;
            if(f.ShowDialog()==DialogResult.OK)
            {
                LoanTransactionsService.LoanTransactionsServiceClient a = new LoanTransactionsService.LoanTransactionsServiceClient();
                a.ContributionLoan(Data.NationalCode);
                MessageBox.Show("حق عضویت دریافت شد");

 this.Close();
            }
            else
            {
                this.Close();
            }
           
           // f.next=new AdminHome()
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
