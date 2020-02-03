using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhajeNasirAccountingSystemReportClient.MVVM
{
    class AllUnPermittedLoansModel
    {
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }
        public string BankFollowUpCode { get; set; }
        public string AdminNationalCode { get; set; }
        public string PersonNationalCode { get; set; }
        public bool Successful { get; set; }
    }
    class AllUnPermittedLoans
    {
        static public List<AllUnPermittedLoansModel> Get()
        {
            return new LoanTransactionsService.LoanTransactionsServiceClient().GetPeopleLoanTransactions().Where(x=>x.AdminPermission == false).Select(x =>
            new AllUnPermittedLoansModel
            {
                DateTime = x.DateTime,
                Amount = x.Amount,
                BankFollowUpCode = x.BankFollowUpCode,
                AdminNationalCode = x.AdminNationalCode,
                PersonNationalCode = x.NationalCode,
                Successful = x.Successful
            }
            ).ToList();

        }
    }
}
