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
namespace Dataline.Elster.Lohn.LStB201201 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.elsterlohn.de/2012-01/XMLSchema")]
    public partial class lstb_BesteuerungsmerkmaleCTypeELStAM: object, System.ComponentModel.INotifyPropertyChanged {
        
        private LStB201201.lstb_BesteuerungsmerkmaleCTypeELStAMSteuerklasse steuerklasseField;
        
        private LStB201201.lstb_BesteuerungsmerkmaleCTypeELStAMKinder kinderField;
        
        private LStB201201.lstb_BesteuerungsmerkmaleCTypeELStAMKirchensteuerabzug kirchensteuerabzugField;
        
        private object itemField;
        
        private System.DateTime gueltig_abField;
        
        /// <remarks/>
        public LStB201201.lstb_BesteuerungsmerkmaleCTypeELStAMSteuerklasse Steuerklasse {
            get {
                return steuerklasseField;
            }
            set {
                steuerklasseField = value;
                RaisePropertyChanged("Steuerklasse");
            }
        }
        
        /// <remarks/>
        public LStB201201.lstb_BesteuerungsmerkmaleCTypeELStAMKinder Kinder {
            get {
                return kinderField;
            }
            set {
                kinderField = value;
                RaisePropertyChanged("Kinder");
            }
        }
        
        /// <remarks/>
        public LStB201201.lstb_BesteuerungsmerkmaleCTypeELStAMKirchensteuerabzug Kirchensteuerabzug {
            get {
                return kirchensteuerabzugField;
            }
            set {
                kirchensteuerabzugField = value;
                RaisePropertyChanged("Kirchensteuerabzug");
            }
        }
        
        /// <remarks/>
        [XmlElement("Hinzurechnungsbetrag", typeof(LStB201201.lstb_BesteuerungsmerkmaleCTypeELStAMHinzurechnungsbetrag), IsNullable=true)]
        [XmlElement("Steuerfreibetrag", typeof(LStB201201.lstb_BesteuerungsmerkmaleCTypeELStAMSteuerfreibetrag), IsNullable=true)]
        public object Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
                RaisePropertyChanged("Item");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime gueltig_ab {
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