﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KhajeNasirAccountingSystemReportClient.DatabaseLogsService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LogSet_SelectResult", Namespace="http://schemas.datacontract.org/2004/07/KhajeNasirAccountingSystemWcfServiceAppli" +
        "cation")]
    [System.SerializableAttribute()]
    public partial class LogSet_SelectResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EventDateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NationalCodeField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EventDateTime {
            get {
                return this.EventDateTimeField;
            }
            set {
                if ((this.EventDateTimeField.Equals(value) != true)) {
                    this.EventDateTimeField = value;
                    this.RaisePropertyChanged("EventDateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DatabaseLogsService.ILogService")]
    public interface ILogService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogService/GetTopLogs", ReplyAction="http://tempuri.org/ILogService/GetTopLogsResponse")]
        KhajeNasirAccountingSystemReportClient.DatabaseLogsService.LogSet_SelectResult[] GetTopLogs(int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogService/GetTopLogs", ReplyAction="http://tempuri.org/ILogService/GetTopLogsResponse")]
        System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.DatabaseLogsService.LogSet_SelectResult[]> GetTopLogsAsync(int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogService/InsertLog", ReplyAction="http://tempuri.org/ILogService/InsertLogResponse")]
        void InsertLog(string NationalCode, string Description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogService/InsertLog", ReplyAction="http://tempuri.org/ILogService/InsertLogResponse")]
        System.Threading.Tasks.Task InsertLogAsync(string NationalCode, string Description);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILogServiceChannel : KhajeNasirAccountingSystemReportClient.DatabaseLogsService.ILogService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LogServiceClient : System.ServiceModel.ClientBase<KhajeNasirAccountingSystemReportClient.DatabaseLogsService.ILogService>, KhajeNasirAccountingSystemReportClient.DatabaseLogsService.ILogService {
        
        public LogServiceClient() {
        }
        
        public LogServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LogServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LogServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LogServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public KhajeNasirAccountingSystemReportClient.DatabaseLogsService.LogSet_SelectResult[] GetTopLogs(int count) {
            return base.Channel.GetTopLogs(count);
        }
        
        public System.Threading.Tasks.Task<KhajeNasirAccountingSystemReportClient.DatabaseLogsService.LogSet_SelectResult[]> GetTopLogsAsync(int count) {
            return base.Channel.GetTopLogsAsync(count);
        }
        
        public void InsertLog(string NationalCode, string Description) {
            base.Channel.InsertLog(NationalCode, Description);
        }
        
        public System.Threading.Tasks.Task InsertLogAsync(string NationalCode, string Description) {
            return base.Channel.InsertLogAsync(NationalCode, Description);
        }
    }
}
