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
namespace Dataline.Elster.Lohn.LStB201301 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="lstb_PersonCType", Namespace="http://www.elsterlohn.de/2013-01/XMLSchema")]
    public partial class lstb_PersonCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private LStB201301.lstb_PersonCTypeFamilienname familiennameField;
        
        private LStB201301.lstb_PersonCTypeGeburtsname geburtsnameField;
        
        private string geburtsdatumField;
        
        private LStB201301.lstb_AdresseCType adresseField;
        
        private LStB201301.lstb_PersonCTypeGeschlecht geschlechtField;
        
        /// <remarks/>
        public LStB201301.lstb_PersonCTypeFamilienname Familienname {
            get {
                return this.familiennameField;
            }
            set {
                this.familiennameField = value;
                this.RaisePropertyChanged("Familienname");
            }
        }
        
        /// <remarks/>
        public LStB201301.lstb_PersonCTypeGeburtsname Geburtsname {
            get {
                return this.geburtsnameField;
            }
            set {
                this.geburtsnameField = value;
                this.RaisePropertyChanged("Geburtsname");
            }
        }
        
        /// <remarks/>
        public string Geburtsdatum {
            get {
                return this.geburtsdatumField;
            }
            set {
                this.geburtsdatumField = value;
                this.RaisePropertyChanged("Geburtsdatum");
            }
        }
        
        /// <remarks/>
        public LStB201301.lstb_AdresseCType Adresse {
            get {
                return this.adresseField;
            }
            set {
                this.adresseField = value;
                this.RaisePropertyChanged("Adresse");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LStB201301.lstb_PersonCTypeGeschlecht geschlecht {
            get {
                return this.geschlechtField;
            }
            set {
                this.geschlechtField = value;
                this.RaisePropertyChanged("geschlecht");
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