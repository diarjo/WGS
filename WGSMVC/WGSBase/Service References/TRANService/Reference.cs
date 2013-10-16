﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WGSBase.TRANService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TRANService.ICRUDService", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ICRUDService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDService/GetData", ReplyAction="http://tempuri.org/ICRUDService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(IsTerminating=true, Action="http://tempuri.org/ICRUDService/GetDataSet", ReplyAction="http://tempuri.org/ICRUDService/GetDataSetResponse")]
        System.Data.DataSet GetDataSet(string strSQL);
        
        [System.ServiceModel.OperationContractAttribute(IsTerminating=true, Action="http://tempuri.org/ICRUDService/GetDataTable", ReplyAction="http://tempuri.org/ICRUDService/GetDataTableResponse")]
        System.Data.DataTable GetDataTable(string strSQL, string tblName);
        
        [System.ServiceModel.OperationContractAttribute(IsTerminating=true, Action="http://tempuri.org/ICRUDService/Exec", ReplyAction="http://tempuri.org/ICRUDService/ExecResponse")]
        int Exec(string strSQL);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICRUDServiceChannel : WGSBase.TRANService.ICRUDService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CRUDServiceClient : System.ServiceModel.ClientBase<WGSBase.TRANService.ICRUDService>, WGSBase.TRANService.ICRUDService {
        
        public CRUDServiceClient() {
        }
        
        public CRUDServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CRUDServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CRUDServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CRUDServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Data.DataSet GetDataSet(string strSQL) {
            return base.Channel.GetDataSet(strSQL);
        }
        
        public System.Data.DataTable GetDataTable(string strSQL, string tblName) {
            return base.Channel.GetDataTable(strSQL, tblName);
        }
        
        public int Exec(string strSQL) {
            return base.Channel.Exec(strSQL);
        }
    }
}
