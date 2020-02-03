using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhajeNasirAccountingSystemReportClient
{
    public partial class ReportGUI : UserControl
    {
        public ReportGUI()
        {
            InitializeComponent();
        }
        public string ExePath { get; set; }
        public void LaunchApp(string cmnd)
        {
            Program.Create(new string[] { cmnd });
        }
        private void button12_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Text)
            {
                case "تمام وام ها":
                    LaunchApp("AllLoanTransactions");
                    break;
                case "تمام وام های تائید شده":
                    LaunchApp("AllPermittedLoans");
                    break;
                case "تمام وام های تائید نشده":
                    LaunchApp("AllUnPermittedLoans");
                    break;


                case "تمام پرداخت ها":
                    LaunchApp("AllDepositTransactions");
                    break;
                case "تمام پرداخت های تائید نشده":
                    LaunchApp("AllUnPermittedDeposits");
                    break;
                case "تمام پرداخت های تائید شده":
                    LaunchApp("AllPermittedDeposits");
                    break;

                case "لاگ های سیستم":
                    LaunchApp("DatabaseLogs");
                    break;

                case "تمام کاربر":
                    LaunchApp("AllPeople");
                    break;


                case "تمام چک ها":
                    LaunchApp("AllCheques");
                    break;

                case "لیست کلی":
                    LaunchApp("CustomReport1");
                    break;

            }
        }
    }
}
