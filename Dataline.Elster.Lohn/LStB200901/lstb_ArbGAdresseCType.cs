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
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elsterlohn.de/2009-01/XMLSchema")]
    public partial class lstb_ArbGAdresseCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private object[] itemsField;
        
        private LStB200901.ItemsChoiceType[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Anschriftenzusatz", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("AuslandsPLZ", typeof(LStB200901.AuslandsPLZCType))]
        [System.Xml.Serialization.XmlElementAttribute("GKPLZ", typeof(string), DataType="positiveInteger")]
        [System.Xml.Serialization.XmlElementAttribute("HNrZusatz", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Hausnummer", typeof(string), DataType="integer")]
        [System.Xml.Serialization.XmlElementAttribute("Ort", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("PLZ", typeof(string), DataType="positiveInteger")]
        [System.Xml.Serialization.XmlElementAttribute("Postfach", typeof(string), DataType="positiveInteger")]
        [System.Xml.Serialization.XmlElementAttribute("PostfachOrt", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("PostfachPLZ", typeof(string), DataType="positiveInteger")]
        [System.Xml.Serialization.XmlElementAttribute("Str", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public LStB200901.ItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
                this.RaisePropertyChanged("ItemsElementName");
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