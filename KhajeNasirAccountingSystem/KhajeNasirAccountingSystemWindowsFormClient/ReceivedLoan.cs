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
    public partial class ReceivedLoan : Form
    {
        public string NationalCode { get; set; }
        public ReceivedLoan()
        {
            InitializeComponent();
        }

        private void ReceivedLoan_Load(object sender, EventArgs e)
        {
            LoanTransactionsService.LoanTransactionsServiceClient a = new LoanTransactionsService.LoanTransactionsServiceClient();
           dataGridView1.DataSource= a.GetLoanTransactions().Select(x=> new { x.Id,x.AdminNationalCode,x.AdminPermission,x.Amount,x.BankFollowUpCode,x.DateTime,x.PersonNationalCode}).Where(x => x.PersonNationalCode == NationalCode).ToList() ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoanTransactionsService.LoanTransactionsServiceClient a = new LoanTransactionsService.LoanTransactionsServiceClient();
            dataGridView1.DataSource = a.GetLoanTransactions().Where(x => x.PersonNationalCode == NationalCode && x.DateTime.Date>=StartDate.Value.Date && x.DateTime.Date<=EndDate.Value.Date).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoanTransactionsService.LoanTransactionsServiceClient a = new LoanTransactionsService.LoanTransactionsServiceClient();
            dataGridView1.DataSource = a.GetLoanTransactions().Where(x => x.PersonNationalCode == NationalCode).ToList();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Installments f = new Installments();
            f.Id1 = Guid.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());
            f.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            InsertLoan f = new InsertLoan();
            f.NationalCode1 = NationalCode;
            f.ShowDialog();
            LoanTransactionsService.LoanTransactionsServiceClient a = new LoanTransactionsService.LoanTransactionsServiceClient();
            dataGridView1.DataSource = a.GetLoanTransactions().Select(x => new { x.Id, x.AdminNationalCode, x.AdminPermission, x.Amount, x.BankFollowUpCode, x.DateTime, x.PersonNationalCode }).Where(x => x.PersonNationalCode == NationalCode).ToList();


        }
    }
}
