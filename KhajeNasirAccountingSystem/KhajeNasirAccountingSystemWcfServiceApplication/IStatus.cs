using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KhajeNasirAccountingSystemWcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStatus" in both code and config file together.
    [ServiceContract]
    public interface IStatus
    {
        [OperationContract]
        OurBank GetPersonBank(string NationalCode);
        [OperationContract]
        OurBank GetPeopleBank();
        [OperationContract]
        List<Transaction> GetTransactions(string NationalCode);
        [OperationContract]
        bool IsActive(string NationalCode);
        [OperationContract]
        void SetActive(string NationalCode, bool IsActive);
        [OperationContract]
        DateTime LastLoginDate(string NationalCode);        
    }
}
