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
namespace Dataline.Elster.Anmeldung.UStA200701 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThrough()]
    [XmlType(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class usta_DatenlieferantCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string strasseField;
        
        private string pLZField;
        
        private string ortField;
        
        private string telefonField;
        
        private string emailField;
        
        /// <remarks/>
        public string Name {
            get {
                return nameField;
            }
            set {
                nameField = value;
                RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        public string Strasse {
            get {
                return strasseField;
            }
            set {
                strasseField = value;
                RaisePropertyChanged("Strasse");
            }
        }
        
        /// <remarks/>
        public string PLZ {
            get {
                return pLZField;
            }
            set {
                pLZField = value;
                RaisePropertyChanged("PLZ");
            }
        }
        
        /// <remarks/>
        public string Ort {
            get {
                return ortField;
            }
            set {
                ortField = value;
                RaisePropertyChanged("Ort");
            }
        }
        
        /// <remarks/>
        public string Telefon {
            get {
                return telefonField;
            }
            set {
                telefonField = value;
                RaisePropertyChanged("Telefon");
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return emailField;
            }
            set {
                emailField = value;
                RaisePropertyChanged("Email");
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