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
namespace Dataline.Elster.Lohn.LStB201101 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.elsterlohn.de/2011-01/XMLSchema")]
    public partial class lstb_BesteuerungsgrundlagenCTypeVBez: object, System.ComponentModel.INotifyPropertyChanged {
        
        private string jahrField;
        
        private allg_Datum_MMSType beginnField;
        
        private bool beginnFieldSpecified;
        
        private allg_Datum_MMSType endeField;
        
        private bool endeFieldSpecified;
        
        private decimal bmgfreibetragField;
        
        private decimal einmversbezugField;
        
        private bool einmversbezugFieldSpecified;
        
        private decimal valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="gYear")]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public allg_Datum_MMSType beginn {
            get {
                return this.beginnField;
            }
            set {
                this.beginnField = value;
                this.RaisePropertyChanged("beginn");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool beginnSpecified {
            get {
                return this.beginnFieldSpecified;
            }
            set {
                this.beginnFieldSpecified = value;
                this.RaisePropertyChanged("beginnSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public allg_Datum_MMSType ende {
            get {
                return this.endeField;
            }
            set {
                this.endeField = value;
                this.RaisePropertyChanged("ende");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endeSpecified {
            get {
                return this.endeFieldSpecified;
            }
            set {
                this.endeFieldSpecified = value;
                this.RaisePropertyChanged("endeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal bmgfreibetrag {
            get {
                return this.bmgfreibetragField;
            }
            set {
                this.bmgfreibetragField = value;
                this.RaisePropertyChanged("bmgfreibetrag");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal einmversbezug {
            get {
                return this.einmversbezugField;
            }
            set {
                this.einmversbezugField = value;
                this.RaisePropertyChanged("einmversbezug");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool einmversbezugSpecified {
            get {
                return this.einmversbezugFieldSpecified;
            }
            set {
                this.einmversbezugFieldSpecified = value;
                this.RaisePropertyChanged("einmversbezugSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
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