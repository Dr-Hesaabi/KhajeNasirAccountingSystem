using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhajeNasirAccountingSystemReportClient.MVVM
{
    class CustomReport1Model
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string FathersName { get; set; }
        public string NationalCode { get; set; }
        public decimal Contribution { get; set; }
        public decimal Total { get; set; }
    }
    class CustomReport1
    {
        static public List<CustomReport1Model> Get()
        {
            List<CustomReport1Model> cr = new List<CustomReport1Model>();
            new PeopleService.PeopleServiceClient().GetPeople().ToList().ForEach(x => cr.Add(new CustomReport1Model
            {
                Firstname = x.FirstName,
                Lastname = x.LastName,
                FathersName = x.FathersName,
                NationalCode = x.NationalCode,
                Contribution = x.Contribution ?? 0,
                Total = new StatusService.StatusClient().GetPersonBank(x.NationalCode).Amount
            }));
            return cr;
        }
    }
}
