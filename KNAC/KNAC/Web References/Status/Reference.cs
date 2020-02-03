﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace KNAC.Status {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IStatus", Namespace="http://tempuri.org/")]
    public partial class Status : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetPersonBankOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPeopleBankOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTransactionsOperationCompleted;
        
        private System.Threading.SendOrPostCallback IsActiveOperationCompleted;
        
        private System.Threading.SendOrPostCallback SetActiveOperationCompleted;
        
        private System.Threading.SendOrPostCallback LastLoginDateOperationCompleted;
        
        private System.Threading.SendOrPostCallback IncreaseDepositForAllOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Status() {
            this.Url = "http://192.168.1.10:85/Status.svc";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetPersonBankCompletedEventHandler GetPersonBankCompleted;
        
        /// <remarks/>
        public event GetPeopleBankCompletedEventHandler GetPeopleBankCompleted;
        
        /// <remarks/>
        public event GetTransactionsCompletedEventHandler GetTransactionsCompleted;
        
        /// <remarks/>
        public event IsActiveCompletedEventHandler IsActiveCompleted;
        
        /// <remarks/>
        public event SetActiveCompletedEventHandler SetActiveCompleted;
        
        /// <remarks/>
        public event LastLoginDateCompletedEventHandler LastLoginDateCompleted;
        
        /// <remarks/>
        public event IncreaseDepositForAllCompletedEventHandler IncreaseDepositForAllCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IStatus/GetPersonBank", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public OurBank GetPersonBank([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string NationalCode) {
            object[] results = this.Invoke("GetPersonBank", new object[] {
                        NationalCode});
            return ((OurBank)(results[0]));
        }
        
        /// <remarks/>
        public void GetPersonBankAsync(string NationalCode) {
            this.GetPersonBankAsync(NationalCode, null);
        }
        
        /// <remarks/>
        public void GetPersonBankAsync(string NationalCode, object userState) {
            if ((this.GetPersonBankOperationCompleted == null)) {
                this.GetPersonBankOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPersonBankOperationCompleted);
            }
            this.InvokeAsync("GetPersonBank", new object[] {
                        NationalCode}, this.GetPersonBankOperationCompleted, userState);
        }
        
        private void OnGetPersonBankOperationCompleted(object arg) {
            if ((this.GetPersonBankCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPersonBankCompleted(this, new GetPersonBankCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IStatus/GetPeopleBank", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public OurBank GetPeopleBank() {
            object[] results = this.Invoke("GetPeopleBank", new object[0]);
            return ((OurBank)(results[0]));
        }
        
        /// <remarks/>
        public void GetPeopleBankAsync() {
            this.GetPeopleBankAsync(null);
        }
        
        /// <remarks/>
        public void GetPeopleBankAsync(object userState) {
            if ((this.GetPeopleBankOperationCompleted == null)) {
                this.GetPeopleBankOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPeopleBankOperationCompleted);
            }
            this.InvokeAsync("GetPeopleBank", new object[0], this.GetPeopleBankOperationCompleted, userState);
        }
        
        private void OnGetPeopleBankOperationCompleted(object arg) {
            if ((this.GetPeopleBankCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPeopleBankCompleted(this, new GetPeopleBankCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IStatus/GetTransactions", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/KhajeNasirAccountingSystemWcfServiceAppli" +
            "cation")]
        public Transaction[] GetTransactions([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string NationalCode) {
            object[] results = this.Invoke("GetTransactions", new object[] {
                        NationalCode});
            return ((Transaction[])(results[0]));
        }
        
        /// <remarks/>
        public void GetTransactionsAsync(string NationalCode) {
            this.GetTransactionsAsync(NationalCode, null);
        }
        
        /// <remarks/>
        public void GetTransactionsAsync(string NationalCode, object userState) {
            if ((this.GetTransactionsOperationCompleted == null)) {
                this.GetTransactionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTransactionsOperationCompleted);
            }
            this.InvokeAsync("GetTransactions", new object[] {
                        NationalCode}, this.GetTransactionsOperationCompleted, userState);
        }
        
        private void OnGetTransactionsOperationCompleted(object arg) {
            if ((this.GetTransactionsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTransactionsCompleted(this, new GetTransactionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IStatus/IsActive", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void IsActive([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string NationalCode, out bool IsActiveResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool IsActiveResultSpecified) {
            object[] results = this.Invoke("IsActive", new object[] {
                        NationalCode});
            IsActiveResult = ((bool)(results[0]));
            IsActiveResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void IsActiveAsync(string NationalCode) {
            this.IsActiveAsync(NationalCode, null);
        }
        
        /// <remarks/>
        public void IsActiveAsync(string NationalCode, object userState) {
            if ((this.IsActiveOperationCompleted == null)) {
                this.IsActiveOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIsActiveOperationCompleted);
            }
            this.InvokeAsync("IsActive", new object[] {
                        NationalCode}, this.IsActiveOperationCompleted, userState);
        }
        
        private void OnIsActiveOperationCompleted(object arg) {
            if ((this.IsActiveCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IsActiveCompleted(this, new IsActiveCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IStatus/SetActive", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetActive([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string NationalCode, [System.Xml.Serialization.XmlElementAttribute("IsActive")] bool IsActive1, [System.Xml.Serialization.XmlElementAttribute("IsActive")] [System.Xml.Serialization.XmlIgnoreAttribute()] bool IsActive1Specified) {
            this.Invoke("SetActive", new object[] {
                        NationalCode,
                        IsActive1,
                        IsActive1Specified});
        }
        
        /// <remarks/>
        public void SetActiveAsync(string NationalCode, bool IsActive1, bool IsActive1Specified) {
            this.SetActiveAsync(NationalCode, IsActive1, IsActive1Specified, null);
        }
        
        /// <remarks/>
        public void SetActiveAsync(string NationalCode, bool IsActive1, bool IsActive1Specified, object userState) {
            if ((this.SetActiveOperationCompleted == null)) {
                this.SetActiveOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetActiveOperationCompleted);
            }
            this.InvokeAsync("SetActive", new object[] {
                        NationalCode,
                        IsActive1,
                        IsActive1Specified}, this.SetActiveOperationCompleted, userState);
        }
        
        private void OnSetActiveOperationCompleted(object arg) {
            if ((this.SetActiveCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetActiveCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IStatus/LastLoginDate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void LastLoginDate([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string NationalCode, out System.DateTime LastLoginDateResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool LastLoginDateResultSpecified) {
            object[] results = this.Invoke("LastLoginDate", new object[] {
                        NationalCode});
            LastLoginDateResult = ((System.DateTime)(results[0]));
            LastLoginDateResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void LastLoginDateAsync(string NationalCode) {
            this.LastLoginDateAsync(NationalCode, null);
        }
        
        /// <remarks/>
        public void LastLoginDateAsync(string NationalCode, object userState) {
            if ((this.LastLoginDateOperationCompleted == null)) {
                this.LastLoginDateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLastLoginDateOperationCompleted);
            }
            this.InvokeAsync("LastLoginDate", new object[] {
                        NationalCode}, this.LastLoginDateOperationCompleted, userState);
        }
        
        private void OnLastLoginDateOperationCompleted(object arg) {
            if ((this.LastLoginDateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LastLoginDateCompleted(this, new LastLoginDateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IStatus/IncreaseDepositForAll", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void IncreaseDepositForAll(decimal Amount, [System.Xml.Serialization.XmlIgnoreAttribute()] bool AmountSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string NationalCode) {
            this.Invoke("IncreaseDepositForAll", new object[] {
                        Amount,
                        AmountSpecified,
                        NationalCode});
        }
        
        /// <remarks/>
        public void IncreaseDepositForAllAsync(decimal Amount, bool AmountSpecified, string NationalCode) {
            this.IncreaseDepositForAllAsync(Amount, AmountSpecified, NationalCode, null);
        }
        
        /// <remarks/>
        public void IncreaseDepositForAllAsync(decimal Amount, bool AmountSpecified, string NationalCode, object userState) {
            if ((this.IncreaseDepositForAllOperationCompleted == null)) {
                this.IncreaseDepositForAllOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIncreaseDepositForAllOperationCompleted);
            }
            this.InvokeAsync("IncreaseDepositForAll", new object[] {
                        Amount,
                        AmountSpecified,
                        NationalCode}, this.IncreaseDepositForAllOperationCompleted, userState);
        }
        
        private void OnIncreaseDepositForAllOperationCompleted(object arg) {
            if ((this.IncreaseDepositForAllCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IncreaseDepositForAllCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/KhajeNasirAccountingSystemWcfServiceAppli" +
        "cation")]
    public partial class OurBank {
        
        private decimal amountField;
        
        private bool amountFieldSpecified;
        
        private decimal depositField;
        
        private bool depositFieldSpecified;
        
        private decimal loanField;
        
        private bool loanFieldSpecified;
        
        private decimal nonPayedInstallementsField;
        
        private bool nonPayedInstallementsFieldSpecified;
        
        private decimal payedInstallementsField;
        
        private bool payedInstallementsFieldSpecified;
        
        /// <remarks/>
        public decimal Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified {
            get {
                return this.amountFieldSpecified;
            }
            set {
                this.amountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Deposit {
            get {
                return this.depositField;
            }
            set {
                this.depositField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepositSpecified {
            get {
                return this.depositFieldSpecified;
            }
            set {
                this.depositFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Loan {
            get {
                return this.loanField;
            }
            set {
                this.loanField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LoanSpecified {
            get {
                return this.loanFieldSpecified;
            }
            set {
                this.loanFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal NonPayedInstallements {
            get {
                return this.nonPayedInstallementsField;
            }
            set {
                this.nonPayedInstallementsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NonPayedInstallementsSpecified {
            get {
                return this.nonPayedInstallementsFieldSpecified;
            }
            set {
                this.nonPayedInstallementsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal PayedInstallements {
            get {
                return this.payedInstallementsField;
            }
            set {
                this.payedInstallementsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PayedInstallementsSpecified {
            get {
                return this.payedInstallementsFieldSpecified;
            }
            set {
                this.payedInstallementsFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/KhajeNasirAccountingSystemWcfServiceAppli" +
        "cation")]
    public partial class Transaction {
        
        private decimal amountField;
        
        private bool amountFieldSpecified;
        
        private System.DateTime dateTimeField;
        
        private bool dateTimeFieldSpecified;
        
        private string directionField;
        
        /// <remarks/>
        public decimal Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified {
            get {
                return this.amountFieldSpecified;
            }
            set {
                this.amountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime DateTime {
            get {
                return this.dateTimeField;
            }
            set {
                this.dateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateTimeSpecified {
            get {
                return this.dateTimeFieldSpecified;
            }
            set {
                this.dateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Direction {
            get {
                return this.directionField;
            }
            set {
                this.directionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetPersonBankCompletedEventHandler(object sender, GetPersonBankCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPersonBankCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPersonBankCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public OurBank Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((OurBank)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetPeopleBankCompletedEventHandler(object sender, GetPeopleBankCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPeopleBankCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPeopleBankCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public OurBank Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((OurBank)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetTransactionsCompletedEventHandler(object sender, GetTransactionsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTransactionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTransactionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Transaction[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Transaction[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void IsActiveCompletedEventHandler(object sender, IsActiveCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsActiveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal IsActiveCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool IsActiveResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool IsActiveResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void SetActiveCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void LastLoginDateCompletedEventHandler(object sender, LastLoginDateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LastLoginDateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LastLoginDateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.DateTime LastLoginDateResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.DateTime)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool LastLoginDateResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void IncreaseDepositForAllCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591