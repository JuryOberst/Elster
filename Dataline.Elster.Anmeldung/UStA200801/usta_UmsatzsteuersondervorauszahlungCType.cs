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
namespace Dataline.Elster.Anmeldung.UStA200801 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThrough()]
    [XmlType(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class usta_UmsatzsteuersondervorauszahlungCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private usta_JahrSType jahrField;
        
        private string steuernummerField;
        
        private string kz09Field;
        
        private usta_Kz10SType kz10Field;
        
        private bool kz10FieldSpecified;
        
        private usta_Kz26SType kz26Field;
        
        private bool kz26FieldSpecified;
        
        private usta_Kz29SType kz29Field;
        
        private bool kz29FieldSpecified;
        
        private string kz38Field;
        
        /// <remarks/>
        public usta_JahrSType Jahr {
            get {
                return jahrField;
            }
            set {
                jahrField = value;
                RaisePropertyChanged("Jahr");
            }
        }
        
        /// <remarks/>
        public string Steuernummer {
            get {
                return steuernummerField;
            }
            set {
                steuernummerField = value;
                RaisePropertyChanged("Steuernummer");
            }
        }
        
        /// <remarks/>
        public string Kz09 {
            get {
                return kz09Field;
            }
            set {
                kz09Field = value;
                RaisePropertyChanged("Kz09");
            }
        }
        
        /// <remarks/>
        public usta_Kz10SType Kz10 {
            get {
                return kz10Field;
            }
            set {
                kz10Field = value;
                RaisePropertyChanged("Kz10");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Kz10Specified {
            get {
                return kz10FieldSpecified;
            }
            set {
                kz10FieldSpecified = value;
                RaisePropertyChanged("Kz10Specified");
            }
        }
        
        /// <remarks/>
        public usta_Kz26SType Kz26 {
            get {
                return kz26Field;
            }
            set {
                kz26Field = value;
                RaisePropertyChanged("Kz26");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Kz26Specified {
            get {
                return kz26FieldSpecified;
            }
            set {
                kz26FieldSpecified = value;
                RaisePropertyChanged("Kz26Specified");
            }
        }
        
        /// <remarks/>
        public usta_Kz29SType Kz29 {
            get {
                return kz29Field;
            }
            set {
                kz29Field = value;
                RaisePropertyChanged("Kz29");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Kz29Specified {
            get {
                return kz29FieldSpecified;
            }
            set {
                kz29FieldSpecified = value;
                RaisePropertyChanged("Kz29Specified");
            }
        }
        
        /// <remarks/>
        public string Kz38 {
            get {
                return kz38Field;
            }
            set {
                kz38Field = value;
                RaisePropertyChanged("Kz38");
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