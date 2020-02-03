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
    public partial class InsertLoan : DefaultPopUp
    {
        public string NationalCode1 { get; set; }
        public InsertLoan()
        {
            InitializeComponent();
        }

        private void InsertLoan_Load(object sender, EventArgs e)
        {
            PeopleService.PeopleServiceClient a = new PeopleService.PeopleServiceClient();
            var b = a.GetPerson(NationalCode1);
            NationalCode.Text = NationalCode1;
            FirstName.Text = b.FirstName;
            LastName.Text = b.LastName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoanTransactionsService.LoanTransactionsServiceClient a = new LoanTransactionsService.LoanTransactionsServiceClient();
            Guid g = Guid.NewGuid();
            a.InsertLoanTransactions(g, DateTime.Now, Decimal.Parse(Amount.Text), BankFollowUp.Text, true, Data.NationalCode, NationalCode1, true, false);
            MessageBox.Show("وام با موفقیت ایجاد شد");
            InstallementsService.InstallementsServiceClient b = new InstallementsService.InstallementsServiceClient();
            b.AutomaticInstallement(g, int.Parse(countInstallment.Text));
            MessageBox.Show("اقساط با موفقیت ایجاد شد");
            Installments f = new Installments();
            f.Id1 = g;
            f.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
