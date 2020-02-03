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
    public partial class PaymentAndLoan : DefaultPopUp
    {
        public string NationalCode1 { get; set; }
        
        public PaymentAndLoan()
        {
            InitializeComponent();
        }

        private void PaymentAndLoan_Load(object sender, EventArgs e)
        {
            NationalCode.Text = NationalCode1;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Amount.Text=="" || BankFollowUpCode.Text=="")
            {
                MessageBox.Show("لطفا همه قلید ها را پر کنید");

            }
            else
            {
                DepositTransactionsService.DepositTransactionsServiceClient a = new DepositTransactionsService.DepositTransactionsServiceClient();
                decimal Amount1 = 0; ;
                try
                {
                     Amount1 = decimal.Parse(Amount.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("مبلغ باید عدد باشد");
                }
                
                if (Data.IsAdmin)
                {               
                    a.InsertDepositTransactions(Guid.NewGuid(),DateTime.Now,Amount1,BankFollowUpCode.Text,true,Data.NationalCode,NationalCode1,true);
                    MessageBox.Show("واریز وجه با موفقیت انجام شد");
                    this.Close();
                }
                else
                {
                   a.InsertDepositTransactions(Guid.NewGuid(), DateTime.Now, Amount1, BankFollowUpCode.Text, false,null, NationalCode1, false);
                    MessageBox.Show("واریز وجه با موفقیت انجام شد");
                    this.Close();
                }
                
                
                



                
               
            }
        }
    }
}
