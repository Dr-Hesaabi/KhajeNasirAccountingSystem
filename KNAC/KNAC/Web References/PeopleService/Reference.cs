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

namespace KNAC.PeopleService {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IPeopleService", Namespace="http://tempuri.org/")]
    public partial class PeopleService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetPeopleOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPersonOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertPeopleOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdatePeopleOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeletePeopleOperationCompleted;
        
        private System.Threading.SendOrPostCallback LoginOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public PeopleService() {
            this.Url = "http://192.168.1.10:85/PeopleService.svc";
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
        public event GetPeopleCompletedEventHandler GetPeopleCompleted;
        
        /// <remarks/>
        public event GetPersonCompletedEventHandler GetPersonCompleted;
        
        /// <remarks/>
        public event InsertPeopleCompletedEventHandler InsertPeopleCompleted;
        
        /// <remarks/>
        public event UpdatePeopleCompletedEventHandler UpdatePeopleCompleted;
        
        /// <remarks/>
        public event DeletePeopleCompletedEventHandler DeletePeopleCompleted;
        
        /// <remarks/>
        public event LoginCompletedEventHandler LoginCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IPeopleService/GetPeople", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/KhajeNasirAccountingSystemWcfServiceAppli" +
            "cation")]
        public PeopleSelectCommandResult[] GetPeople() {
            object[] results = this.Invoke("GetPeople", new object[0]);
            return ((PeopleSelectCommandResult[])(results[0]));
        }
        
        /// <remarks/>
        public void GetPeopleAsync() {
            this.GetPeopleAsync(null);
        }
        
        /// <remarks/>
        public void GetPeopleAsync(object userState) {
            if ((this.GetPeopleOperationCompleted == null)) {
                this.GetPeopleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPeopleOperationCompleted);
            }
            this.InvokeAsync("GetPeople", new object[0], this.GetPeopleOperationCompleted, userState);
        }
        
        private void OnGetPeopleOperationCompleted(object arg) {
            if ((this.GetPeopleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPeopleCompleted(this, new GetPeopleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IPeopleService/GetPerson", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public PeopleSelectCommandResult GetPerson([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string NationalCode) {
            object[] results = this.Invoke("GetPerson", new object[] {
                        NationalCode});
            return ((PeopleSelectCommandResult)(results[0]));
        }
        
        /// <remarks/>
        public void GetPersonAsync(string NationalCode) {
            this.GetPersonAsync(NationalCode, null);
        }
        
        /// <remarks/>
        public void GetPersonAsync(string NationalCode, object userState) {
            if ((this.GetPersonOperationCompleted == null)) {
                this.GetPersonOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPersonOperationCompleted);
            }
            this.InvokeAsync("GetPerson", new object[] {
                        NationalCode}, this.GetPersonOperationCompleted, userState);
        }
        
        private void OnGetPersonOperationCompleted(object arg) {
            if ((this.GetPersonCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPersonCompleted(this, new GetPersonCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IPeopleService/InsertPeople", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void InsertPeople([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string NationalCode, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string FirstName, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string LastName, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string FathersName, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Tel, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Mobile, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string BirthCity, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string PostalCode, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Picture, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Role, System.DateTime CreateDateTime, [System.Xml.Serialization.XmlIgnoreAttribute()] bool CreateDateTimeSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Password) {
            this.Invoke("InsertPeople", new object[] {
                        NationalCode,
                        FirstName,
                        LastName,
                        FathersName,
                        Tel,
                        Mobile,
                        BirthCity,
                        PostalCode,
                        Picture,
                        Role,
                        CreateDateTime,
                        CreateDateTimeSpecified,
                        Password});
        }
        
        /// <remarks/>
        public void InsertPeopleAsync(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, string Role, System.DateTime CreateDateTime, bool CreateDateTimeSpecified, string Password) {
            this.InsertPeopleAsync(NationalCode, FirstName, LastName, FathersName, Tel, Mobile, BirthCity, PostalCode, Picture, Role, CreateDateTime, CreateDateTimeSpecified, Password, null);
        }
        
        /// <remarks/>
        public void InsertPeopleAsync(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, string Role, System.DateTime CreateDateTime, bool CreateDateTimeSpecified, string Password, object userState) {
            if ((this.InsertPeopleOperationCompleted == null)) {
                this.InsertPeopleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertPeopleOperationCompleted);
            }
            this.InvokeAsync("InsertPeople", new object[] {
                        NationalCode,
                        FirstName,
                        LastName,
                        FathersName,
                        Tel,
                        Mobile,
                        BirthCity,
                        PostalCode,
                        Picture,
                        Role,
                        CreateDateTime,
                        CreateDateTimeSpecified,
                        Password}, this.InsertPeopleOperationCompleted, userState);
        }
        
        private void OnInsertPeopleOperationCompleted(object arg) {
            if ((this.InsertPeopleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertPeopleCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IPeopleService/UpdatePeople", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdatePeople([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string NationalCode, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string FirstName, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string LastName, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string FathersName, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Tel, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Mobile, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string BirthCity, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string PostalCode, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Picture, System.DateTime CreateDateTime, [System.Xml.Serialization.XmlIgnoreAttribute()] bool CreateDateTimeSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Password) {
            this.Invoke("UpdatePeople", new object[] {
                        NationalCode,
                        FirstName,
                        LastName,
                        FathersName,
                        Tel,
                        Mobile,
                        BirthCity,
                        PostalCode,
                        Picture,
                        CreateDateTime,
                        CreateDateTimeSpecified,
                        Password});
        }
        
        /// <remarks/>
        public void UpdatePeopleAsync(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, System.DateTime CreateDateTime, bool CreateDateTimeSpecified, string Password) {
            this.UpdatePeopleAsync(NationalCode, FirstName, LastName, FathersName, Tel, Mobile, BirthCity, PostalCode, Picture, CreateDateTime, CreateDateTimeSpecified, Password, null);
        }
        
        /// <remarks/>
        public void UpdatePeopleAsync(string NationalCode, string FirstName, string LastName, string FathersName, string Tel, string Mobile, string BirthCity, string PostalCode, string Picture, System.DateTime CreateDateTime, bool CreateDateTimeSpecified, string Password, object userState) {
            if ((this.UpdatePeopleOperationCompleted == null)) {
                this.UpdatePeopleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdatePeopleOperationCompleted);
            }
            this.InvokeAsync("UpdatePeople", new object[] {
                        NationalCode,
                        FirstName,
                        LastName,
                        FathersName,
                        Tel,
                        Mobile,
                        BirthCity,
                        PostalCode,
                        Picture,
                        CreateDateTime,
                        CreateDateTimeSpecified,
                        Password}, this.UpdatePeopleOperationCompleted, userState);
        }
        
        private void OnUpdatePeopleOperationCompleted(object arg) {
            if ((this.UpdatePeopleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdatePeopleCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IPeopleService/DeletePeople", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeletePeople([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Original_NationalCode) {
            this.Invoke("DeletePeople", new object[] {
                        Original_NationalCode});
        }
        
        /// <remarks/>
        public void DeletePeopleAsync(string Original_NationalCode) {
            this.DeletePeopleAsync(Original_NationalCode, null);
        }
        
        /// <remarks/>
        public void DeletePeopleAsync(string Original_NationalCode, object userState) {
            if ((this.DeletePeopleOperationCompleted == null)) {
                this.DeletePeopleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeletePeopleOperationCompleted);
            }
            this.InvokeAsync("DeletePeople", new object[] {
                        Original_NationalCode}, this.DeletePeopleOperationCompleted, userState);
        }
        
        private void OnDeletePeopleOperationCompleted(object arg) {
            if ((this.DeletePeopleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeletePeopleCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IPeopleService/Login", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public LoginDetails Login([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Username, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Password) {
            object[] results = this.Invoke("Login", new object[] {
                        Username,
                        Password});
            return ((LoginDetails)(results[0]));
        }
        
        /// <remarks/>
        public void LoginAsync(string Username, string Password) {
            this.LoginAsync(Username, Password, null);
        }
        
        /// <remarks/>
        public void LoginAsync(string Username, string Password, object userState) {
            if ((this.LoginOperationCompleted == null)) {
                this.LoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginOperationCompleted);
            }
            this.InvokeAsync("Login", new object[] {
                        Username,
                        Password}, this.LoginOperationCompleted, userState);
        }
        
        private void OnLoginOperationCompleted(object arg) {
            if ((this.LoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginCompleted(this, new LoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class PeopleSelectCommandResult {
        
        private string addressField;
        
        private string birthCityField;
        
        private System.DateTime birthDateField;
        
        private bool birthDateFieldSpecified;
        
        private System.DateTime createDateTimeField;
        
        private bool createDateTimeFieldSpecified;
        
        private string fathersNameField;
        
        private string firstNameField;
        
        private bool isActiveField;
        
        private bool isActiveFieldSpecified;
        
        private string lastNameField;
        
        private string mobileField;
        
        private string nationalCodeField;
        
        private string passwordField;
        
        private string pictureField;
        
        private string postalCodeField;
        
        private string roleField;
        
        private string telField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string BirthCity {
            get {
                return this.birthCityField;
            }
            set {
                this.birthCityField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime BirthDate {
            get {
                return this.birthDateField;
            }
            set {
                this.birthDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BirthDateSpecified {
            get {
                return this.birthDateFieldSpecified;
            }
            set {
                this.birthDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime CreateDateTime {
            get {
                return this.createDateTimeField;
            }
            set {
                this.createDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreateDateTimeSpecified {
            get {
                return this.createDateTimeFieldSpecified;
            }
            set {
                this.createDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FathersName {
            get {
                return this.fathersNameField;
            }
            set {
                this.fathersNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FirstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        public bool IsActive {
            get {
                return this.isActiveField;
            }
            set {
                this.isActiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsActiveSpecified {
            get {
                return this.isActiveFieldSpecified;
            }
            set {
                this.isActiveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string LastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Mobile {
            get {
                return this.mobileField;
            }
            set {
                this.mobileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NationalCode {
            get {
                return this.nationalCodeField;
            }
            set {
                this.nationalCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Picture {
            get {
                return this.pictureField;
            }
            set {
                this.pictureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string PostalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Tel {
            get {
                return this.telField;
            }
            set {
                this.telField = value;
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
    public partial class LoginDetails {
        
        private string roleField;
        
        private bool successField;
        
        private bool successFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        public bool Success {
            get {
                return this.successField;
            }
            set {
                this.successField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SuccessSpecified {
            get {
                return this.successFieldSpecified;
            }
            set {
                this.successFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetPeopleCompletedEventHandler(object sender, GetPeopleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPeopleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPeopleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public PeopleSelectCommandResult[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((PeopleSelectCommandResult[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetPersonCompletedEventHandler(object sender, GetPersonCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPersonCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPersonCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public PeopleSelectCommandResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((PeopleSelectCommandResult)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void InsertPeopleCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void UpdatePeopleCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void DeletePeopleCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void LoginCompletedEventHandler(object sender, LoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public LoginDetails Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((LoginDetails)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591