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
namespace Dataline.Elster.Anmeldung.UStA200501 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThrough()]
    [XmlType(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class usta_SteuerfallCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private AdresseCType beraterField;
        
        private MandantCType mandantField;
        
        private AdresseCType unternehmerField;
        
        private object itemField;
        
        /// <remarks/>
        public AdresseCType Berater {
            get {
                return beraterField;
            }
            set {
                beraterField = value;
                RaisePropertyChanged("Berater");
            }
        }
        
        /// <remarks/>
        public MandantCType Mandant {
            get {
                return mandantField;
            }
            set {
                mandantField = value;
                RaisePropertyChanged("Mandant");
            }
        }
        
        /// <remarks/>
        public AdresseCType Unternehmer {
            get {
                return unternehmerField;
            }
            set {
                unternehmerField = value;
                RaisePropertyChanged("Unternehmer");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Dauerfristverlaengerung", typeof(usta_DauerfristverlaengerungCType))]
        [System.Xml.Serialization.XmlElementAttribute("Umsatzsteuersondervorauszahlung", typeof(usta_UmsatzsteuersondervorauszahlungCType))]
        [System.Xml.Serialization.XmlElementAttribute("Umsatzsteuervoranmeldung", typeof(usta_UmsatzsteuervoranmeldungCType))]
        public object Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
                RaisePropertyChanged("Item");
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