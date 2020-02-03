using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KhajeNasirAccountingSystemWcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPeopleService" in both code and config file together.
    [ServiceContract]
    public interface IPeopleService
    {
        [OperationContract]
        List<PeopleSelectCommandResult> GetPeople();
        [OperationContract]
        PeopleSelectCommandResult GetPerson(string NationalCode);
        [OperationContract]
        void InsertPeople(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, string Role, DateTime CreateDateTime, string Password, decimal Contribution);
        [OperationContract]
        void UpdatePeople(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture,  DateTime CreateDateTime, string Password, decimal Contribution);
        [OperationContract]
        void DeletePeople(string Original_NationalCode);
        [OperationContract]
        LoginDetails Login(string Username, string Password);
        [OperationContract]
        void ChangePass(string Username, string Password);
    }
}
