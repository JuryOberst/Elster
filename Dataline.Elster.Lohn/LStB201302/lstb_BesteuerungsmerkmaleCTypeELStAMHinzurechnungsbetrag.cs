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
namespace Dataline.Elster.Lohn.LStB201302 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.elsterlohn.de/2013-02/XMLSchema")]
    public partial class lstb_BesteuerungsmerkmaleCTypeELStAMHinzurechnungsbetrag: object, System.ComponentModel.INotifyPropertyChanged {
        
        private string jahrField;
        
        private string monatField;
        
        private decimal wocheField;
        
        private bool wocheFieldSpecified;
        
        private decimal tagField;
        
        private bool tagFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string jahr {
            get {
                return jahrField;
            }
            set {
                jahrField = value;
                RaisePropertyChanged("jahr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string monat {
            get {
                return monatField;
            }
            set {
                monatField = value;
                RaisePropertyChanged("monat");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal woche {
            get {
                return wocheField;
            }
            set {
                wocheField = value;
                RaisePropertyChanged("woche");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool wocheSpecified {
            get {
                return wocheFieldSpecified;
            }
            set {
                wocheFieldSpecified = value;
                RaisePropertyChanged("wocheSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal tag {
            get {
                return tagField;
            }
            set {
                tagField = value;
                RaisePropertyChanged("tag");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tagSpecified {
            get {
                return tagFieldSpecified;
            }
            set {
                tagFieldSpecified = value;
                RaisePropertyChanged("tagSpecified");
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