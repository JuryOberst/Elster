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
namespace Dataline.Elster.Anmeldung.LStA200401 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThrough()]
    [XmlType(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class AnmeldungssteuernCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private lstaDatenlieferantType datenLieferantField;
        
        private string erstellungsdatumField;
        
        private lstaSteuerfallType steuerfallField;
        
        private string artField;
        
        private AnmeldungssteuernCTypeVersion versionField;
        
        public AnmeldungssteuernCType() {
            artField = "LStA";
        }
        
        /// <remarks/>
        public lstaDatenlieferantType DatenLieferant {
            get {
                return datenLieferantField;
            }
            set {
                datenLieferantField = value;
                RaisePropertyChanged("DatenLieferant");
            }
        }
        
        /// <remarks/>
        public string Erstellungsdatum {
            get {
                return erstellungsdatumField;
            }
            set {
                erstellungsdatumField = value;
                RaisePropertyChanged("Erstellungsdatum");
            }
        }
        
        /// <remarks/>
        public lstaSteuerfallType Steuerfall {
            get {
                return steuerfallField;
            }
            set {
                steuerfallField = value;
                RaisePropertyChanged("Steuerfall");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string art {
            get {
                return artField;
            }
            set {
                artField = value;
                RaisePropertyChanged("art");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AnmeldungssteuernCTypeVersion version {
            get {
                return versionField;
            }
            set {
                versionField = value;
                RaisePropertyChanged("version");
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