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
namespace Dataline.Elster.Lohn.LStB200901 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elsterlohn.de/2009-01/XMLSchema")]
    public partial class lstb_PersonCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private LStB200901.lstb_PersonCTypeFamilienname familiennameField;
        
        private LStB200901.lstb_PersonCTypeGeburtsname geburtsnameField;
        
        private string geburtsdatumField;
        
        private LStB200901.lstb_AdresseCType adresseField;
        
        private LStB200901.lstb_PersonCTypeGeschlecht geschlechtField;
        
        /// <remarks/>
        public LStB200901.lstb_PersonCTypeFamilienname Familienname {
            get {
                return familiennameField;
            }
            set {
                familiennameField = value;
                RaisePropertyChanged("Familienname");
            }
        }
        
        /// <remarks/>
        public LStB200901.lstb_PersonCTypeGeburtsname Geburtsname {
            get {
                return geburtsnameField;
            }
            set {
                geburtsnameField = value;
                RaisePropertyChanged("Geburtsname");
            }
        }
        
        /// <remarks/>
        public string Geburtsdatum {
            get {
                return geburtsdatumField;
            }
            set {
                geburtsdatumField = value;
                RaisePropertyChanged("Geburtsdatum");
            }
        }
        
        /// <remarks/>
        public LStB200901.lstb_AdresseCType Adresse {
            get {
                return adresseField;
            }
            set {
                adresseField = value;
                RaisePropertyChanged("Adresse");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LStB200901.lstb_PersonCTypeGeschlecht geschlecht {
            get {
                return geschlechtField;
            }
            set {
                geschlechtField = value;
                RaisePropertyChanged("geschlecht");
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