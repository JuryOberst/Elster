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
namespace Dataline.Elster.Lohn.LStB201001 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="lstb_ArbeitgeberCType", Namespace="http://www.elsterlohn.de/2010-01/XMLSchema")]
    public partial class lstb_ArbeitgeberCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private string arbGNameField;
        
        private string arbGFANrField;
        
        private string arbGFANameField;
        
        private string arbGStNrField;
        
        private LStB201001.lstb_ArbGAdresseCType adresseField;
        
        /// <remarks/>
        public string ArbGName {
            get {
                return arbGNameField;
            }
            set {
                arbGNameField = value;
                RaisePropertyChanged("ArbGName");
            }
        }
        
        /// <remarks/>
        public string ArbGFANr {
            get {
                return arbGFANrField;
            }
            set {
                arbGFANrField = value;
                RaisePropertyChanged("ArbGFANr");
            }
        }
        
        /// <remarks/>
        public string ArbGFAName {
            get {
                return arbGFANameField;
            }
            set {
                arbGFANameField = value;
                RaisePropertyChanged("ArbGFAName");
            }
        }
        
        /// <remarks/>
        public string ArbGStNr {
            get {
                return arbGStNrField;
            }
            set {
                arbGStNrField = value;
                RaisePropertyChanged("ArbGStNr");
            }
        }
        
        /// <remarks/>
        public LStB201001.lstb_ArbGAdresseCType Adresse {
            get {
                return adresseField;
            }
            set {
                adresseField = value;
                RaisePropertyChanged("Adresse");
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