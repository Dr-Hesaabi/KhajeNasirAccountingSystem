using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KhajeNasirAccountingSystemWcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDepositTransactionsService" in both code and config file together.
    [ServiceContract]
    public interface IDepositTransactionsService
    {
        [OperationContract]
        void SetDepositPermission(Guid DepositId, bool Permission, string AdminNationalCode);

        [OperationContract]
        List<View_Update1_PeopleDeposit> GetPeopleDepositTransactions();
        [OperationContract]
        List<DepositSelectCommandResult> UnPermittedDepositTransactions(string NationalCode);
        [OperationContract]
        List<DepositSelectCommandResult> GetDepositTransactions();
        [OperationContract]
        void InsertDepositTransactions(Guid Id, DateTime DateTime, decimal Amount, string BankFollowUpCode, bool AdminPermission, string AdminNationalCode, string PersonNationalCode, bool Successful);
        [OperationContract]
        void UpdateDepositTransactions(Guid Id, DateTime DateTime, decimal Amount, string BankFollowUpCode, bool AdminPermission, string AdminNationalCode, string PersonNationalCode, bool Successful);
        [OperationContract]
        void DeleteDepositTransactions(Guid Original_Id);
        [OperationContract]
        void IncreaseDepositForAll(decimal Amount, string AdminNationalCode);
    }
}
