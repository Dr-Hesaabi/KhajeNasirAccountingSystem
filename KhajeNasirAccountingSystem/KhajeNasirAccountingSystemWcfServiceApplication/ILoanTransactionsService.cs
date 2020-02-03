using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace KhajeNasirAccountingSystemWcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILoanTransactionsService" in both code and config file together.
    [ServiceContract]
    public interface ILoanTransactionsService
    {
        [OperationContract]
        void SetLoanPermission(Guid LoanId, bool Permission, string AdminNationalCode);
        [OperationContract]
        void ContributionLoan(string adminNationalCode);
        [OperationContract]
        List<LoanSelectCommandResult> UnPermittedLoanTransactions(string NationalCode);
        [OperationContract]
        List<LoanSelectCommandResult> PermittedLoanTransactions(string NationalCode);
        [OperationContract]
        List<LoanSelectCommandResult> GetLoanTransactions();
        [OperationContract]
        List<View_Update1_PeopleLoan> GetPeopleLoanTransactions();
        [OperationContract]
        void InsertLoanTransactions(Guid Id, DateTime DateTime, decimal Amount, string BankFollowUpCode, bool AdminPermission, string AdminNationalCode, string PersonNationalCode, bool Successful, bool ForContribution = false);
        [OperationContract]
        void UpdateLoanTransactions(Guid Id, DateTime DateTime, decimal Amount, string BankFollowUpCode, bool AdminPermission, string AdminNationalCode, string PersonNationalCode, bool Successful);
        [OperationContract]
        void DeleteLoanTransactions(Guid Original_Id);

    }
}
