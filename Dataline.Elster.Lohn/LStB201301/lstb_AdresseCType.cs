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
namespace Dataline.Elster.Lohn.LStB201301 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="lstb_AdresseCType", Namespace="http://www.elsterlohn.de/2013-01/XMLSchema")]
    public partial class lstb_AdresseCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private string strField;
        
        private string hausnummerField;
        
        private string hNrZusatzField;
        
        private string anschriftenzusatzField;
        
        private string ortField;
        
        private object itemField;
        
        private string postfachOrtField;
        
        private string postfachField;
        
        private string postfachPLZField;
        
        /// <remarks/>
        public string Str {
            get {
                return strField;
            }
            set {
                strField = value;
                RaisePropertyChanged("Str");
            }
        }
        
        /// <remarks/>
        [XmlElement(DataType="integer")]
        public string Hausnummer {
            get {
                return hausnummerField;
            }
            set {
                hausnummerField = value;
                RaisePropertyChanged("Hausnummer");
            }
        }
        
        /// <remarks/>
        public string HNrZusatz {
            get {
                return hNrZusatzField;
            }
            set {
                hNrZusatzField = value;
                RaisePropertyChanged("HNrZusatz");
            }
        }
        
        /// <remarks/>
        public string Anschriftenzusatz {
            get {
                return anschriftenzusatzField;
            }
            set {
                anschriftenzusatzField = value;
                RaisePropertyChanged("Anschriftenzusatz");
            }
        }
        
        /// <remarks/>
        public string Ort {
            get {
                return ortField;
            }
            set {
                ortField = value;
                RaisePropertyChanged("Ort");
            }
        }
        
        /// <remarks/>
        [XmlElement("AuslandsPLZ", typeof(LStB201301.AuslandsPLZCType))]
        [XmlElement("PLZ", typeof(string))]
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
        public string PostfachOrt {
            get {
                return postfachOrtField;
            }
            set {
                postfachOrtField = value;
                RaisePropertyChanged("PostfachOrt");
            }
        }
        
        /// <remarks/>
        [XmlElement(DataType="positiveInteger")]
        public string Postfach {
            get {
                return postfachField;
            }
            set {
                postfachField = value;
                RaisePropertyChanged("Postfach");
            }
        }
        
        /// <remarks/>
        public string PostfachPLZ {
            get {
                return postfachPLZField;
            }
            set {
                postfachPLZField = value;
                RaisePropertyChanged("PostfachPLZ");
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