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
namespace Dataline.Elster.Anmeldung.UStA201201 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThrough()]
    [XmlType(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class AdresseCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private string bezeichnungField;
        
        private string nameField;
        
        private string vornameField;
        
        private string namensvorsatzField;
        
        private string namenszusatzField;
        
        private string strField;
        
        private string hausnummerField;
        
        private string hNrZusatzField;
        
        private string anschriftenZusatzField;
        
        private string ortField;
        
        private string pLZField;
        
        private string auslandsPLZField;
        
        private string landField;
        
        private string postfachOrtField;
        
        private string postfachField;
        
        private string postfachPLZField;
        
        private string gKPLZField;
        
        private string telefonField;
        
        private string emailField;
        
        /// <remarks/>
        public string Bezeichnung {
            get {
                return bezeichnungField;
            }
            set {
                bezeichnungField = value;
                RaisePropertyChanged("Bezeichnung");
            }
        }
        
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
        public string Vorname {
            get {
                return vornameField;
            }
            set {
                vornameField = value;
                RaisePropertyChanged("Vorname");
            }
        }
        
        /// <remarks/>
        public string Namensvorsatz {
            get {
                return namensvorsatzField;
            }
            set {
                namensvorsatzField = value;
                RaisePropertyChanged("Namensvorsatz");
            }
        }
        
        /// <remarks/>
        public string Namenszusatz {
            get {
                return namenszusatzField;
            }
            set {
                namenszusatzField = value;
                RaisePropertyChanged("Namenszusatz");
            }
        }
        
        /// <remarks/>
        public string Str {
            get {
                return strField;
            }
            set {
                strField = value;
                RaisePropertyChanged("Str");
            }
        }
        
        /// <remarks/>
        public string Hausnummer {
            get {
                return hausnummerField;
            }
            set {
                hausnummerField = value;
                RaisePropertyChanged("Hausnummer");
            }
        }
        
        /// <remarks/>
        public string HNrZusatz {
            get {
                return hNrZusatzField;
            }
            set {
                hNrZusatzField = value;
                RaisePropertyChanged("HNrZusatz");
            }
        }
        
        /// <remarks/>
        public string AnschriftenZusatz {
            get {
                return anschriftenZusatzField;
            }
            set {
                anschriftenZusatzField = value;
                RaisePropertyChanged("AnschriftenZusatz");
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
        public string AuslandsPLZ {
            get {
                return auslandsPLZField;
            }
            set {
                auslandsPLZField = value;
                RaisePropertyChanged("AuslandsPLZ");
            }
        }
        
        /// <remarks/>
        public string Land {
            get {
                return landField;
            }
            set {
                landField = value;
                RaisePropertyChanged("Land");
            }
        }
        
        /// <remarks/>
        public string PostfachOrt {
            get {
                return postfachOrtField;
            }
            set {
                postfachOrtField = value;
                RaisePropertyChanged("PostfachOrt");
            }
        }
        
        /// <remarks/>
        public string Postfach {
            get {
                return postfachField;
            }
            set {
                postfachField = value;
                RaisePropertyChanged("Postfach");
            }
        }
        
        /// <remarks/>
        public string PostfachPLZ {
            get {
                return postfachPLZField;
            }
            set {
                postfachPLZField = value;
                RaisePropertyChanged("PostfachPLZ");
            }
        }
        
        /// <remarks/>
        public string GKPLZ {
            get {
                return gKPLZField;
            }
            set {
                gKPLZField = value;
                RaisePropertyChanged("GKPLZ");
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