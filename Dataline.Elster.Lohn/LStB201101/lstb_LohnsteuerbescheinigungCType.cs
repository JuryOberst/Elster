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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="lstb_LohnsteuerbescheinigungCType", Namespace="http://www.elsterlohn.de/2011-01/XMLSchema")]
    [System.Xml.Serialization.XmlRootAttribute("Lohnsteuerbescheinigung", Namespace="http://www.elsterlohn.de/2011-01/XMLSchema", IsNullable=false)]
    public partial class lstb_LohnsteuerbescheinigungCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private LStB201101.lstb_LohnsteuerbescheinigungCTypeDauer dauerField;
        
        private LStB201101.lstb_AllgemeinCType allgemeinField;
        
        private LStB201101.lstb_BesteuerungsmerkmaleCType besteuerungsmerkmaleField;
        
        private LStB201101.lstb_BesteuerungsgrundlagenCType besteuerungsgrundlagenField;
        
        private LStB201101.lstb_LohnsteuerbescheinigungVersionSType versionField;
        
        private LStB201101.lstb_LohnsteuerbescheinigungCTypeArt artField;
        
        /// <remarks/>
        public LStB201101.lstb_LohnsteuerbescheinigungCTypeDauer Dauer {
            get {
                return dauerField;
            }
            set {
                dauerField = value;
                RaisePropertyChanged("Dauer");
            }
        }
        
        /// <remarks/>
        public LStB201101.lstb_AllgemeinCType Allgemein {
            get {
                return allgemeinField;
            }
            set {
                allgemeinField = value;
                RaisePropertyChanged("Allgemein");
            }
        }
        
        /// <remarks/>
        public LStB201101.lstb_BesteuerungsmerkmaleCType Besteuerungsmerkmale {
            get {
                return besteuerungsmerkmaleField;
            }
            set {
                besteuerungsmerkmaleField = value;
                RaisePropertyChanged("Besteuerungsmerkmale");
            }
        }
        
        /// <remarks/>
        public LStB201101.lstb_BesteuerungsgrundlagenCType Besteuerungsgrundlagen {
            get {
                return besteuerungsgrundlagenField;
            }
            set {
                besteuerungsgrundlagenField = value;
                RaisePropertyChanged("Besteuerungsgrundlagen");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LStB201101.lstb_LohnsteuerbescheinigungVersionSType version {
            get {
                return versionField;
            }
            set {
                versionField = value;
                RaisePropertyChanged("version");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LStB201101.lstb_LohnsteuerbescheinigungCTypeArt art {
            get {
                return artField;
            }
            set {
                artField = value;
                RaisePropertyChanged("art");
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