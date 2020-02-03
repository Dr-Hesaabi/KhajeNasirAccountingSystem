using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhajeNasirAccountingSystemReportClient.MVVM
{
    class AllPermittedLoansModel
    {
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }
        public string BankFollowUpCode { get; set; }
        public string AdminNationalCode { get; set; }
        public string PersonNationalCode { get; set; }
        public bool Successful { get; set; }
    }
    class AllPermittedLoans
    {
        static public List<AllPermittedLoansModel> Get()
        {
            return new LoanTransactionsService.LoanTransactionsServiceClient().GetPeopleLoanTransactions().Where(x => x.AdminPermission == true).Select(x =>
              new AllPermittedLoansModel
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