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
    public partial class AdminHome : Default
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            
            InstallementsService.InstallementsServiceClient a = new InstallementsService.InstallementsServiceClient();
            dataGridView1.DataSource = a.GetPeopleInstallements().Select(x => new { x.InstallementId, x.Fullname, x.NationalCode, x.Amount, x.PaymentDate, x.InstallementIsPayed }).Where(x => x.InstallementIsPayed == false && x.PaymentDate<= System.DateTime.Now).ToList();

            LoanTransactionsService.LoanTransactionsServiceClient b = new LoanTransactionsService.LoanTransactionsServiceClient();
            dataGridView2.DataSource = b.GetPeopleLoanTransactions().Select(x => new { x.LoanId, x.Fullname, x.NationalCode, x.Amount, x.DateTime, x.AdminPermission }).Where(x => x.AdminPermission == false).ToList();

            DepositTransactionsService.DepositTransactionsServiceClient c = new DepositTransactionsService.DepositTransactionsServiceClient();
            dataGridView3.DataSource = c.GetPeopleDepositTransactions().Select(x => new { x.DepositId, x.Fullname, x.NationalCode, x.Amount, x.BankFollowUpCode, x.DateTime, x.AdminPermission }).Where(x => x.AdminPermission == false).ToList();

            Status.StatusClient d = new Status.StatusClient();
            var bank = d.GetPeopleBank();
            label15.Text = bank.Loan.ToString();
            label14.Text = bank.Deposit.ToString();
            label12.Text = bank.NonPayedInstallements.ToString();
            label13.Text = bank.PayedInstallements.ToString();
            label10.Text = bank.Amount.ToString();
            PeopleService.PeopleServiceClient j = new PeopleService.PeopleServiceClient();
            var q = j.GetPerson(Data.NationalCode);
            label4.Text = "نام : " + q.FirstName;
            label1.Text = "نام خانوادگی : " + q.LastName;
            label3.Text = "کد ملی : " + q.NationalCode;
            label5.Text = "تاریخ افتتاح " + q.CreateDateTime;


        }

        private void MenuCoustomer_Click(object sender, EventArgs e)
        {
            AdminCustomer f = new AdminCustomer();
            this.Hide();
            f.ShowDialog();
            this.Close();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 0)
            {
                if(MessageBox.Show("آیا تمایل به انجام این فرآیند دارید ؟", "هشدار", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    Guid id = Guid.Parse(dataGridView2.Rows[e.RowIndex].Cells["LoanId"].Value.ToString());
                    LoanTransactionsService.LoanTransactionsServiceClient a = new LoanTransactionsService.LoanTransactionsServiceClient();
                    a.SetLoanPermission(id,true,Data.NationalCode);
                    MessageBox.Show("درخواست وام تایید شد");
                    LoanTransactionsService.LoanTransactionsServiceClient b = new LoanTransactionsService.LoanTransactionsServiceClient();
                    dataGridView2.DataSource = b.GetPeopleLoanTransactions().Select(x => new { x.LoanId, x.Fullname, x.NationalCode, x.Amount, x.DateTime, x.AdminPermission }).Where(x => x.AdminPermission == false).ToList();

                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // if (e.ColumnIndex == ((sender as DataGridView).Columns.Count) - 1)
            if (e.ColumnIndex == 0)
            {
                Guid id = Guid.Parse(dataGridView1.Rows[e.RowIndex].Cells["InstallementId"].Value.ToString());
                PayedInstallment f = new PayedInstallment();
                f.InsId = id;
                f.ShowDialog();

                
                InstallementsService.InstallementsServiceClient b = new InstallementsService.InstallementsServiceClient();
                dataGridView1.DataSource = b.GetPeopleInstallements().Select(x => new { x.InstallementId, x.Fullname, x.NationalCode, x.Amount, x.PaymentDate, x.InstallementIsPayed }).Where(x => x.InstallementIsPayed == false).ToList();

            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid id = Guid.Parse(dataGridView3.Rows[e.RowIndex].Cells["DepositId"].Value.ToString());
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show( "آیا تمایل به انجام این فرآیند دارید ؟","هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DepositTransactionsService.DepositTransactionsServiceClient a = new DepositTransactionsService.DepositTransactionsServiceClient();
                    a.SetDepositPermission(id, true, Data.NationalCode);
                    MessageBox.Show("درخواست واریز تایید شد");
                    DepositTransactionsService.DepositTransactionsServiceClient c = new DepositTransactionsService.DepositTransactionsServiceClient();
                    dataGridView3.DataSource = c.GetPeopleDepositTransactions().Select(x => new { x.DepositId, x.Fullname, x.NationalCode, x.Amount, x.BankFollowUpCode, x.DateTime, x.AdminPermission }).Where(x => x.AdminPermission == false).ToList();
                }
            }
            
        }
    }
}
