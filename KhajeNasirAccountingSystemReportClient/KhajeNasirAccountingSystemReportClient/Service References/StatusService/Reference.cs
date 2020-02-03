﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KhajeNasirAccountingSystemReportClient.StatusService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OurBank", Namespace="http://schemas.datacontract.org/2004/07/KhajeNasirAccountingSystemWcfServiceAppli" +
        "cation")]
    [System.SerializableAttribute()]
    public partial class OurBank : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal DepositField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal LoanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal NonPayedInstallementsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PayedInstallementsField;
        
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
        public decimal Deposit {
            get {
                return this.DepositField;
            }
            set {
                if ((this.DepositField.Equals(value) != true)) {
                    this.DepositField = value;
                    this.RaisePropertyChanged("Deposit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Loan {
            get {
                return this.LoanField;
            }
            set {
                if ((this.LoanField.Equals(value) != true)) {
                    this.LoanField = value;
                    this.RaisePropertyChanged("Loan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal NonPayedInstallements {
            get {
                return this.NonPayedInstallementsField;
            }
            set {
                if ((this.NonPayedInstallementsField.Equals(value) != true)) {
                    this.NonPayedInstallementsField = value;
                    this.RaisePropertyChanged("NonPayedInstallements");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal PayedInstallements {
            get {
                return this.PayedInstallementsField;
            }
            set {
                if ((this.PayedInstallementsField.Equals(value) != true)) {
                    this.PayedInstallementsField = value;
                    this.RaisePropertyChanged("PayedInstallements");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Transaction", Namespace="http://schemas.datacontract.org/2004/07/KhajeNasirAccountingSystemWcfServiceAppli" +
        "cation")]
    [System.SerializableAttribute()]
    public partial class Transaction : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DirectionField;
        
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
        public string Direction {
            get {
                return this.DirectionField;
            }
            set {
                if ((object.ReferenceEquals(this.DirectionField, value) != true)) {
                    this.DirectionField = value;
                    this.RaisePropertyChanged("Direction");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StatusService.IStatus")]
    public interface IStatus {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatus/GetPersonBank", ReplyAction="http://tempuri.org/IStatus/GetPersonBankResponse")]
        KhajeNasirAccountingSystemReportClient.StatusService.OurBank GetPersonBank(string NationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatus/GetPersonBank", ReplyAction="http://tempuri.org/IStatus/GetPersonBankResponse")]
        System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.StatusService.OurBank> GetPersonBankAsync(string NationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatus/GetPeopleBank", ReplyAction="http://tempuri.org/IStatus/GetPeopleBankResponse")]
        KhajeNasirAccountingSystemReportClient.StatusService.OurBank GetPeopleBank();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatus/GetPeopleBank", ReplyAction="http://tempuri.org/IStatus/GetPeopleBankResponse")]
        System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.StatusService.OurBank> GetPeopleBankAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatus/GetTransactions", ReplyAction="http://tempuri.org/IStatus/GetTransactionsResponse")]
        KhajeNasirAccountingSystemReportClient.StatusService.Transaction[] GetTransactions(string NationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatus/GetTransactions", ReplyAction="http://tempuri.org/IStatus/GetTransactionsResponse")]
        System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.StatusService.Transaction[]> GetTransactionsAsync(string NationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatus/IsActive", ReplyAction="http://tempuri.org/IStatus/IsActiveResponse")]
        bool IsActive(string NationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatus/IsActive", ReplyAction="http://tempuri.org/IStatus/IsActiveResponse")]
        System.Threading.Tasks.Task<bool> IsActiveAsync(string NationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatus/SetActive", ReplyAction="http://tempuri.org/IStatus/SetActiveResponse")]
        void SetActive(string NationalCode, bool IsActive);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatus/SetActive", ReplyAction="http://tempuri.org/IStatus/SetActiveResponse")]
        System.Threading.Tasks.Task SetActiveAsync(string NationalCode, bool IsActive);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatus/LastLoginDate", ReplyAction="http://tempuri.org/IStatus/LastLoginDateResponse")]
        System.DateTime LastLoginDate(string NationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatus/LastLoginDate", ReplyAction="http://tempuri.org/IStatus/LastLoginDateResponse")]
        System.Threading.Tasks.Task<System.DateTime> LastLoginDateAsync(string NationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatus/IncreaseDepositForAll", ReplyAction="http://tempuri.org/IStatus/IncreaseDepositForAllResponse")]
        void IncreaseDepositForAll(decimal Amount, string NationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatus/IncreaseDepositForAll", ReplyAction="http://tempuri.org/IStatus/IncreaseDepositForAllResponse")]
        System.Threading.Tasks.Task IncreaseDepositForAllAsync(decimal Amount, string NationalCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStatusChannel : KhajeNasirAccountingSystemReportClient.StatusService.IStatus, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StatusClient : System.ServiceModel.ClientBase<KhajeNasirAccountingSystemReportClient.StatusService.IStatus>, KhajeNasirAccountingSystemReportClient.StatusService.IStatus {
        
        public StatusClient() {
        }
        
        public StatusClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StatusClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StatusClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StatusClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public KhajeNasirAccountingSystemReportClient.StatusService.OurBank GetPersonBank(string NationalCode) {
            return base.Channel.GetPersonBank(NationalCode);
        }
        
        public System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.StatusService.OurBank> GetPersonBankAsync(string NationalCode) {
            return base.Channel.GetPersonBankAsync(NationalCode);
        }
        
        public KhajeNasirAccountingSystemReportClient.StatusService.OurBank GetPeopleBank() {
            return base.Channel.GetPeopleBank();
        }
        
        public System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.StatusService.OurBank> GetPeopleBankAsync() {
            return base.Channel.GetPeopleBankAsync();
        }
        
        public KhajeNasirAccountingSystemReportClient.StatusService.Transaction[] GetTransactions(string NationalCode) {
            return base.Channel.GetTransactions(NationalCode);
        }
        
        public System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.StatusService.Transaction[]> GetTransactionsAsync(string NationalCode) {
            return base.Channel.GetTransactionsAsync(NationalCode);
        }
        
        public bool IsActive(string NationalCode) {
            return base.Channel.IsActive(NationalCode);
        }
        
        public System.Threading.Tasks.Task<bool> IsActiveAsync(string NationalCode) {
            return base.Channel.IsActiveAsync(NationalCode);
        }
        
        public void SetActive(string NationalCode, bool IsActive) {
            base.Channel.SetActive(NationalCode, IsActive);
        }
        
        public System.Threading.Tasks.Task SetActiveAsync(string NationalCode, bool IsActive) {
            return base.Channel.SetActiveAsync(NationalCode, IsActive);
        }
        
        public System.DateTime LastLoginDate(string NationalCode) {
            return base.Channel.LastLoginDate(NationalCode);
        }
        
        public System.Threading.Tasks.Task<System.DateTime> LastLoginDateAsync(string NationalCode) {
            return base.Channel.LastLoginDateAsync(NationalCode);
        }
        
        public void IncreaseDepositForAll(decimal Amount, string NationalCode) {
            base.Channel.IncreaseDepositForAll(Amount, NationalCode);
        }
        
        public System.Threading.Tasks.Task IncreaseDepositForAllAsync(decimal Amount, string NationalCode) {
            return base.Channel.IncreaseDepositForAllAsync(Amount, NationalCode);
        }
    }
}
