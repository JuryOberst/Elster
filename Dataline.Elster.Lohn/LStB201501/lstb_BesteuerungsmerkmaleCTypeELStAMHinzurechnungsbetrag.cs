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
namespace Dataline.Elster.Lohn.LStB201501 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.elsterlohn.de/2015-01/XMLSchema")]
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
                return this.jahrField;
            }
            set {
                this.jahrField = value;
                this.RaisePropertyChanged("jahr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string monat {
            get {
                return this.monatField;
            }
            set {
                this.monatField = value;
                this.RaisePropertyChanged("monat");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal woche {
            get {
                return this.wocheField;
            }
            set {
                this.wocheField = value;
                this.RaisePropertyChanged("woche");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool wocheSpecified {
            get {
                return this.wocheFieldSpecified;
            }
            set {
                this.wocheFieldSpecified = value;
                this.RaisePropertyChanged("wocheSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal tag {
            get {
                return this.tagField;
            }
            set {
                this.tagField = value;
                this.RaisePropertyChanged("tag");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tagSpecified {
            get {
                return this.tagFieldSpecified;
            }
            set {
                this.tagFieldSpecified = value;
                this.RaisePropertyChanged("tagSpecified");
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
}