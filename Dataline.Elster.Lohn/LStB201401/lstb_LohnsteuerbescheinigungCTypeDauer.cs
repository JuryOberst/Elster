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
namespace Dataline.Elster.Lohn.LStB201401 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.elsterlohn.de/2014-01/XMLSchema")]
    public partial class lstb_LohnsteuerbescheinigungCTypeDauer: object, System.ComponentModel.INotifyPropertyChanged {
        
        private string anfangField;
        
        private string endeField;
        
        private LStB201401.lstb_LohnsteuerbescheinigungJahrSType jahrField;
        
        /// <remarks/>
        public string Anfang {
            get {
                return this.anfangField;
            }
            set {
                this.anfangField = value;
                this.RaisePropertyChanged("Anfang");
            }
        }
        
        /// <remarks/>
        public string Ende {
            get {
                return this.endeField;
            }
            set {
                this.endeField = value;
                this.RaisePropertyChanged("Ende");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LStB201401.lstb_LohnsteuerbescheinigungJahrSType jahr {
            get {
                return this.jahrField;
            }
            set {
                this.jahrField = value;
                this.RaisePropertyChanged("jahr");
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