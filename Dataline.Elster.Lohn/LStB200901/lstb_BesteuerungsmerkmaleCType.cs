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
                return this.steuerklasseField;
            }
            set {
                this.steuerklasseField = value;
                this.RaisePropertyChanged("Steuerklasse");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Kinder")]
        public System.Collections.Generic.List<LStB200901.lstb_BesteuerungsmerkmaleCTypeKinder> Kinder {
            get {
                return this.kinderField;
            }
            set {
                this.kinderField = value;
                this.RaisePropertyChanged("Kinder");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Kirchensteuerabzug")]
        public System.Collections.Generic.List<LStB200901.lstb_BesteuerungsmerkmaleCTypeKirchensteuerabzug> Kirchensteuerabzug {
            get {
                return this.kirchensteuerabzugField;
            }
            set {
                this.kirchensteuerabzugField = value;
                this.RaisePropertyChanged("Kirchensteuerabzug");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Steuerfreibetrag")]
        public System.Collections.Generic.List<LStB200901.lstb_SteuerfreibetragCType> Steuerfreibetrag {
            get {
                return this.steuerfreibetragField;
            }
            set {
                this.steuerfreibetragField = value;
                this.RaisePropertyChanged("Steuerfreibetrag");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Hinzurechnungsbetrag")]
        public System.Collections.Generic.List<LStB200901.lstb_SteuerfreibetragCType> Hinzurechnungsbetrag {
            get {
                return this.hinzurechnungsbetragField;
            }
            set {
                this.hinzurechnungsbetragField = value;
                this.RaisePropertyChanged("Hinzurechnungsbetrag");
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