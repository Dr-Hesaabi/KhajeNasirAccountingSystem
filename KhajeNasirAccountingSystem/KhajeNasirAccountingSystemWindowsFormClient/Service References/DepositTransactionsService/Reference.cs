﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KhajeNasirAccountingSystemWindowsFormClient.DepositTransactionsService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DepositTransactionsService.IDepositTransactionsService")]
    public interface IDepositTransactionsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepositTransactionsService/SetDepositPermission", ReplyAction="http://tempuri.org/IDepositTransactionsService/SetDepositPermissionResponse")]
        void SetDepositPermission(System.Guid DepositId, bool Permission, string AdminNationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepositTransactionsService/SetDepositPermission", ReplyAction="http://tempuri.org/IDepositTransactionsService/SetDepositPermissionResponse")]
        System.Threading.Tasks.Task SetDepositPermissionAsync(System.Guid DepositId, bool Permission, string AdminNationalCode);
        
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepositTransactionsService/IncreaseDepositForAll", ReplyAction="http://tempuri.org/IDepositTransactionsService/IncreaseDepositForAllResponse")]
        void IncreaseDepositForAll(decimal Amount, string AdminNationalCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepositTransactionsService/IncreaseDepositForAll", ReplyAction="http://tempuri.org/IDepositTransactionsService/IncreaseDepositForAllResponse")]
        System.Threading.Tasks.Task IncreaseDepositForAllAsync(decimal Amount, string AdminNationalCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDepositTransactionsServiceChannel : KhajeNasirAccountingSystemWindowsFormClient.DepositTransactionsService.IDepositTransactionsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DepositTransactionsServiceClient : System.ServiceModel.ClientBase<KhajeNasirAccountingSystemWindowsFormClient.DepositTransactionsService.IDepositTransactionsService>, KhajeNasirAccountingSystemWindowsFormClient.DepositTransactionsService.IDepositTransactionsService {
        
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
        
        public void SetDepositPermission(System.Guid DepositId, bool Permission, string AdminNationalCode) {
            base.Channel.SetDepositPermission(DepositId, Permission, AdminNationalCode);
        }
        
        public System.Threading.Tasks.Task SetDepositPermissionAsync(System.Guid DepositId, bool Permission, string AdminNationalCode) {
            return base.Channel.SetDepositPermissionAsync(DepositId, Permission, AdminNationalCode);
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
        
        public void IncreaseDepositForAll(decimal Amount, string AdminNationalCode) {
            base.Channel.IncreaseDepositForAll(Amount, AdminNationalCode);
        }
        
        public System.Threading.Tasks.Task IncreaseDepositForAllAsync(decimal Amount, string AdminNationalCode) {
            return base.Channel.IncreaseDepositForAllAsync(Amount, AdminNationalCode);
        }
    }
}
