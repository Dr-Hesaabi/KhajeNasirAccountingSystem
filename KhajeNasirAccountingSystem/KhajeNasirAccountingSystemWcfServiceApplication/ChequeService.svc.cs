using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KhajeNasirAccountingSystemWcfServiceApplication
{
    public class ChequeService : IChequeService
    {
        DcDataContext dc = new DcDataContext();
        public List<Cheque> GetCheque()
        {
            var myResult = dc.ChequeSelectCommand().ToList();
            return myResult;
        }
        public void InsertCheque(Guid Id, decimal Amount, string PayTo, string AdminNationalCode, DateTime IssuanceDateTime)
        {
          dc.ChequeInsertCommand(Id, Amount, PayTo, AdminNationalCode, IssuanceDateTime);
        }
        public void UpdateCheque(Guid Id, decimal Amount, string PayTo, string AdminNationalCode, DateTime IssuanceDateTime, string Description)
        {
            dc.ChequeUpdateCommand(Id, Amount, PayTo, AdminNationalCode, IssuanceDateTime, Id, Description);
        }
        public void DeleteCheque(Guid Original_Id)
        {
            dc.ChequeDeleteCommand(Original_Id);
        }
    }
}
