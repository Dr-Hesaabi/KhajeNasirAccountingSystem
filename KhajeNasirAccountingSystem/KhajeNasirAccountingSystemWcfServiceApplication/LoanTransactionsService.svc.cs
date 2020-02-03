using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KhajeNasirAccountingSystemWcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LoanTransactionsService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LoanTransactionsService.svc or LoanTransactionsService.svc.cs at the Solution Explorer and start debugging.
    public class LoanTransactionsService : ILoanTransactionsService
    {
        DcDataContext dc = new DcDataContext();
        public void SetLoanPermission(Guid LoanId, bool Permission, string AdminNationalCode)
        {
            dc.Update1_SetLoanPermission(LoanId, Permission, AdminNationalCode);
        }

        public void ContributionLoan(string adminNationalCode)
        {
            var People = dc.PeopleSelectCommand().Where(x => x.IsActive == true);
            foreach (var person in People)
            {
                try
                {
                    Guid LoanId = Guid.NewGuid();
                    dc.LoanInsertCommand(LoanId, DateTime.Now, person.Contribution ?? 0, "[NOT DEFIND]", true, adminNationalCode, person.NationalCode, true, true);
                    new InstallementsService().AutomaticInstallement(LoanId, 1);
                }
                catch { }
            }
        }
        public List<LoanSelectCommandResult> UnPermittedLoanTransactions(string NationalCode)
        {
            return dc.LoanSelectCommand().Where(x => x.PersonNationalCode == NationalCode && x.AdminPermission == false).OrderByDescending(x => x.DateTime).ToList();
        }
        public List<LoanSelectCommandResult> PermittedLoanTransactions(string NationalCode)
        {
            return dc.LoanSelectCommand().Where(x => x.PersonNationalCode == NationalCode && x.AdminPermission == true).OrderByDescending(x => x.DateTime).ToList();
        }
        public List<LoanSelectCommandResult> GetLoanTransactions()
        {
            return dc.LoanSelectCommand().OrderByDescending(x => x.DateTime).ToList();
        }
        public List<View_Update1_PeopleLoan> GetPeopleLoanTransactions()
        {
            return dc.View_Update1_PeopleLoans.OrderByDescending(x => x.DateTime).ToList();
        }
        public void InsertLoanTransactions(Guid Id, DateTime DateTime, decimal Amount, string BankFollowUpCode, bool AdminPermission, string AdminNationalCode, string PersonNationalCode, bool Successful, bool ForContribution = false)
        {
            dc.LoanInsertCommand(Id, DateTime, Amount, BankFollowUpCode, AdminPermission, AdminNationalCode, PersonNationalCode, Successful, ForContribution);
        }
        public void UpdateLoanTransactions(Guid Id, DateTime DateTime, decimal Amount, string BankFollowUpCode, bool AdminPermission, string AdminNationalCode, string PersonNationalCode, bool Successful)
        {
            dc.LoanUpdateCommand(Id, DateTime, Amount, BankFollowUpCode, AdminPermission, AdminNationalCode, PersonNationalCode, Successful, Id);
        }
        public void DeleteLoanTransactions(Guid Original_Id)
        {
            dc.LoanDeleteCommand(Original_Id);
        }
    }
}
