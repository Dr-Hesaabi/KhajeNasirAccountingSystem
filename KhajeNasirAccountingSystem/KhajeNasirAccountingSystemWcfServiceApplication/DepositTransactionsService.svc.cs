using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KhajeNasirAccountingSystemWcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DepositTransactionsService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DepositTransactionsService.svc or DepositTransactionsService.svc.cs at the Solution Explorer and start debugging.
    public class DepositTransactionsService : IDepositTransactionsService
    {
        DcDataContext dc = new DcDataContext();
        public void SetDepositPermission(Guid DepositId, bool Permission, string AdminNationalCode)
        {
            dc.Update1_SetDepositPermission(DepositId, Permission, AdminNationalCode);
        }
        public List<View_Update1_PeopleDeposit> GetPeopleDepositTransactions()
        {
            return dc.View_Update1_PeopleDeposits.OrderByDescending(x => x.DateTime).ToList();
        }
        public List<DepositSelectCommandResult> UnPermittedDepositTransactions(string NationalCode)
        {
            return dc.DepositSelectCommand().Where(x => x.AdminPermission == false && x.PersonNationalCode == NationalCode).ToList();
        }
        public List<DepositSelectCommandResult> GetDepositTransactions()
        {
            return dc.DepositSelectCommand().ToList();
        }
        public void InsertDepositTransactions(Guid Id, DateTime DateTime, decimal Amount, string BankFollowUpCode, bool AdminPermission, string AdminNationalCode, string PersonNationalCode, bool Successful)
        {

            dc.DepositInsertCommand(Id, DateTime, Amount, BankFollowUpCode, AdminPermission, AdminNationalCode, PersonNationalCode, Successful);
        }
        public void UpdateDepositTransactions(Guid Id, DateTime DateTime, decimal Amount, string BankFollowUpCode, bool AdminPermission, string AdminNationalCode, string PersonNationalCode, bool Successful)
        {
            dc.DepositUpdateCommand(Id, DateTime, Amount, BankFollowUpCode, AdminPermission, AdminNationalCode, PersonNationalCode, Successful, Id);
        }
        public void DeleteDepositTransactions(Guid Original_Id)
        {
            dc.DepositDeleteCommand(Original_Id);
        }
        public void IncreaseDepositForAll(decimal Amount, string AdminNationalCode)
        {
            foreach (var item in dc.PeopleSelectCommand().Where(x => x.IsActive))
            {
                try
                {
                    dc.DepositInsertCommand(Guid.NewGuid(), DateTime.Now, Amount, null, true, AdminNationalCode, item.NationalCode, true);
                }
                catch { }
            }
        }
    }
}
