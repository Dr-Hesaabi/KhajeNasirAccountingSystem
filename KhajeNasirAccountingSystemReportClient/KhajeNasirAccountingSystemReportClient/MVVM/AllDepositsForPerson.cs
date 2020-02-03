using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhajeNasirAccountingSystemReportClient.MVVM
{
    class AllDepositsForPersonModel
    {
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }
        public string BankFollowUpCode { get; set; }
        public bool AdminPermission { get; set; }
        public string AdminNationalCode { get; set; }
        public bool Successful { get; set; }
    }
    class AllDepositsForPerson
    {
        static public List<AllDepositsForPersonModel> Get(string NationalCode)
        {
            return new DepositTransactionsService.DepositTransactionsServiceClient().GetDepositTransactions().Where(x=>x.PersonNationalCode == NationalCode).Select(x =>
            new AllDepositsForPersonModel
            {
                DateTime = x.DateTime,
                Amount = x.Amount,
                BankFollowUpCode = x.BankFollowUpCode,
                AdminPermission = x.AdminPermission,
                AdminNationalCode = x.AdminNationalCode,
                Successful = x.Successful
            }
            ).ToList();
        }
    }
}
