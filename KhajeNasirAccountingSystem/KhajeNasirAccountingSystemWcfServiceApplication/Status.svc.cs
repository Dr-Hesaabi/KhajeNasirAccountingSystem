using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KhajeNasirAccountingSystemWcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Status" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Status.svc or Status.svc.cs at the Solution Explorer and start debugging.
    public class Status : IStatus
    {
        DcDataContext dc = new DcDataContext();

        public OurBank GetPersonBank(string NationalCode)
        {

            decimal Loan = dc.LoanSelectCommand().Where(x => x.PersonNationalCode == NationalCode).Sum(x => x.Amount);
            decimal Deposit = dc.DepositSelectCommand().Where(x => x.PersonNationalCode == NationalCode).Sum(x => x.Amount);

            // TODO better code here
            decimal PayedInstallements = 0, NonPayedInstallements = 0;

            foreach (var item in dc.LoanTransactions.Where(x => x.PersonNationalCode == NationalCode))
            {
                PayedInstallements += item.Installements.Where(x => x.IsPayed == true).Sum(x => x.Amount);
                NonPayedInstallements += item.Installements.Where(x => x.IsPayed == false).Sum(x => x.Amount);
            }

            return new OurBank { Loan = Loan, Deposit = Deposit, PayedInstallements = PayedInstallements, NonPayedInstallements = NonPayedInstallements };
        }
        public OurBank GetPeopleBank()
        {
            decimal Loan = dc.LoanSelectCommand().Sum(x => x.Amount);
            decimal Deposit = dc.DepositSelectCommand().Sum(x => x.Amount);

            // TODO better code here
            decimal PayedInstallements = 0, NonPayedInstallements = 0;

            foreach (var item in dc.LoanTransactions)
            {
                PayedInstallements += item.Installements.Where(x => x.IsPayed == true).Sum(x => x.Amount);
                NonPayedInstallements += item.Installements.Where(x => x.IsPayed == false).Sum(x => x.Amount);
            }

            return new OurBank { Loan = Loan, Deposit = Deposit, PayedInstallements = PayedInstallements, NonPayedInstallements = NonPayedInstallements };
        }
        public List<Transaction> GetTransactions(string NationalCode)
        {
            List<Transaction> trs = new List<Transaction>();
            trs = dc.LoanSelectCommand().Where(x => x.PersonNationalCode == NationalCode).OrderBy(x => x.DateTime).Take(3).Select(x => new Transaction { Amount = x.Amount, DateTime = x.DateTime, Direction = "برداشت" }).ToList();
            trs = dc.DepositSelectCommand().Where(x => x.PersonNationalCode == NationalCode).OrderBy(x => x.DateTime).Take(3).Select(x => new Transaction { Amount = x.Amount, DateTime = x.DateTime, Direction = "واریز" }).ToList();

            trs = trs.OrderByDescending(x => x.DateTime).ToList();

            return trs;
        }

        public bool IsActive(string NationalCode)
        {
            return dc.Update1_IsActive(NationalCode).FirstOrDefault().IsActive;
        }
        public void SetActive(string NationalCode, bool IsActive)
        {
            dc.Update1_ToggleAccountActiveState(NationalCode, IsActive);
        }
        public DateTime LastLoginDate(string NationalCode)
        {
            return dc.LogSet_Select().Where(x => x.NationalCode == NationalCode && x.Description == "• Successful Login").OrderByDescending(x => x.EventDateTime).FirstOrDefault().EventDateTime;
        }
    }
    public class OurBank
    {
        public decimal Loan { get; set; }
        public decimal Deposit { get; set; }
        public decimal Amount
        {
            get
            {
                return Deposit - PayedInstallements;
            }
            set { }
        }
        public decimal PayedInstallements { get; set; }
        public decimal NonPayedInstallements { get; set; }
    }
    public class Transaction
    {
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }
        public string Direction { get; set; }
    }
}
