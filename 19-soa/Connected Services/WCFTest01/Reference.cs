﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace _19_soa.WCFTest01 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/_19_soa_webservice.Models")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PassWordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
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
        public string PassWord {
            get {
                return this.PassWordField;
            }
            set {
                if ((object.ReferenceEquals(this.PassWordField, value) != true)) {
                    this.PassWordField = value;
                    this.RaisePropertyChanged("PassWord");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFTest01.IServiceTest01")]
    public interface IServiceTest01 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTest01/DoWork", ReplyAction="http://tempuri.org/IServiceTest01/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTest01/DoWork", ReplyAction="http://tempuri.org/IServiceTest01/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTest01/Sum", ReplyAction="http://tempuri.org/IServiceTest01/SumResponse")]
        int Sum(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTest01/Sum", ReplyAction="http://tempuri.org/IServiceTest01/SumResponse")]
        System.Threading.Tasks.Task<int> SumAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTest01/GetUserById", ReplyAction="http://tempuri.org/IServiceTest01/GetUserByIdResponse")]
        _19_soa.WCFTest01.User GetUserById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTest01/GetUserById", ReplyAction="http://tempuri.org/IServiceTest01/GetUserByIdResponse")]
        System.Threading.Tasks.Task<_19_soa.WCFTest01.User> GetUserByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceTest01Channel : _19_soa.WCFTest01.IServiceTest01, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceTest01Client : System.ServiceModel.ClientBase<_19_soa.WCFTest01.IServiceTest01>, _19_soa.WCFTest01.IServiceTest01 {
        
        public ServiceTest01Client() {
        }
        
        public ServiceTest01Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceTest01Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceTest01Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceTest01Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public int Sum(int a, int b) {
            return base.Channel.Sum(a, b);
        }
        
        public System.Threading.Tasks.Task<int> SumAsync(int a, int b) {
            return base.Channel.SumAsync(a, b);
        }
        
        public _19_soa.WCFTest01.User GetUserById(int id) {
            return base.Channel.GetUserById(id);
        }
        
        public System.Threading.Tasks.Task<_19_soa.WCFTest01.User> GetUserByIdAsync(int id) {
            return base.Channel.GetUserByIdAsync(id);
        }
    }
}
