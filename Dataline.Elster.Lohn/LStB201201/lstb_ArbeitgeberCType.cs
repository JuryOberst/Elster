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
namespace Dataline.Elster.Lohn.LStB201201 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="lstb_ArbeitgeberCType", Namespace="http://www.elsterlohn.de/2012-01/XMLSchema")]
    public partial class lstb_ArbeitgeberCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private string arbGNameField;
        
        private string arbGFANrField;
        
        private string arbGFANameField;
        
        private string arbGStNrField;
        
        private LStB201201.lstb_ArbGAdresseCType adresseField;
        
        /// <remarks/>
        public string ArbGName {
            get {
                return this.arbGNameField;
            }
            set {
                this.arbGNameField = value;
                this.RaisePropertyChanged("ArbGName");
            }
        }
        
        /// <remarks/>
        public string ArbGFANr {
            get {
                return this.arbGFANrField;
            }
            set {
                this.arbGFANrField = value;
                this.RaisePropertyChanged("ArbGFANr");
            }
        }
        
        /// <remarks/>
        public string ArbGFAName {
            get {
                return this.arbGFANameField;
            }
            set {
                this.arbGFANameField = value;
                this.RaisePropertyChanged("ArbGFAName");
            }
        }
        
        /// <remarks/>
        public string ArbGStNr {
            get {
                return this.arbGStNrField;
            }
            set {
                this.arbGStNrField = value;
                this.RaisePropertyChanged("ArbGStNr");
            }
        }
        
        /// <remarks/>
        public LStB201201.lstb_ArbGAdresseCType Adresse {
            get {
                return this.adresseField;
            }
            set {
                this.adresseField = value;
                this.RaisePropertyChanged("Adresse");
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