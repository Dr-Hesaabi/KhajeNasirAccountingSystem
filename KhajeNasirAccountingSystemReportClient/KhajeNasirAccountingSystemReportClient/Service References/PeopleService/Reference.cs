﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KhajeNasirAccountingSystemReportClient.PeopleService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PeopleSelectCommandResult", Namespace="http://schemas.datacontract.org/2004/07/KhajeNasirAccountingSystemWcfServiceAppli" +
        "cation")]
    [System.SerializableAttribute()]
    public partial class PeopleSelectCommandResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BirthCityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> ContributionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreateDateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FathersNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsActiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MobileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NationalCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PictureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostalCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BirthCity {
            get {
                return this.BirthCityField;
            }
            set {
                if ((object.ReferenceEquals(this.BirthCityField, value) != true)) {
                    this.BirthCityField = value;
                    this.RaisePropertyChanged("BirthCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Contribution {
            get {
                return this.ContributionField;
            }
            set {
                if ((this.ContributionField.Equals(value) != true)) {
                    this.ContributionField = value;
                    this.RaisePropertyChanged("Contribution");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreateDateTime {
            get {
                return this.CreateDateTimeField;
            }
            set {
                if ((this.CreateDateTimeField.Equals(value) != true)) {
                    this.CreateDateTimeField = value;
                    this.RaisePropertyChanged("CreateDateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FathersName {
            get {
                return this.FathersNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FathersNameField, value) != true)) {
                    this.FathersNameField = value;
                    this.RaisePropertyChanged("FathersName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsActive {
            get {
                return this.IsActiveField;
            }
            set {
                if ((this.IsActiveField.Equals(value) != true)) {
                    this.IsActiveField = value;
                    this.RaisePropertyChanged("IsActive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mobile {
            get {
                return this.MobileField;
            }
            set {
                if ((object.ReferenceEquals(this.MobileField, value) != true)) {
                    this.MobileField = value;
                    this.RaisePropertyChanged("Mobile");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NationalCode {
            get {
                return this.NationalCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.NationalCodeField, value) != true)) {
                    this.NationalCodeField = value;
                    this.RaisePropertyChanged("NationalCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Picture {
            get {
                return this.PictureField;
            }
            set {
                if ((object.ReferenceEquals(this.PictureField, value) != true)) {
                    this.PictureField = value;
                    this.RaisePropertyChanged("Picture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostalCode {
            get {
                return this.PostalCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.PostalCodeField, value) != true)) {
                    this.PostalCodeField = value;
                    this.RaisePropertyChanged("PostalCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Role {
            get {
                return this.RoleField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleField, value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tel {
            get {
                return this.TelField;
            }
            set {
                if ((object.ReferenceEquals(this.TelField, value) != true)) {
                    this.TelField = value;
                    this.RaisePropertyChanged("Tel");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginDetails", Namespace="http://schemas.datacontract.org/2004/07/KhajeNasirAccountingSystemWcfServiceAppli" +
        "cation")]
    [System.SerializableAttribute()]
    public partial class LoginDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SuccessField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Role {
            get {
                return this.RoleField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleField, value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Success {
            get {
                return this.SuccessField;
            }
            set {
                if ((this.SuccessField.Equals(value) != true)) {
                    this.SuccessField = value;
                    this.RaisePropertyChanged("Success");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
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
        void InsertPeople(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, string Role, System.DateTime CreateDateTime, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/InsertPeople", ReplyAction="http://tempuri.org/IPeopleService/InsertPeopleResponse")]
        System.Threading.Tasks.Task InsertPeopleAsync(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, string Role, System.DateTime CreateDateTime, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/UpdatePeople", ReplyAction="http://tempuri.org/IPeopleService/UpdatePeopleResponse")]
        void UpdatePeople(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, System.DateTime CreateDateTime, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/UpdatePeople", ReplyAction="http://tempuri.org/IPeopleService/UpdatePeopleResponse")]
        System.Threading.Tasks.Task UpdatePeopleAsync(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, System.DateTime CreateDateTime, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/DeletePeople", ReplyAction="http://tempuri.org/IPeopleService/DeletePeopleResponse")]
        void DeletePeople(string Original_NationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/DeletePeople", ReplyAction="http://tempuri.org/IPeopleService/DeletePeopleResponse")]
        System.Threading.Tasks.Task DeletePeopleAsync(string Original_NationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/Login", ReplyAction="http://tempuri.org/IPeopleService/LoginResponse")]
        KhajeNasirAccountingSystemReportClient.PeopleService.LoginDetails Login(string Username, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/Login", ReplyAction="http://tempuri.org/IPeopleService/LoginResponse")]
        System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.PeopleService.LoginDetails> LoginAsync(string Username, string Password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPeopleServiceChannel : KhajeNasirAccountingSystemReportClient.PeopleService.IPeopleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PeopleServiceClient : System.ServiceModel.ClientBase<KhajeNasirAccountingSystemReportClient.PeopleService.IPeopleService>, KhajeNasirAccountingSystemReportClient.PeopleService.IPeopleService {
        
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
        
        public void InsertPeople(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, string Role, System.DateTime CreateDateTime, string Password) {
            base.Channel.InsertPeople(NationalCode, FirstName, LastName, FathersName, Tel, Mobile, BirthCity, PostalCode, Picture, Role, CreateDateTime, Password);
        }
        
        public System.Threading.Tasks.Task InsertPeopleAsync(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, string Role, System.DateTime CreateDateTime, string Password) {
            return base.Channel.InsertPeopleAsync(NationalCode, FirstName, LastName, FathersName, Tel, Mobile, BirthCity, PostalCode, Picture, Role, CreateDateTime, Password);
        }
        
        public void UpdatePeople(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, System.DateTime CreateDateTime, string Password) {
            base.Channel.UpdatePeople(NationalCode, FirstName, LastName, FathersName, Tel, Mobile, BirthCity, PostalCode, Picture, CreateDateTime, Password);
        }
        
        public System.Threading.Tasks.Task UpdatePeopleAsync(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, System.DateTime CreateDateTime, string Password) {
            return base.Channel.UpdatePeopleAsync(NationalCode, FirstName, LastName, FathersName, Tel, Mobile, BirthCity, PostalCode, Picture, CreateDateTime, Password);
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
    }
}