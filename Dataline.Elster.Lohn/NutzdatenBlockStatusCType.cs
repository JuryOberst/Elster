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
namespace Dataline.Elster.Lohn
{
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class NutzdatenBlockStatusCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private NdBStatusCType ndBStatusField;
        
        private System.Collections.Generic.List<NdSFehlerCType> ndSFehlerField;
        
        private string nutzdatenTicketField;
        
        /// <remarks/>
        public NdBStatusCType NdBStatus {
            get {
                return ndBStatusField;
            }
            set {
                ndBStatusField = value;
                RaisePropertyChanged("NdBStatus");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NdSFehler")]
        public System.Collections.Generic.List<NdSFehlerCType> NdSFehler {
            get {
                return ndSFehlerField;
            }
            set {
                ndSFehlerField = value;
                RaisePropertyChanged("NdSFehler");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nutzdatenTicket {
            get {
                return nutzdatenTicketField;
            }
            set {
                nutzdatenTicketField = value;
                RaisePropertyChanged("nutzdatenTicket");
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