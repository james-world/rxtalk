﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RxTalk.Gui.DictService {
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using System.Threading.Tasks;
    using System.Xml.Serialization;


    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(Namespace="http://services.aonaware.com/webservices/", ConfigurationName="DictService.DictServiceSoap")]
    public interface DictServiceSoap {
        
        [OperationContract(Action="http://services.aonaware.com/webservices/ServerInfo", ReplyAction="*")]
        [XmlSerializerFormat(SupportFaults=true)]
        string ServerInfo();
        
        [OperationContract(Action="http://services.aonaware.com/webservices/ServerInfo", ReplyAction="*")]
        Task<string> ServerInfoAsync();
        
        [OperationContract(Action="http://services.aonaware.com/webservices/DictionaryList", ReplyAction="*")]
        [XmlSerializerFormat(SupportFaults=true)]
        Dictionary[] DictionaryList();
        
        [OperationContract(Action="http://services.aonaware.com/webservices/DictionaryList", ReplyAction="*")]
        Task<Dictionary[]> DictionaryListAsync();
        
        [OperationContract(Action="http://services.aonaware.com/webservices/DictionaryListExtended", ReplyAction="*")]
        [XmlSerializerFormat(SupportFaults=true)]
        Dictionary[] DictionaryListExtended();
        
        [OperationContract(Action="http://services.aonaware.com/webservices/DictionaryListExtended", ReplyAction="*")]
        Task<Dictionary[]> DictionaryListExtendedAsync();
        
        [OperationContract(Action="http://services.aonaware.com/webservices/DictionaryInfo", ReplyAction="*")]
        [XmlSerializerFormat(SupportFaults=true)]
        string DictionaryInfo(string dictId);
        
        [OperationContract(Action="http://services.aonaware.com/webservices/DictionaryInfo", ReplyAction="*")]
        Task<string> DictionaryInfoAsync(string dictId);
        
        [OperationContract(Action="http://services.aonaware.com/webservices/Define", ReplyAction="*")]
        [XmlSerializerFormat(SupportFaults=true)]
        WordDefinition Define(string word);
        
        [OperationContract(Action="http://services.aonaware.com/webservices/Define", ReplyAction="*")]
        Task<WordDefinition> DefineAsync(string word);
        
        [OperationContract(Action="http://services.aonaware.com/webservices/DefineInDict", ReplyAction="*")]
        [XmlSerializerFormat(SupportFaults=true)]
        WordDefinition DefineInDict(string dictId, string word);
        
        [OperationContract(Action="http://services.aonaware.com/webservices/DefineInDict", ReplyAction="*")]
        Task<WordDefinition> DefineInDictAsync(string dictId, string word);
        
        [OperationContract(Action="http://services.aonaware.com/webservices/StrategyList", ReplyAction="*")]
        [XmlSerializerFormat(SupportFaults=true)]
        Strategy[] StrategyList();
        
        [OperationContract(Action="http://services.aonaware.com/webservices/StrategyList", ReplyAction="*")]
        Task<Strategy[]> StrategyListAsync();
        
        [OperationContract(Action="http://services.aonaware.com/webservices/Match", ReplyAction="*")]
        [XmlSerializerFormat(SupportFaults=true)]
        DictionaryWord[] Match(string word, string strategy);
        
        [OperationContract(Action="http://services.aonaware.com/webservices/Match", ReplyAction="*")]
        Task<DictionaryWord[]> MatchAsync(string word, string strategy);
        
        [OperationContract(Action="http://services.aonaware.com/webservices/MatchInDict", ReplyAction="*")]
        [XmlSerializerFormat(SupportFaults=true)]
        DictionaryWord[] MatchInDict(string dictId, string word, string strategy);
        
        [OperationContract(Action="http://services.aonaware.com/webservices/MatchInDict", ReplyAction="*")]
        Task<DictionaryWord[]> MatchInDictAsync(string dictId, string word, string strategy);
    }
    
    /// <remarks/>
    [GeneratedCode("System.Xml", "4.0.30319.34230")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace="http://services.aonaware.com/webservices/")]
    public partial class Dictionary : object, INotifyPropertyChanged {
        
        private string idField;
        
        private string nameField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=1)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCode("System.Xml", "4.0.30319.34230")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace="http://services.aonaware.com/webservices/")]
    public partial class DictionaryWord : object, INotifyPropertyChanged {
        
        private string dictionaryIdField;
        
        private string wordField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public string DictionaryId {
            get {
                return this.dictionaryIdField;
            }
            set {
                this.dictionaryIdField = value;
                this.RaisePropertyChanged("DictionaryId");
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=1)]
        public string Word {
            get {
                return this.wordField;
            }
            set {
                this.wordField = value;
                this.RaisePropertyChanged("Word");
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCode("System.Xml", "4.0.30319.34230")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace="http://services.aonaware.com/webservices/")]
    public partial class Strategy : object, INotifyPropertyChanged {
        
        private string idField;
        
        private string descriptionField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=1)]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("Description");
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCode("System.Xml", "4.0.30319.34230")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace="http://services.aonaware.com/webservices/")]
    public partial class Definition : object, INotifyPropertyChanged {
        
        private string wordField;
        
        private Dictionary dictionaryField;
        
        private string wordDefinitionField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public string Word {
            get {
                return this.wordField;
            }
            set {
                this.wordField = value;
                this.RaisePropertyChanged("Word");
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=1)]
        public Dictionary Dictionary {
            get {
                return this.dictionaryField;
            }
            set {
                this.dictionaryField = value;
                this.RaisePropertyChanged("Dictionary");
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=2)]
        public string WordDefinition {
            get {
                return this.wordDefinitionField;
            }
            set {
                this.wordDefinitionField = value;
                this.RaisePropertyChanged("WordDefinition");
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCode("System.Xml", "4.0.30319.34230")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace="http://services.aonaware.com/webservices/")]
    public partial class WordDefinition : object, INotifyPropertyChanged {
        
        private string wordField;
        
        private Definition[] definitionsField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public string Word {
            get {
                return this.wordField;
            }
            set {
                this.wordField = value;
                this.RaisePropertyChanged("Word");
            }
        }
        
        /// <remarks/>
        [XmlArray(Order=1)]
        public Definition[] Definitions {
            get {
                return this.definitionsField;
            }
            set {
                this.definitionsField = value;
                this.RaisePropertyChanged("Definitions");
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public interface DictServiceSoapChannel : DictServiceSoap, IClientChannel {
    }
    
    [DebuggerStepThrough()]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class DictServiceSoapClient : ClientBase<DictServiceSoap>, DictServiceSoap {
        
        public DictServiceSoapClient() {
        }
        
        public DictServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DictServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DictServiceSoapClient(string endpointConfigurationName, EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DictServiceSoapClient(Binding binding, EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ServerInfo() {
            return base.Channel.ServerInfo();
        }
        
        public Task<string> ServerInfoAsync() {
            return base.Channel.ServerInfoAsync();
        }
        
        public Dictionary[] DictionaryList() {
            return base.Channel.DictionaryList();
        }
        
        public Task<Dictionary[]> DictionaryListAsync() {
            return base.Channel.DictionaryListAsync();
        }
        
        public Dictionary[] DictionaryListExtended() {
            return base.Channel.DictionaryListExtended();
        }
        
        public Task<Dictionary[]> DictionaryListExtendedAsync() {
            return base.Channel.DictionaryListExtendedAsync();
        }
        
        public string DictionaryInfo(string dictId) {
            return base.Channel.DictionaryInfo(dictId);
        }
        
        public Task<string> DictionaryInfoAsync(string dictId) {
            return base.Channel.DictionaryInfoAsync(dictId);
        }
        
        public WordDefinition Define(string word) {
            return base.Channel.Define(word);
        }
        
        public Task<WordDefinition> DefineAsync(string word) {
            return base.Channel.DefineAsync(word);
        }
        
        public WordDefinition DefineInDict(string dictId, string word) {
            return base.Channel.DefineInDict(dictId, word);
        }
        
        public Task<WordDefinition> DefineInDictAsync(string dictId, string word) {
            return base.Channel.DefineInDictAsync(dictId, word);
        }
        
        public Strategy[] StrategyList() {
            return base.Channel.StrategyList();
        }
        
        public Task<Strategy[]> StrategyListAsync() {
            return base.Channel.StrategyListAsync();
        }
        
        public DictionaryWord[] Match(string word, string strategy) {
            return base.Channel.Match(word, strategy);
        }
        
        public Task<DictionaryWord[]> MatchAsync(string word, string strategy) {
            return base.Channel.MatchAsync(word, strategy);
        }
        
        public DictionaryWord[] MatchInDict(string dictId, string word, string strategy) {
            return base.Channel.MatchInDict(dictId, word, strategy);
        }
        
        public Task<DictionaryWord[]> MatchInDictAsync(string dictId, string word, string strategy) {
            return base.Channel.MatchInDictAsync(dictId, word, strategy);
        }
    }
}
