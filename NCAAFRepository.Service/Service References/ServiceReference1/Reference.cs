﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NCAAFRepository.Service.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.INCAAFLatestRankings")]
    public interface INCAAFLatestRankings {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INCAAFLatestRankings/GetData", ReplyAction="http://tempuri.org/INCAAFLatestRankings/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INCAAFLatestRankings/GetData", ReplyAction="http://tempuri.org/INCAAFLatestRankings/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INCAAFLatestRankings/GetColleges", ReplyAction="http://tempuri.org/INCAAFLatestRankings/GetCollegesResponse")]
        System.Collections.Generic.List<NCAAFRankingViewer.SharedObjects.CollegeTeams> GetColleges();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INCAAFLatestRankings/GetColleges", ReplyAction="http://tempuri.org/INCAAFLatestRankings/GetCollegesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<NCAAFRankingViewer.SharedObjects.CollegeTeams>> GetCollegesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INCAAFLatestRankings/GetCollege", ReplyAction="http://tempuri.org/INCAAFLatestRankings/GetCollegeResponse")]
        NCAAFRankingViewer.SharedObjects.CollegeTeams GetCollege(string teamName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INCAAFLatestRankings/GetCollege", ReplyAction="http://tempuri.org/INCAAFLatestRankings/GetCollegeResponse")]
        System.Threading.Tasks.Task<NCAAFRankingViewer.SharedObjects.CollegeTeams> GetCollegeAsync(string teamName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INCAAFLatestRankings/AddCollege", ReplyAction="http://tempuri.org/INCAAFLatestRankings/AddCollegeResponse")]
        void AddCollege(NCAAFRankingViewer.SharedObjects.CollegeTeams newCollege);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INCAAFLatestRankings/AddCollege", ReplyAction="http://tempuri.org/INCAAFLatestRankings/AddCollegeResponse")]
        System.Threading.Tasks.Task AddCollegeAsync(NCAAFRankingViewer.SharedObjects.CollegeTeams newCollege);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INCAAFLatestRankings/UpdateCollege", ReplyAction="http://tempuri.org/INCAAFLatestRankings/UpdateCollegeResponse")]
        void UpdateCollege(string planetName, NCAAFRankingViewer.SharedObjects.CollegeTeams updatedCollege);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INCAAFLatestRankings/UpdateCollege", ReplyAction="http://tempuri.org/INCAAFLatestRankings/UpdateCollegeResponse")]
        System.Threading.Tasks.Task UpdateCollegeAsync(string planetName, NCAAFRankingViewer.SharedObjects.CollegeTeams updatedCollege);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INCAAFLatestRankings/DeleteCollege", ReplyAction="http://tempuri.org/INCAAFLatestRankings/DeleteCollegeResponse")]
        void DeleteCollege(string teamName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INCAAFLatestRankings/DeleteCollege", ReplyAction="http://tempuri.org/INCAAFLatestRankings/DeleteCollegeResponse")]
        System.Threading.Tasks.Task DeleteCollegeAsync(string teamName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INCAAFLatestRankings/UpdateColleges", ReplyAction="http://tempuri.org/INCAAFLatestRankings/UpdateCollegesResponse")]
        void UpdateColleges(System.Collections.Generic.List<NCAAFRankingViewer.SharedObjects.CollegeTeams> updatedColleges);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INCAAFLatestRankings/UpdateColleges", ReplyAction="http://tempuri.org/INCAAFLatestRankings/UpdateCollegesResponse")]
        System.Threading.Tasks.Task UpdateCollegesAsync(System.Collections.Generic.List<NCAAFRankingViewer.SharedObjects.CollegeTeams> updatedColleges);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INCAAFLatestRankingsChannel : NCAAFRepository.Service.ServiceReference1.INCAAFLatestRankings, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NCAAFLatestRankingsClient : System.ServiceModel.ClientBase<NCAAFRepository.Service.ServiceReference1.INCAAFLatestRankings>, NCAAFRepository.Service.ServiceReference1.INCAAFLatestRankings {
        
        public NCAAFLatestRankingsClient() {
        }
        
        public NCAAFLatestRankingsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NCAAFLatestRankingsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NCAAFLatestRankingsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NCAAFLatestRankingsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public System.Collections.Generic.List<NCAAFRankingViewer.SharedObjects.CollegeTeams> GetColleges() {
            return base.Channel.GetColleges();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<NCAAFRankingViewer.SharedObjects.CollegeTeams>> GetCollegesAsync() {
            return base.Channel.GetCollegesAsync();
        }
        
        public NCAAFRankingViewer.SharedObjects.CollegeTeams GetCollege(string teamName) {
            return base.Channel.GetCollege(teamName);
        }
        
        public System.Threading.Tasks.Task<NCAAFRankingViewer.SharedObjects.CollegeTeams> GetCollegeAsync(string teamName) {
            return base.Channel.GetCollegeAsync(teamName);
        }
        
        public void AddCollege(NCAAFRankingViewer.SharedObjects.CollegeTeams newCollege) {
            base.Channel.AddCollege(newCollege);
        }
        
        public System.Threading.Tasks.Task AddCollegeAsync(NCAAFRankingViewer.SharedObjects.CollegeTeams newCollege) {
            return base.Channel.AddCollegeAsync(newCollege);
        }
        
        public void UpdateCollege(string planetName, NCAAFRankingViewer.SharedObjects.CollegeTeams updatedCollege) {
            base.Channel.UpdateCollege(planetName, updatedCollege);
        }
        
        public System.Threading.Tasks.Task UpdateCollegeAsync(string planetName, NCAAFRankingViewer.SharedObjects.CollegeTeams updatedCollege) {
            return base.Channel.UpdateCollegeAsync(planetName, updatedCollege);
        }
        
        public void DeleteCollege(string teamName) {
            base.Channel.DeleteCollege(teamName);
        }
        
        public System.Threading.Tasks.Task DeleteCollegeAsync(string teamName) {
            return base.Channel.DeleteCollegeAsync(teamName);
        }
        
        public void UpdateColleges(System.Collections.Generic.List<NCAAFRankingViewer.SharedObjects.CollegeTeams> updatedColleges) {
            base.Channel.UpdateColleges(updatedColleges);
        }
        
        public System.Threading.Tasks.Task UpdateCollegesAsync(System.Collections.Generic.List<NCAAFRankingViewer.SharedObjects.CollegeTeams> updatedColleges) {
            return base.Channel.UpdateCollegesAsync(updatedColleges);
        }
    }
}
