﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KhajeNasirAccountingSystemReportClient.DepositTransactionsService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="View_Update1_PeopleDeposit", Namespace="http://schemas.datacontract.org/2004/07/KhajeNasirAccountingSystemWcfServiceAppli" +
        "cation")]
    [System.SerializableAttribute()]
    public partial class View_Update1_PeopleDeposit : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdminNationalCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AdminPermissionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BankFollowUpCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid DepositIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NationalCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SuccessfulField;
        
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
        public string AdminNationalCode {
            get {
                return this.AdminNationalCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.AdminNationalCodeField, value) != true)) {
                    this.AdminNationalCodeField = value;
                    this.RaisePropertyChanged("AdminNationalCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AdminPermission {
            get {
                return this.AdminPermissionField;
            }
            set {
                if ((this.AdminPermissionField.Equals(value) != true)) {
                    this.AdminPermissionField = value;
                    this.RaisePropertyChanged("AdminPermission");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BankFollowUpCode {
            get {
                return this.BankFollowUpCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.BankFollowUpCodeField, value) != true)) {
                    this.BankFollowUpCodeField = value;
                    this.RaisePropertyChanged("BankFollowUpCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateTime {
            get {
                return this.DateTimeField;
            }
            set {
                if ((this.DateTimeField.Equals(value) != true)) {
                    this.DateTimeField = value;
                    this.RaisePropertyChanged("DateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid DepositId {
            get {
                return this.DepositIdField;
            }
            set {
                if ((this.DepositIdField.Equals(value) != true)) {
                    this.DepositIdField = value;
                    this.RaisePropertyChanged("DepositId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fullname {
            get {
                return this.FullnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullnameField, value) != true)) {
                    this.FullnameField = value;
                    this.RaisePropertyChanged("Fullname");
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
        public bool Successful {
            get {
                return this.SuccessfulField;
            }
            set {
                if ((this.SuccessfulField.Equals(value) != true)) {
                    this.SuccessfulField = value;
                    this.RaisePropertyChanged("Successful");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DepositSelectCommandResult", Namespace="http://schemas.datacontract.org/2004/07/KhajeNasirAccountingSystemWcfServiceAppli" +
        "cation")]
    [System.SerializableAttribute()]
    public partial class DepositSelectCommandResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdminNationalCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AdminPermissionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BankFollowUpCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PersonNationalCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SuccessfulField;
        
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
        public string AdminNationalCode {
            get {
                return this.AdminNationalCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.AdminNationalCodeField, value) != true)) {
                    this.AdminNationalCodeField = value;
                    this.RaisePropertyChanged("AdminNationalCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AdminPermission {
            get {
                return this.AdminPermissionField;
            }
            set {
                if ((this.AdminPermissionField.Equals(value) != true)) {
                    this.AdminPermissionField = value;
                    this.RaisePropertyChanged("AdminPermission");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BankFollowUpCode {
            get {
                return this.BankFollowUpCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.BankFollowUpCodeField, value) != true)) {
                    this.BankFollowUpCodeField = value;
                    this.RaisePropertyChanged("BankFollowUpCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateTime {
            get {
                return this.DateTimeField;
            }
            set {
                if ((this.DateTimeField.Equals(value) != true)) {
                    this.DateTimeField = value;
                    this.RaisePropertyChanged("DateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PersonNationalCode {
            get {
                return this.PersonNationalCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonNationalCodeField, value) != true)) {
                    this.PersonNationalCodeField = value;
                    this.RaisePropertyChanged("PersonNationalCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Successful {
            get {
                return this.SuccessfulField;
            }
            set {
                if ((this.SuccessfulField.Equals(value) != true)) {
                    this.SuccessfulField = value;
                    this.RaisePropertyChanged("Successful");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DepositTransactionsService.IDepositTransactionsService")]
    public interface IDepositTransactionsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepositTransactionsService/GetPeopleDepositTransactions", ReplyAction="http://tempuri.org/IDepositTransactionsService/GetPeopleDepositTransactionsRespon" +
            "se")]
        KhajeNasirAccountingSystemReportClient.DepositTransactionsService.View_Update1_PeopleDeposit[] GetPeopleDepositTransactions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepositTransactionsService/GetPeopleDepositTransactions", ReplyAction="http://tempuri.org/IDepositTransactionsService/GetPeopleDepositTransactionsRespon" +
            "se")]
        System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.DepositTransactionsService.View_Update1_PeopleDeposit[]> GetPeopleDepositTransactionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepositTransactionsService/UnPermittedDepositTransactions", ReplyAction="http://tempuri.org/IDepositTransactionsService/UnPermittedDepositTransactionsResp" +
            "onse")]
        KhajeNasirAccountingSystemReportClient.DepositTransactionsService.DepositSelectCommandResult[] UnPermittedDepositTransactions(string NationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepositTransactionsService/UnPermittedDepositTransactions", ReplyAction="http://tempuri.org/IDepositTransactionsService/UnPermittedDepositTransactionsResp" +
            "onse")]
        System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.DepositTransactionsService.DepositSelectCommandResult[]> UnPermittedDepositTransactionsAsync(string NationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepositTransactionsService/GetDepositTransactions", ReplyAction="http://tempuri.org/IDepositTransactionsService/GetDepositTransactionsResponse")]
        KhajeNasirAccountingSystemReportClient.DepositTransactionsService.DepositSelectCommandResult[] GetDepositTransactions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepositTransactionsService/GetDepositTransactions", ReplyAction="http://tempuri.org/IDepositTransactionsService/GetDepositTransactionsResponse")]
        System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.DepositTransactionsService.DepositSelectCommandResult[]> GetDepositTransactionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepositTransactionsService/InsertDepositTransactions", ReplyAction="http://tempuri.org/IDepositTransactionsService/InsertDepositTransactionsResponse")]
        void InsertDepositTransactions(System.Guid Id, System.DateTime DateTime, decimal Amount, string BankFollowUpCode, bool AdminPermission, string AdminNationalCode, string PersonNationalCode, bool Successful);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepositTransactionsService/InsertDepositTransactions", ReplyAction="http://tempuri.org/IDepositTransactionsService/InsertDepositTransactionsResponse")]
        System.Threading.Tasks.Task InsertDepositTransactionsAsync(System.Guid Id, System.DateTime DateTime, decimal Amount, string BankFollowUpCode, bool AdminPermission, string AdminNationalCode, string PersonNationalCode, bool Successful);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepositTransactionsService/UpdateDepositTransactions", ReplyAction="http://tempuri.org/IDepositTransactionsService/UpdateDepositTransactionsResponse")]
        void UpdateDepositTransactions(System.Guid Id, System.DateTime DateTime, decimal Amount, string BankFollowUpCode, bool AdminPermission, string AdminNationalCode, string PersonNationalCode, bool Successful);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepositTransactionsService/UpdateDepositTransactions", ReplyAction="http://tempuri.org/IDepositTransactionsService/UpdateDepositTransactionsResponse")]
        System.Threading.Tasks.Task UpdateDepositTransactionsAsync(System.Guid Id, System.DateTime DateTime, decimal Amount, string BankFollowUpCode, bool AdminPermission, string AdminNationalCode, string PersonNationalCode, bool Successful);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepositTransactionsService/DeleteDepositTransactions", ReplyAction="http://tempuri.org/IDepositTransactionsService/DeleteDepositTransactionsResponse")]
        void DeleteDepositTransactions(System.Guid Original_Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepositTransactionsService/DeleteDepositTransactions", ReplyAction="http://tempuri.org/IDepositTransactionsService/DeleteDepositTransactionsResponse")]
        System.Threading.Tasks.Task DeleteDepositTransactionsAsync(System.Guid Original_Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDepositTransactionsServiceChannel : KhajeNasirAccountingSystemReportClient.DepositTransactionsService.IDepositTransactionsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DepositTransactionsServiceClient : System.ServiceModel.ClientBase<KhajeNasirAccountingSystemReportClient.DepositTransactionsService.IDepositTransactionsService>, KhajeNasirAccountingSystemReportClient.DepositTransactionsService.IDepositTransactionsService {
        
        public DepositTransactionsServiceClient() {
        }
        
        public DepositTransactionsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DepositTransactionsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DepositTransactionsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DepositTransactionsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public KhajeNasirAccountingSystemReportClient.DepositTransactionsService.View_Update1_PeopleDeposit[] GetPeopleDepositTransactions() {
            return base.Channel.GetPeopleDepositTransactions();
        }
        
        public System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.DepositTransactionsService.View_Update1_PeopleDeposit[]> GetPeopleDepositTransactionsAsync() {
            return base.Channel.GetPeopleDepositTransactionsAsync();
        }
        
        public KhajeNasirAccountingSystemReportClient.DepositTransactionsService.DepositSelectCommandResult[] UnPermittedDepositTransactions(string NationalCode) {
            return base.Channel.UnPermittedDepositTransactions(NationalCode);
        }
        
        public System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.DepositTransactionsService.DepositSelectCommandResult[]> UnPermittedDepositTransactionsAsync(string NationalCode) {
            return base.Channel.UnPermittedDepositTransactionsAsync(NationalCode);
        }
        
        public KhajeNasirAccountingSystemReportClient.DepositTransactionsService.DepositSelectCommandResult[] GetDepositTransactions() {
            return base.Channel.GetDepositTransactions();
        }
        
        public System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.DepositTransactionsService.DepositSelectCommandResult[]> GetDepositTransactionsAsync() {
            return base.Channel.GetDepositTransactionsAsync();
        }
        
        public void InsertDepositTransactions(System.Guid Id, System.DateTime DateTime, decimal Amount, string BankFollowUpCode, bool AdminPermission, string AdminNationalCode, string PersonNationalCode, bool Successful) {
            base.Channel.InsertDepositTransactions(Id, DateTime, Amount, BankFollowUpCode, AdminPermission, AdminNationalCode, PersonNationalCode, Successful);
        }
        
        public System.Threading.Tasks.Task InsertDepositTransactionsAsync(System.Guid Id, System.DateTime DateTime, decimal Amount, string BankFollowUpCode, bool AdminPermission, string AdminNationalCode, string PersonNationalCode, bool Successful) {
            return base.Channel.InsertDepositTransactionsAsync(Id, DateTime, Amount, BankFollowUpCode, AdminPermission, AdminNationalCode, PersonNationalCode, Successful);
        }
        
        public void UpdateDepositTransactions(System.Guid Id, System.DateTime DateTime, decimal Amount, string BankFollowUpCode, bool AdminPermission, string AdminNationalCode, string PersonNationalCode, bool Successful) {
            base.Channel.UpdateDepositTransactions(Id, DateTime, Amount, BankFollowUpCode, AdminPermission, AdminNationalCode, PersonNationalCode, Successful);
        }
        
        public System.Threading.Tasks.Task UpdateDepositTransactionsAsync(System.Guid Id, System.DateTime DateTime, decimal Amount, string BankFollowUpCode, bool AdminPermission, string AdminNationalCode, string PersonNationalCode, bool Successful) {
            return base.Channel.UpdateDepositTransactionsAsync(Id, DateTime, Amount, BankFollowUpCode, AdminPermission, AdminNationalCode, PersonNationalCode, Successful);
        }
        
        public void DeleteDepositTransactions(System.Guid Original_Id) {
            base.Channel.DeleteDepositTransactions(Original_Id);
        }
        
        public System.Threading.Tasks.Task DeleteDepositTransactionsAsync(System.Guid Original_Id) {
            return base.Channel.DeleteDepositTransactionsAsync(Original_Id);
        }
    }
}