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
namespace Dataline.Elster.Lohn.LStB201101 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="lstb_AllgemeinCType", Namespace="http://www.elsterlohn.de/2011-01/XMLSchema")]
    public partial class lstb_AllgemeinCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private string eTINField;
        
        private string idNrField;
        
        private string ordnungsmerkmalField;
        
        private string aGSField;
        
        private LStB201101.lstb_PersonCType personField;
        
        /// <remarks/>
        public string ETIN {
            get {
                return this.eTINField;
            }
            set {
                this.eTINField = value;
                this.RaisePropertyChanged("ETIN");
            }
        }
        
        /// <remarks/>
        public string IdNr {
            get {
                return this.idNrField;
            }
            set {
                this.idNrField = value;
                this.RaisePropertyChanged("IdNr");
            }
        }
        
        /// <remarks/>
        public string Ordnungsmerkmal {
            get {
                return this.ordnungsmerkmalField;
            }
            set {
                this.ordnungsmerkmalField = value;
                this.RaisePropertyChanged("Ordnungsmerkmal");
            }
        }
        
        /// <remarks/>
        public string AGS {
            get {
                return this.aGSField;
            }
            set {
                this.aGSField = value;
                this.RaisePropertyChanged("AGS");
            }
        }
        
        /// <remarks/>
        public LStB201101.lstb_PersonCType Person {
            get {
                return this.personField;
            }
            set {
                this.personField = value;
                this.RaisePropertyChanged("Person");
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