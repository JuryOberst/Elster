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
    [XmlType(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class NdSFehlerCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private string ordnungsMerkmalField;
        
        private string fehlerNummerField;
        
        private string lfdNrField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ordnungsMerkmal {
            get {
                return ordnungsMerkmalField;
            }
            set {
                ordnungsMerkmalField = value;
                RaisePropertyChanged("ordnungsMerkmal");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string fehlerNummer {
            get {
                return fehlerNummerField;
            }
            set {
                fehlerNummerField = value;
                RaisePropertyChanged("fehlerNummer");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string lfdNr {
            get {
                return lfdNrField;
            }
            set {
                lfdNrField = value;
                RaisePropertyChanged("lfdNr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return valueField;
            }
            set {
                valueField = value;
                RaisePropertyChanged("Value");
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