﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KhajeNasirAccountingSystemWindowsFormClient.PeopleService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PeopleService.IPeopleService")]
    public interface IPeopleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetPeople", ReplyAction="http://tempuri.org/IPeopleService/GetPeopleResponse")]
        KhajeNasirAccountingSystemReportClient.PeopleService.PeopleSelectCommandResult[] GetPeople();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetPeople", ReplyAction="http://tempuri.org/IPeopleService/GetPeopleResponse")]
        System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.PeopleService.PeopleSelectCommandResult[]> GetPeopleAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetPerson", ReplyAction="http://tempuri.org/IPeopleService/GetPersonResponse")]
        KhajeNasirAccountingSystemReportClient.PeopleService.PeopleSelectCommandResult GetPerson(string NationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetPerson", ReplyAction="http://tempuri.org/IPeopleService/GetPersonResponse")]
        System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.PeopleService.PeopleSelectCommandResult> GetPersonAsync(string NationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/InsertPeople", ReplyAction="http://tempuri.org/IPeopleService/InsertPeopleResponse")]
        void InsertPeople(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, string Role, System.DateTime CreateDateTime, string Password, decimal Contribution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/InsertPeople", ReplyAction="http://tempuri.org/IPeopleService/InsertPeopleResponse")]
        System.Threading.Tasks.Task InsertPeopleAsync(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, string Role, System.DateTime CreateDateTime, string Password, decimal Contribution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/UpdatePeople", ReplyAction="http://tempuri.org/IPeopleService/UpdatePeopleResponse")]
        void UpdatePeople(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, System.DateTime CreateDateTime, string Password, decimal Contribution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/UpdatePeople", ReplyAction="http://tempuri.org/IPeopleService/UpdatePeopleResponse")]
        System.Threading.Tasks.Task UpdatePeopleAsync(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, System.DateTime CreateDateTime, string Password, decimal Contribution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/DeletePeople", ReplyAction="http://tempuri.org/IPeopleService/DeletePeopleResponse")]
        void DeletePeople(string Original_NationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/DeletePeople", ReplyAction="http://tempuri.org/IPeopleService/DeletePeopleResponse")]
        System.Threading.Tasks.Task DeletePeopleAsync(string Original_NationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/Login", ReplyAction="http://tempuri.org/IPeopleService/LoginResponse")]
        KhajeNasirAccountingSystemReportClient.PeopleService.LoginDetails Login(string Username, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/Login", ReplyAction="http://tempuri.org/IPeopleService/LoginResponse")]
        System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.PeopleService.LoginDetails> LoginAsync(string Username, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/ChangePass", ReplyAction="http://tempuri.org/IPeopleService/ChangePassResponse")]
        void ChangePass(string Username, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/ChangePass", ReplyAction="http://tempuri.org/IPeopleService/ChangePassResponse")]
        System.Threading.Tasks.Task ChangePassAsync(string Username, string Password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPeopleServiceChannel : KhajeNasirAccountingSystemWindowsFormClient.PeopleService.IPeopleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PeopleServiceClient : System.ServiceModel.ClientBase<KhajeNasirAccountingSystemWindowsFormClient.PeopleService.IPeopleService>, KhajeNasirAccountingSystemWindowsFormClient.PeopleService.IPeopleService {
        
        public PeopleServiceClient() {
        }
        
        public PeopleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PeopleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeopleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeopleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public KhajeNasirAccountingSystemReportClient.PeopleService.PeopleSelectCommandResult[] GetPeople() {
            return base.Channel.GetPeople();
        }
        
        public System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.PeopleService.PeopleSelectCommandResult[]> GetPeopleAsync() {
            return base.Channel.GetPeopleAsync();
        }
        
        public KhajeNasirAccountingSystemReportClient.PeopleService.PeopleSelectCommandResult GetPerson(string NationalCode) {
            return base.Channel.GetPerson(NationalCode);
        }
        
        public System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.PeopleService.PeopleSelectCommandResult> GetPersonAsync(string NationalCode) {
            return base.Channel.GetPersonAsync(NationalCode);
        }
        
        public void InsertPeople(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, string Role, System.DateTime CreateDateTime, string Password, decimal Contribution) {
            base.Channel.InsertPeople(NationalCode, FirstName, LastName, FathersName, Tel, Mobile, BirthCity, PostalCode, Picture, Role, CreateDateTime, Password, Contribution);
        }
        
        public System.Threading.Tasks.Task InsertPeopleAsync(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, string Role, System.DateTime CreateDateTime, string Password, decimal Contribution) {
            return base.Channel.InsertPeopleAsync(NationalCode, FirstName, LastName, FathersName, Tel, Mobile, BirthCity, PostalCode, Picture, Role, CreateDateTime, Password, Contribution);
        }
        
        public void UpdatePeople(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, System.DateTime CreateDateTime, string Password, decimal Contribution) {
            base.Channel.UpdatePeople(NationalCode, FirstName, LastName, FathersName, Tel, Mobile, BirthCity, PostalCode, Picture, CreateDateTime, Password, Contribution);
        }
        
        public System.Threading.Tasks.Task UpdatePeopleAsync(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, System.DateTime CreateDateTime, string Password, decimal Contribution) {
            return base.Channel.UpdatePeopleAsync(NationalCode, FirstName, LastName, FathersName, Tel, Mobile, BirthCity, PostalCode, Picture, CreateDateTime, Password, Contribution);
        }
        
        public void DeletePeople(string Original_NationalCode) {
            base.Channel.DeletePeople(Original_NationalCode);
        }
        
        public System.Threading.Tasks.Task DeletePeopleAsync(string Original_NationalCode) {
            return base.Channel.DeletePeopleAsync(Original_NationalCode);
        }
        
        public KhajeNasirAccountingSystemReportClient.PeopleService.LoginDetails Login(string Username, string Password) {
            return base.Channel.Login(Username, Password);
        }
        
        public System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.PeopleService.LoginDetails> LoginAsync(string Username, string Password) {
            return base.Channel.LoginAsync(Username, Password);
        }
        
        public void ChangePass(string Username, string Password) {
            base.Channel.ChangePass(Username, Password);
        }
        
        public System.Threading.Tasks.Task ChangePassAsync(string Username, string Password) {
            return base.Channel.ChangePassAsync(Username, Password);
        }
    }
}
