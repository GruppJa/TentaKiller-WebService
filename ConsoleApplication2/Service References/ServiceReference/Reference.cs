﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication2.ServiceReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tentakiller.org/show", ConfigurationName="ServiceReference.WebServiceSoap")]
    public interface WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tentakiller.org/show/getStudents", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tentakiller.org/show/getStudents", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tentakiller.org/show/getExams", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getExams();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tentakiller.org/show/getExams", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getExamsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tentakiller.org/show/getTrials", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getTrials();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tentakiller.org/show/getTrials", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getTrialsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : ConsoleApplication2.ServiceReference.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<ConsoleApplication2.ServiceReference.WebServiceSoap>, ConsoleApplication2.ServiceReference.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet getStudents() {
            return base.Channel.getStudents();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getStudentsAsync() {
            return base.Channel.getStudentsAsync();
        }
        
        public System.Data.DataSet getExams() {
            return base.Channel.getExams();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getExamsAsync() {
            return base.Channel.getExamsAsync();
        }
        
        public System.Data.DataSet getTrials() {
            return base.Channel.getTrials();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getTrialsAsync() {
            return base.Channel.getTrialsAsync();
        }
    }
}
