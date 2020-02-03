using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KhajeNasirAccountingSystemWcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IChequeService" in both code and config file together.
    [ServiceContract]
    public interface IChequeService
    {
        [OperationContract]
        List<Cheque> GetCheque();

        [OperationContract]
        void InsertCheque(Guid Id, decimal Amount, string PayTo, string AdminNationalCode, DateTime IssuanceDateTime);

        [OperationContract]
        void UpdateCheque(Guid Id, decimal Amount, string PayTo, string AdminNationalCode, DateTime IssuanceDateTime, string Description);

        [OperationContract]
        void DeleteCheque(Guid Original_Id);

    }
}
