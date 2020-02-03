using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KhajeNasirAccountingSystemWcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "InstallementsService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select InstallementsService.svc or InstallementsService.svc.cs at the Solution Explorer and start debugging.
    public class InstallementsService : IInstallementsService
    {
        DcDataContext dc = new DcDataContext();
        public List<InstallementsSelectCommandResult> GetNonPayedInstallements(string NationalCode)
        {
            return dc.InstallementsSelectCommand().Where(x => x.IsPayed == false).ToList();
        }

        public List<InstallementsSelectCommandResult> GetLoanInstallements(Guid LoanTransactionId)
        {
            return dc.InstallementsSelectCommand().Where(x => x.LoanTransactionId == LoanTransactionId).ToList();
        }

        public List<InstallementsSelectCommandResult> GetInstallements()
        {
            return dc.InstallementsSelectCommand().ToList();
        }
        public void InsertInstallements(Guid Id, DateTime? PaymentDate, decimal Amount, Guid LoanTransactionId)
        {
            dc.InstallementsInsertCommand(Id, PaymentDate, Amount, LoanTransactionId);
        }
        public void UpdateInstallements(Guid Id, DateTime? PaymentDate, decimal Amount, Guid LoanTransactionId)
        {
            dc.InstallementsUpdateCommand(Id, PaymentDate, Amount, LoanTransactionId, Id);
        }
        public void DeleteInstallements(Guid Original_Id)
        {
            dc.InstallementsDeleteCommand(Original_Id);
        }
        public void PayInstallement(Guid Original_Id, bool IsPayed)
        {
            dc.Update1_PayInstallement(Original_Id, IsPayed);
        }
        public List<View_Update1_PersonInstallement> GetPeopleInstallements()
        {
            return dc.View_Update1_PersonInstallements.ToList();
        }
        public void AutomaticInstallement(Guid LoanTransactionId, int Count)
        {
            var Loan = dc.LoanSelectCommand().Where(x => x.Id == LoanTransactionId).FirstOrDefault();
            decimal eachOneAmount = (int)(Loan.Amount / Count);
            DateTime dt = DateTime.Now;
            for (int i = 0; i < Count; i++)
            {
                if (i + 1 == Count)
                    eachOneAmount = (Loan.Amount - (eachOneAmount * Count)) + eachOneAmount;
                if (Count > 1)
                    dt = dt.AddMonths(1);
                dc.InstallementsInsertCommand(Guid.NewGuid(), dt, eachOneAmount, LoanTransactionId);
            }
        }
    }
}
