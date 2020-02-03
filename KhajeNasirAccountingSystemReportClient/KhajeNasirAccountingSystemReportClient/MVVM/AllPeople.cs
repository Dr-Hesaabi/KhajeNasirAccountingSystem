using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhajeNasirAccountingSystemReportClient.MVVM
{
    class AllPeopleModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string FathersName { get; set; }

        public string NationalCode { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public decimal Loan { get; set; }
        public decimal Deposit { get; set; }
        public decimal NonPayedInstallements { get; set; }
        public decimal PayedInstallements { get; set; }
    }
    class AllPeople
    {
        static public List<AllPeopleModel> Get()
        {
            List<AllPeopleModel> people = new List<AllPeopleModel>();
            new PeopleService.PeopleServiceClient().GetPeople().ToList().ForEach(x => people.Add(new AllPeopleModel
            {
                Firstname = x.FirstName,
                Lastname = x.LastName,
                FathersName = x.FathersName,
                Mobile = x.Mobile,
                NationalCode = x.NationalCode,
                Tel = x.Tel,
                Deposit = new StatusService.StatusClient().GetPersonBank(x.NationalCode).Deposit,
                Loan = new StatusService.StatusClient().GetPersonBank(x.NationalCode).Loan,
                NonPayedInstallements = new StatusService.StatusClient().GetPersonBank(x.NationalCode).NonPayedInstallements,
                PayedInstallements = new StatusService.StatusClient().GetPersonBank(x.NationalCode).PayedInstallements
            }));
            return people;
        }
    }
}
