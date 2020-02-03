using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhajeNasirAccountingSystemReportClient
{
    public class Program
    {
        static public void Create(string[] args)
        {
            switch (args[0])
            {
                // وام ها
                case "AllLoanTransactions":
                    new Forms.AllLoanTransactions().ShowDialog();
                    break;
                case "AllUnPermittedLoans":
                    new Forms.AllUnPermittedLoans().ShowDialog();
                    break;
                case "AllPermittedLoans":
                    new Forms.AllPermittedLoans().ShowDialog();
                    break;

                // سپرده ها
                case "AllDepositTransactions":
                    new Forms.AllDepositTransactions().ShowDialog();
                    break;
                case "AllUnPermittedDeposits":
                    new Forms.AllUnPermittedDeposits().ShowDialog();
                    break;
                case "AllPermittedDeposits":
                    new Forms.AllPermittedDeposits().ShowDialog();
                    break;


                // لاگ ها
                case "DatabaseLogs":
                    new Forms.DatabaseLogs().ShowDialog();
                    break;

                // تمام افراد
                case "AllPeople":
                    new Forms.AllPeople().ShowDialog();
                    break;

                // چک ها
                case "AllCheques":
                    new Forms.AllCheques().ShowDialog();
                    break;

                // برای نفر
                case "AllLoansForPerson":
                    new Forms.AllLoansForPerson(args[1]).ShowDialog();
                    break;
                case "AllDepositsForPerson":
                    new Forms.AllDepositsForPerson(args[1]).ShowDialog();
                    break;
                case "AllInstallementsForPerson":
                    new Forms.AllInstallementsForPerson(args[1]).ShowDialog();
                    break;

                // --------------------------- BASU
                case "CustomReport1":
                    new Forms.CustomReport1().ShowDialog();
                    // Application.Run()
                    break;

                default:
                    Console.WriteLine("Command not found");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // new Form1().ShowDialog();


            if (args == null || args.Length == 0)
                args = new string[1] { string.Empty };
            if (args[0] == String.Empty)
            {
                while (true)
                {
                    Console.WriteLine("Enter report name or \"Close\" to exit");
                    args = Console.ReadLine().Split(' ');
                    if (args[0].ToLower() != "close")
                    {
                        Create(args);
                    }
                }
            }
            else
            {
                Create(args);
            }

        }
    }
}
