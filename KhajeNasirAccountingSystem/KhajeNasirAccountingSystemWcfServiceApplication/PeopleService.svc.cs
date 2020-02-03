using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KhajeNasirAccountingSystemWcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PeopleService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PeopleService.svc or PeopleService.svc.cs at the Solution Explorer and start debugging.
    public class PeopleService : IPeopleService
    {

        DcDataContext dc = new DcDataContext();

        public List<PeopleSelectCommandResult> GetPeople()
        {
            var people = dc.PeopleSelectCommand().ToList();
            return people;
        }
        public PeopleSelectCommandResult GetPerson(string NationalCode)
        {
            return dc.PeopleSelectCommand().Where(x => x.NationalCode == NationalCode).FirstOrDefault();
        }
        public void InsertPeople(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, string Role, DateTime CreateDateTime, string Password, decimal Contribution)
        {
            dc.PeopleInsertCommand(NationalCode, FirstName, LastName, FathersName, Tel, Mobile, BirthCity, PostalCode, Picture, Role, CreateDateTime, Password, Contribution);
        }
        public void UpdatePeople(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, DateTime CreateDateTime, string Password, decimal Contribution)
        {
            dc.PeopleUpdateCommand(NationalCode, FirstName, LastName, FathersName, Tel, Mobile, BirthCity, PostalCode, Picture, Contribution, Password, NationalCode);
        }
        public void DeletePeople(string Original_NationalCode)
        {
            dc.PeopleDeleteCommand(Original_NationalCode);
        }

        public LoginDetails Login(string NationalCode, string Password)
        {
            var User = dc.PeopleSelectCommand().Where(x => x.NationalCode == NationalCode && x.Password == Password).FirstOrDefault();
            if (User != null)
            {
                if (dc.Update1_IsActive(NationalCode).FirstOrDefault().IsActive)
                {
                    dc.LogSet_Insert("• Successful Login", NationalCode);
                    return new LoginDetails { Role = User.Role, Success = true };
                }
                else
                {
                    dc.LogSet_Insert("• Successful Login • Closed Account", NationalCode);
                    return new LoginDetails { Role = User.Role, Success = false };
                }
            }
            else
            {
                dc.LogSet_Insert("• Failed Login", NationalCode);
                return new LoginDetails { Success = false, Role = null };
            }
        }
        public void ChangePass(string Username, string Password)
        {
            dc.Update1_ChangePass(Username, Password);
        }
    }
    public class LoginDetails
    {
        public bool Success { get; set; }
        public string Role { get; set; }
    }

}
