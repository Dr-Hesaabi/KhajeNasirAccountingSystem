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
    public partial class Installments : DefaultPopUp
    {
        public Guid Id1 { get; set; }
        public Installments()
        {
            InitializeComponent();
        }

        private void Installments_Load(object sender, EventArgs e)
        {
            MyFormLoad();

        }

        private void MyFormLoad()
        {
            InstallementsService.InstallementsServiceClient a = new InstallementsService.InstallementsServiceClient();
            dataGridView1.DataSource = a.GetLoanInstallements(Id1).Select(x => new { x.Id, x.Amount, x.PaymentDate, x.IsPayed }).ToList();
            decimal sum = 0;
            for(int i=0;i<dataGridView1.RowCount;i++)
            {
                sum += decimal.Parse(dataGridView1.Rows[i].Cells["Amount"].Value.ToString());
            }
            LoanTransactionsService.LoanTransactionsServiceClient b = new LoanTransactionsService.LoanTransactionsServiceClient();
            var l = b.GetLoanTransactions().Where(x => x.Id == Id1).ToList();
            label1.Text = string.Empty;
            if(l[0].Amount-sum!=0)
            {
                label1.Text = " •جمع اقساط با مبلغ وام همخوانی ندارد";
                if ((l[0].Amount - sum) < 0)
                {
                    label1.Text += "جمع اقساط بیشتر از مبلغ وام است" + "\r\n";
                }
                else
                {
                    label1.Text += "جمع اقساط کمتر از مبلغ وام است" + "\r\n";
                }
                label1.Text += "\r\n" + "اختلاف مبلغ دریافتی با اقساط مقدار : " + ((l[0].Amount - sum)<0? (l[0].Amount - sum) *(-1): (l[0].Amount - sum)).ToString() + " است .";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid id =Guid.Parse( dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            InstallementsService.InstallementsServiceClient a = new InstallementsService.InstallementsServiceClient();
            if (e.ColumnIndex == 0) // Edit mode
            {

                InstallmentsAE f = new InstallmentsAE();
                f.id = Id1;
                f.idIns = id;
                f.rol = 1;
                f.ShowDialog();
                a = new InstallementsService.InstallementsServiceClient();
                dataGridView1.DataSource = a.GetLoanInstallements(Id1).Select(x => new { x.Id, x.Amount, x.PaymentDate, x.IsPayed }).ToList();
                MyFormLoad();
                //InstallmentsAddOrEdit f = new InstallmentsAddOrEdit();
                //f.IdInstalment = id;
                //f.Type = 0;
                //f.ShowDialog();
            }
            else if (e.ColumnIndex == 1) // Delete mode
            {
                if (MessageBox.Show("آیا از حذف این قسط اطمینان دارید؟", "خطا", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                        InstallementsService.InstallementsServiceClient b = new InstallementsService.InstallementsServiceClient();
                        b.DeleteInstallements(id);
                        MessageBox.Show("با موفقیت حذف شد");
                        a = new InstallementsService.InstallementsServiceClient();
                        dataGridView1.DataSource = a.GetLoanInstallements(Id1).Select(x => new { x.Id, x.Amount, x.PaymentDate, x.IsPayed }).ToList();
                        MyFormLoad();

                   
                }
                

            }
            else if (e.ColumnIndex == 2) // Done mode
            {

                PayedInstallment f = new PayedInstallment();
                f.InsId = id;
                f.ShowDialog();
                       
                        MyFormLoad();

                    

                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InstallmentsAE f = new InstallmentsAE();
            f.rol = 0;
            f.id = Id1;
            f.ShowDialog();
            MyFormLoad();
        }
    }
}
