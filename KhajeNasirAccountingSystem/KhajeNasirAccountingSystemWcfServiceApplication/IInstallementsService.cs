using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KhajeNasirAccountingSystemWcfServiceApplication
{
    [ServiceContract]
    public interface IInstallementsService
    {
        [OperationContract]
        List<InstallementsSelectCommandResult> GetNonPayedInstallements(string NationalCode);
        [OperationContract]
        List<InstallementsSelectCommandResult> GetLoanInstallements(Guid LoanTransactionId);
        [OperationContract]
        List<InstallementsSelectCommandResult> GetInstallements();
        [OperationContract]
        void InsertInstallements(Guid Id, DateTime? PaymentDate, decimal Amount, Guid LoanTransactionId);
        [OperationContract]
        void UpdateInstallements(Guid Id, DateTime? PaymentDate, decimal Amount, Guid LoanTransactionId);
        [OperationContract]
        void DeleteInstallements(Guid Original_Id);
        [OperationContract]
        void PayInstallement(Guid Original_Id, bool IsPayed);
        [OperationContract]
        List<View_Update1_PersonInstallement> GetPeopleInstallements();
        [OperationContract]
        void AutomaticInstallement(Guid LoanTransactionId, int Count);
    }
}
