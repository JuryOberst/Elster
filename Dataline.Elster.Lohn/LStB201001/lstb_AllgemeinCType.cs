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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="lstb_AllgemeinCType", Namespace="http://www.elsterlohn.de/2010-01/XMLSchema")]
    public partial class lstb_AllgemeinCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private string eTINField;
        
        private string idNrField;
        
        private string ordnungsmerkmalField;
        
        private string aGSField;
        
        private LStB201001.lstb_PersonCType personField;
        
        /// <remarks/>
        public string ETIN {
            get {
                return eTINField;
            }
            set {
                eTINField = value;
                RaisePropertyChanged("ETIN");
            }
        }
        
        /// <remarks/>
        public string IdNr {
            get {
                return idNrField;
            }
            set {
                idNrField = value;
                RaisePropertyChanged("IdNr");
            }
        }
        
        /// <remarks/>
        public string Ordnungsmerkmal {
            get {
                return ordnungsmerkmalField;
            }
            set {
                ordnungsmerkmalField = value;
                RaisePropertyChanged("Ordnungsmerkmal");
            }
        }
        
        /// <remarks/>
        public string AGS {
            get {
                return aGSField;
            }
            set {
                aGSField = value;
                RaisePropertyChanged("AGS");
            }
        }
        
        /// <remarks/>
        public LStB201001.lstb_PersonCType Person {
            get {
                return personField;
            }
            set {
                personField = value;
                RaisePropertyChanged("Person");
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