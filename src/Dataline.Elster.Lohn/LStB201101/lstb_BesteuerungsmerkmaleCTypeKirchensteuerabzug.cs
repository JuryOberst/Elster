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
    [XmlType(AnonymousType=true, Namespace="http://www.elsterlohn.de/2011-01/XMLSchema")]
    public partial class lstb_BesteuerungsmerkmaleCTypeKirchensteuerabzug: object, System.ComponentModel.INotifyPropertyChanged {
        
        private allg_Konfession_ab2008SType konfessionField;
        
        private allg_Konfession_ab2008SType ehegkonfessionField;
        
        private bool ehegkonfessionFieldSpecified;
        
        private string gueltig_abField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public allg_Konfession_ab2008SType konfession {
            get {
                return konfessionField;
            }
            set {
                konfessionField = value;
                RaisePropertyChanged("konfession");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public allg_Konfession_ab2008SType ehegkonfession {
            get {
                return ehegkonfessionField;
            }
            set {
                ehegkonfessionField = value;
                RaisePropertyChanged("ehegkonfession");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ehegkonfessionSpecified {
            get {
                return ehegkonfessionFieldSpecified;
            }
            set {
                ehegkonfessionFieldSpecified = value;
                RaisePropertyChanged("ehegkonfessionSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string gueltig_ab {
            get {
                return gueltig_abField;
            }
            set {
                gueltig_abField = value;
                RaisePropertyChanged("gueltig_ab");
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