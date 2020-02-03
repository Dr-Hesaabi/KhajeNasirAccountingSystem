using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhajeNasirAccountingSystemReportClient.MVVM
{
    class AllPermittedDepositModel
    {
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }
        public string BankFollowUpCode { get; set; }
        public bool AdminPermission { get; set; }
        public string AdminNationalCode { get; set; }
        public string PersonNationalCode { get; set; }
        public bool Successful { get; set; }
    }
    class AllPermittedDeposits
    {
        static public List<AllPermittedDepositModel> Get()
        {
            return new DepositTransactionsService.DepositTransactionsServiceClient().GetDepositTransactions().Where(x => x.AdminPermission).Select(x =>
              new AllPermittedDepositModel
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
