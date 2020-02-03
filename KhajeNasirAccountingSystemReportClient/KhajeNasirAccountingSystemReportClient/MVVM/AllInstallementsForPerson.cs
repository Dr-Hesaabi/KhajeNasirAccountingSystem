using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhajeNasirAccountingSystemReportClient.MVVM
{
    class AllInstallementsForPersonModel
    {
        public DateTime? PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public Guid LoanTransactionId { get; set; }
        public bool IsPayed { get; set; }

    }
    class AllInstallementsForPerson
    {
        static public List<AllInstallementsForPersonModel> Get(string NationalCode)
        {
            List<AllInstallementsForPersonModel> output = new List<AllInstallementsForPersonModel>();
            foreach (var item in new LoanTransactionsService.LoanTransactionsServiceClient().GetLoanTransactions().Where(x => x.PersonNationalCode == NationalCode).Select(x => x.Id))
            {
                foreach (var item2 in new InstallemenetsService.InstallementsServiceClient().GetInstallements())
                {
                    output.Add(new AllInstallementsForPersonModel { Amount = item2.Amount, IsPayed = item2.IsPayed, LoanTransactionId = item2.LoanTransactionId, PaymentDate = item2.PaymentDate });
                }
            }
            return output;
        }
    }
}
