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
    public partial class Payment : Default
    {
        public string NationalCode { get; set; }
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            DepositTransactionsService.DepositTransactionsServiceClient a = new DepositTransactionsService.DepositTransactionsServiceClient();
           dataGridView1.DataSource= a.GetPeopleDepositTransactions().Select(x => new { x.DepositId, x.Amount, x.DateTime, x.BankFollowUpCode, x.AdminNationalCode, x.AdminPermission, x.NationalCode }).Where(x => x.NationalCode == NationalCode).ToList();

        }

        private void label10_Click(object sender, EventArgs e)
        {
            PaymentAndLoan f = new PaymentAndLoan();
            f.NationalCode1 = NationalCode;
            f.ShowDialog();
            DepositTransactionsService.DepositTransactionsServiceClient a = new DepositTransactionsService.DepositTransactionsServiceClient();
            dataGridView1.DataSource = a.GetPeopleDepositTransactions().Select(x => new { x.DepositId, x.Amount, x.DateTime, x.BankFollowUpCode, x.AdminNationalCode, x.AdminPermission, x.NationalCode }).Where(x => x.NationalCode == NationalCode).ToList();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepositTransactionsService.DepositTransactionsServiceClient a = new DepositTransactionsService.DepositTransactionsServiceClient();
            dataGridView1.DataSource = a.GetPeopleDepositTransactions().Select(x => new { x.DepositId, x.Amount, x.DateTime, x.BankFollowUpCode, x.AdminNationalCode, x.AdminPermission, x.NationalCode }).Where(x => x.NationalCode == NationalCode && x.DateTime<= StartDate.Value && x.DateTime<=EndDate.Value).ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DepositTransactionsService.DepositTransactionsServiceClient a = new DepositTransactionsService.DepositTransactionsServiceClient();
            dataGridView1.DataSource = a.GetPeopleDepositTransactions().Select(x => new { x.DepositId, x.Amount, x.DateTime, x.BankFollowUpCode, x.AdminNationalCode, x.AdminPermission, x.NationalCode }).Where(x => x.NationalCode == NationalCode).ToList();

        }
    }
}
