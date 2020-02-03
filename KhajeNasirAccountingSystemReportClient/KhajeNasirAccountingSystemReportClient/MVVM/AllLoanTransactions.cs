using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhajeNasirAccountingSystemReportClient.MVVM
{
    class AllLoanTransactionsModel
    {
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }
        public string BankFollowUpCode { get; set; }
        public bool AdminPermission { get; set; }
        public string AdminNationalCode { get; set; }
        public string PersonNationalCode { get; set; }
        public bool Successful { get; set; }
    }
    class AllLoanTransactions
    {
        static public List<AllLoanTransactionsModel> Get()
        {
            return new LoanTransactionsService.LoanTransactionsServiceClient().GetLoanTransactions().Select(x =>
            new AllLoanTransactionsModel
            {
                DateTime = x.DateTime,
                Amount = x.Amount,
                BankFollowUpCode = x.BankFollowUpCode,
                AdminPermission = x.AdminPermission,
                AdminNationalCode = x.AdminNationalCode,
                PersonNationalCode = x.PersonNationalCode,
                Successful = x.Successful
            }
            ).ToList();
        }
    }
}
