﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.34003
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Dieser Quellcode wurde automatisch generiert von xsd, Version=4.0.30319.33440.
// 
namespace Dataline.Elster.Lohn.Protocol4 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="DatenTeilStatusCType", Namespace="http://www.elsterfachmethodik.de/protokollverfahren/version4/XMLSchema")]
    public partial class DatenTeilStatusCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Collections.Generic.List<Protocol4.NutzdatenBlockStatusCType> nutzdatenblockField;
        
        private string transferTicketField;
        
        private Protocol4.DatenTeilStatusCTypeCode codeField;
        
        private string textField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Nutzdatenblock")]
        public System.Collections.Generic.List<Protocol4.NutzdatenBlockStatusCType> Nutzdatenblock {
            get {
                return nutzdatenblockField;
            }
            set {
                nutzdatenblockField = value;
                RaisePropertyChanged("Nutzdatenblock");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string transferTicket {
            get {
                return transferTicketField;
            }
            set {
                transferTicketField = value;
                RaisePropertyChanged("transferTicket");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Protocol4.DatenTeilStatusCTypeCode code {
            get {
                return codeField;
            }
            set {
                codeField = value;
                RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string text {
            get {
                return textField;
            }
            set {
                textField = value;
                RaisePropertyChanged("text");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}