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
namespace Dataline.Elster.Lohn.LStB201302 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="lstb_LohnsteuerbescheinigungCType", Namespace="http://www.elsterlohn.de/2013-02/XMLSchema")]
    [System.Xml.Serialization.XmlRootAttribute("Lohnsteuerbescheinigung", Namespace="http://www.elsterlohn.de/2013-02/XMLSchema", IsNullable=false)]
    public partial class lstb_LohnsteuerbescheinigungCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private LStB201302.lstb_LohnsteuerbescheinigungCTypeDauer dauerField;
        
        private LStB201302.lstb_AllgemeinCType allgemeinField;
        
        private System.Collections.Generic.List<LStB201302.lstb_BesteuerungsmerkmaleCTypeELStAM> besteuerungsmerkmaleField;
        
        private LStB201302.lstb_BesteuerungsgrundlagenCType besteuerungsgrundlagenField;
        
        private LStB201302.lstb_LohnsteuerbescheinigungVersionSType versionField;
        
        private LStB201302.lstb_LohnsteuerbescheinigungCTypeArt artField;
        
        /// <remarks/>
        public LStB201302.lstb_LohnsteuerbescheinigungCTypeDauer Dauer {
            get {
                return this.dauerField;
            }
            set {
                this.dauerField = value;
                this.RaisePropertyChanged("Dauer");
            }
        }
        
        /// <remarks/>
        public LStB201302.lstb_AllgemeinCType Allgemein {
            get {
                return this.allgemeinField;
            }
            set {
                this.allgemeinField = value;
                this.RaisePropertyChanged("Allgemein");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ELStAM", IsNullable=false)]
        public System.Collections.Generic.List<LStB201302.lstb_BesteuerungsmerkmaleCTypeELStAM> Besteuerungsmerkmale {
            get {
                return this.besteuerungsmerkmaleField;
            }
            set {
                this.besteuerungsmerkmaleField = value;
                this.RaisePropertyChanged("Besteuerungsmerkmale");
            }
        }
        
        /// <remarks/>
        public LStB201302.lstb_BesteuerungsgrundlagenCType Besteuerungsgrundlagen {
            get {
                return this.besteuerungsgrundlagenField;
            }
            set {
                this.besteuerungsgrundlagenField = value;
                this.RaisePropertyChanged("Besteuerungsgrundlagen");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LStB201302.lstb_LohnsteuerbescheinigungVersionSType version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
                this.RaisePropertyChanged("version");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LStB201302.lstb_LohnsteuerbescheinigungCTypeArt art {
            get {
                return this.artField;
            }
            set {
                this.artField = value;
                this.RaisePropertyChanged("art");
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