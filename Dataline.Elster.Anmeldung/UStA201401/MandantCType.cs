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
namespace Dataline.Elster.Anmeldung.UStA201401 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThrough()]
    [XmlType(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class MandantCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string vornameField;
        
        private string mandantenNrField;
        
        private string bearbeiterkennzeichenField;
        
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
        public string MandantenNr {
            get {
                return mandantenNrField;
            }
            set {
                mandantenNrField = value;
                RaisePropertyChanged("MandantenNr");
            }
        }
        
        /// <remarks/>
        public string Bearbeiterkennzeichen {
            get {
                return bearbeiterkennzeichenField;
            }
            set {
                bearbeiterkennzeichenField = value;
                RaisePropertyChanged("Bearbeiterkennzeichen");
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