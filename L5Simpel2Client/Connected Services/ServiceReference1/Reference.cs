﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace L5Simpel2Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IServices")]
    public interface IServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/Login", ReplyAction="http://tempuri.org/IServices/LoginResponse")]
        bool Login(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/Login", ReplyAction="http://tempuri.org/IServices/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/Register", ReplyAction="http://tempuri.org/IServices/RegisterResponse")]
        string Register(string naam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/Register", ReplyAction="http://tempuri.org/IServices/RegisterResponse")]
        System.Threading.Tasks.Task<string> RegisterAsync(string naam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/GetProjecten", ReplyAction="http://tempuri.org/IServices/GetProjectenResponse")]
        string GetProjecten();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/GetProjecten", ReplyAction="http://tempuri.org/IServices/GetProjectenResponse")]
        System.Threading.Tasks.Task<string> GetProjectenAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/GetProjectInfo", ReplyAction="http://tempuri.org/IServices/GetProjectInfoResponse")]
        string GetProjectInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/GetProjectInfo", ReplyAction="http://tempuri.org/IServices/GetProjectInfoResponse")]
        System.Threading.Tasks.Task<string> GetProjectInfoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/GetMedewerker", ReplyAction="http://tempuri.org/IServices/GetMedewerkerResponse")]
        string GetMedewerker(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/GetMedewerker", ReplyAction="http://tempuri.org/IServices/GetMedewerkerResponse")]
        System.Threading.Tasks.Task<string> GetMedewerkerAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/GetWerkzaamheden", ReplyAction="http://tempuri.org/IServices/GetWerkzaamhedenResponse")]
        string GetWerkzaamheden(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/GetWerkzaamheden", ReplyAction="http://tempuri.org/IServices/GetWerkzaamhedenResponse")]
        System.Threading.Tasks.Task<string> GetWerkzaamhedenAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/RegistreerWerkzaamheid", ReplyAction="http://tempuri.org/IServices/RegistreerWerkzaamheidResponse")]
        string RegistreerWerkzaamheid(int uren, int medewerkerid, string werkzaamheid, string date, string naam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/RegistreerWerkzaamheid", ReplyAction="http://tempuri.org/IServices/RegistreerWerkzaamheidResponse")]
        System.Threading.Tasks.Task<string> RegistreerWerkzaamheidAsync(int uren, int medewerkerid, string werkzaamheid, string date, string naam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/EditWerkzaamheid", ReplyAction="http://tempuri.org/IServices/EditWerkzaamheidResponse")]
        string EditWerkzaamheid(int id, int uren, int medewerkerid, string werkzaamheid, string date, string naam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/EditWerkzaamheid", ReplyAction="http://tempuri.org/IServices/EditWerkzaamheidResponse")]
        System.Threading.Tasks.Task<string> EditWerkzaamheidAsync(int id, int uren, int medewerkerid, string werkzaamheid, string date, string naam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/DeleteWerkzaamheid", ReplyAction="http://tempuri.org/IServices/DeleteWerkzaamheidResponse")]
        string DeleteWerkzaamheid(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/DeleteWerkzaamheid", ReplyAction="http://tempuri.org/IServices/DeleteWerkzaamheidResponse")]
        System.Threading.Tasks.Task<string> DeleteWerkzaamheidAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicesChannel : L5Simpel2Client.ServiceReference1.IServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicesClient : System.ServiceModel.ClientBase<L5Simpel2Client.ServiceReference1.IServices>, L5Simpel2Client.ServiceReference1.IServices {
        
        public ServicesClient() {
        }
        
        public ServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Login(string name, string password) {
            return base.Channel.Login(name, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string name, string password) {
            return base.Channel.LoginAsync(name, password);
        }
        
        public string Register(string naam) {
            return base.Channel.Register(naam);
        }
        
        public System.Threading.Tasks.Task<string> RegisterAsync(string naam) {
            return base.Channel.RegisterAsync(naam);
        }
        
        public string GetProjecten() {
            return base.Channel.GetProjecten();
        }
        
        public System.Threading.Tasks.Task<string> GetProjectenAsync() {
            return base.Channel.GetProjectenAsync();
        }
        
        public string GetProjectInfo() {
            return base.Channel.GetProjectInfo();
        }
        
        public System.Threading.Tasks.Task<string> GetProjectInfoAsync() {
            return base.Channel.GetProjectInfoAsync();
        }
        
        public string GetMedewerker(int id) {
            return base.Channel.GetMedewerker(id);
        }
        
        public System.Threading.Tasks.Task<string> GetMedewerkerAsync(int id) {
            return base.Channel.GetMedewerkerAsync(id);
        }
        
        public string GetWerkzaamheden(int id) {
            return base.Channel.GetWerkzaamheden(id);
        }
        
        public System.Threading.Tasks.Task<string> GetWerkzaamhedenAsync(int id) {
            return base.Channel.GetWerkzaamhedenAsync(id);
        }
        
        public string RegistreerWerkzaamheid(int uren, int medewerkerid, string werkzaamheid, string date, string naam) {
            return base.Channel.RegistreerWerkzaamheid(uren, medewerkerid, werkzaamheid, date, naam);
        }
        
        public System.Threading.Tasks.Task<string> RegistreerWerkzaamheidAsync(int uren, int medewerkerid, string werkzaamheid, string date, string naam) {
            return base.Channel.RegistreerWerkzaamheidAsync(uren, medewerkerid, werkzaamheid, date, naam);
        }
        
        public string EditWerkzaamheid(int id, int uren, int medewerkerid, string werkzaamheid, string date, string naam) {
            return base.Channel.EditWerkzaamheid(id, uren, medewerkerid, werkzaamheid, date, naam);
        }
        
        public System.Threading.Tasks.Task<string> EditWerkzaamheidAsync(int id, int uren, int medewerkerid, string werkzaamheid, string date, string naam) {
            return base.Channel.EditWerkzaamheidAsync(id, uren, medewerkerid, werkzaamheid, date, naam);
        }
        
        public string DeleteWerkzaamheid(int id) {
            return base.Channel.DeleteWerkzaamheid(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteWerkzaamheidAsync(int id) {
            return base.Channel.DeleteWerkzaamheidAsync(id);
        }
    }
}