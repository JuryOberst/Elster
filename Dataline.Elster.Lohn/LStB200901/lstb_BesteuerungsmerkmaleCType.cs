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
    public partial class lstb_BesteuerungsmerkmaleCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Collections.Generic.List<LStB200901.lstb_BesteuerungsmerkmaleCTypeSteuerklasse> steuerklasseField;
        
        private System.Collections.Generic.List<LStB200901.lstb_BesteuerungsmerkmaleCTypeKinder> kinderField;
        
        private System.Collections.Generic.List<LStB200901.lstb_BesteuerungsmerkmaleCTypeKirchensteuerabzug> kirchensteuerabzugField;
        
        private System.Collections.Generic.List<LStB200901.lstb_SteuerfreibetragCType> steuerfreibetragField;
        
        private System.Collections.Generic.List<LStB200901.lstb_SteuerfreibetragCType> hinzurechnungsbetragField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Steuerklasse")]
        public System.Collections.Generic.List<LStB200901.lstb_BesteuerungsmerkmaleCTypeSteuerklasse> Steuerklasse {
            get {
                return steuerklasseField;
            }
            set {
                steuerklasseField = value;
                RaisePropertyChanged("Steuerklasse");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Kinder")]
        public System.Collections.Generic.List<LStB200901.lstb_BesteuerungsmerkmaleCTypeKinder> Kinder {
            get {
                return kinderField;
            }
            set {
                kinderField = value;
                RaisePropertyChanged("Kinder");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Kirchensteuerabzug")]
        public System.Collections.Generic.List<LStB200901.lstb_BesteuerungsmerkmaleCTypeKirchensteuerabzug> Kirchensteuerabzug {
            get {
                return kirchensteuerabzugField;
            }
            set {
                kirchensteuerabzugField = value;
                RaisePropertyChanged("Kirchensteuerabzug");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Steuerfreibetrag")]
        public System.Collections.Generic.List<LStB200901.lstb_SteuerfreibetragCType> Steuerfreibetrag {
            get {
                return steuerfreibetragField;
            }
            set {
                steuerfreibetragField = value;
                RaisePropertyChanged("Steuerfreibetrag");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Hinzurechnungsbetrag")]
        public System.Collections.Generic.List<LStB200901.lstb_SteuerfreibetragCType> Hinzurechnungsbetrag {
            get {
                return hinzurechnungsbetragField;
            }
            set {
                hinzurechnungsbetragField = value;
                RaisePropertyChanged("Hinzurechnungsbetrag");
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