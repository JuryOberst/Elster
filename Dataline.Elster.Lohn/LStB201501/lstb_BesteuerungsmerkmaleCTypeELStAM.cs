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
namespace Dataline.Elster.Lohn.LStB201501 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.elsterlohn.de/2015-01/XMLSchema")]
    public partial class lstb_BesteuerungsmerkmaleCTypeELStAM: object, System.ComponentModel.INotifyPropertyChanged {
        
        private lstb_BesteuerungsmerkmaleCTypeELStAMSteuerklasse steuerklasseField;
        
        private lstb_BesteuerungsmerkmaleCTypeELStAMKinder kinderField;
        
        private lstb_BesteuerungsmerkmaleCTypeELStAMKirchensteuerabzug kirchensteuerabzugField;
        
        private lstb_BesteuerungsmerkmaleCTypeELStAMSteuerfreibetrag steuerfreibetragField;
        
        private lstb_BesteuerungsmerkmaleCTypeELStAMHinzurechnungsbetrag hinzurechnungsbetragField;
        
        private System.DateTime gueltig_abField;
        
        /// <remarks/>
        public lstb_BesteuerungsmerkmaleCTypeELStAMSteuerklasse Steuerklasse {
            get {
                return this.steuerklasseField;
            }
            set {
                this.steuerklasseField = value;
                this.RaisePropertyChanged("Steuerklasse");
            }
        }
        
        /// <remarks/>
        public lstb_BesteuerungsmerkmaleCTypeELStAMKinder Kinder {
            get {
                return this.kinderField;
            }
            set {
                this.kinderField = value;
                this.RaisePropertyChanged("Kinder");
            }
        }
        
        /// <remarks/>
        public lstb_BesteuerungsmerkmaleCTypeELStAMKirchensteuerabzug Kirchensteuerabzug {
            get {
                return this.kirchensteuerabzugField;
            }
            set {
                this.kirchensteuerabzugField = value;
                this.RaisePropertyChanged("Kirchensteuerabzug");
            }
        }
        
        /// <remarks/>
        public lstb_BesteuerungsmerkmaleCTypeELStAMSteuerfreibetrag Steuerfreibetrag {
            get {
                return this.steuerfreibetragField;
            }
            set {
                this.steuerfreibetragField = value;
                this.RaisePropertyChanged("Steuerfreibetrag");
            }
        }
        
        /// <remarks/>
        public lstb_BesteuerungsmerkmaleCTypeELStAMHinzurechnungsbetrag Hinzurechnungsbetrag {
            get {
                return this.hinzurechnungsbetragField;
            }
            set {
                this.hinzurechnungsbetragField = value;
                this.RaisePropertyChanged("Hinzurechnungsbetrag");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime gueltig_ab {
            get {
                return this.gueltig_abField;
            }
            set {
                this.gueltig_abField = value;
                this.RaisePropertyChanged("gueltig_ab");
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