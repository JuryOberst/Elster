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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="lstb_ArbGAdresseCType", Namespace="http://www.elsterlohn.de/2010-01/XMLSchema")]
    public partial class lstb_ArbGAdresseCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private object[] itemsField;
        
        private LStB201001.ItemsChoiceType[] itemsElementNameField;
        
        /// <remarks/>
        [XmlElement("Anschriftenzusatz", typeof(string))]
        [XmlElement("AuslandsPLZ", typeof(LStB201001.AuslandsPLZCType))]
        [XmlElement("GKPLZ", typeof(string))]
        [XmlElement("HNrZusatz", typeof(string))]
        [XmlElement("Hausnummer", typeof(string), DataType="integer")]
        [XmlElement("Ort", typeof(string))]
        [XmlElement("PLZ", typeof(string))]
        [XmlElement("Postfach", typeof(string), DataType="positiveInteger")]
        [XmlElement("PostfachOrt", typeof(string))]
        [XmlElement("PostfachPLZ", typeof(string))]
        [XmlElement("Str", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
                RaisePropertyChanged("Items");
            }
        }
        
        /// <remarks/>
        [XmlElement("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public LStB201001.ItemsChoiceType[] ItemsElementName {
            get {
                return itemsElementNameField;
            }
            set {
                itemsElementNameField = value;
                RaisePropertyChanged("ItemsElementName");
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