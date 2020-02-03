using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhajeNasirAccountingSystemReportClient.MVVM
{
    class AllChequesModel
    {
        public decimal Amount { get; set; }
        public string PayTo { get; set; }
        public string AdminNationalCode { get; set; }
        public DateTime IssuanceDateTime { get; set; }
        public int ConsecutiveNumber { get; set; }
    }
    class AllCheques
    {
        static public List<AllChequesModel> Get()
        {
            List<AllChequesModel> people = new List<AllChequesModel>();
            new ChequeService.ChequeServiceClient().GetCheque().ToList().ForEach(x => people.Add(new AllChequesModel
            {
                Amount = x.Amount,
                PayTo = x.PayTo,
                AdminNationalCode = x.AdminNationalCode,
                IssuanceDateTime = x.IssuanceDateTime,
                ConsecutiveNumber = x.ConsecutiveNumber
            }));
            return people;
        }
    }
}
