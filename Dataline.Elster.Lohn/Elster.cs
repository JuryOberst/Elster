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

using Dataline.Elster.Basis;

namespace Dataline.Elster.Lohn {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.elster.de/2002/XMLSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.elster.de/2002/XMLSchema", IsNullable=false)]
    public partial class Elster: object, System.ComponentModel.INotifyPropertyChanged {
        
        private TransferHeaderCType transferHeaderField;
        
        private System.Collections.Generic.List<NutzdatenblockCType> datenTeilField;
        
        /// <remarks/>
        public TransferHeaderCType TransferHeader {
            get {
                return this.transferHeaderField;
            }
            set {
                this.transferHeaderField = value;
                this.RaisePropertyChanged("TransferHeader");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Nutzdatenblock", IsNullable=false)]
        public System.Collections.Generic.List<NutzdatenblockCType> DatenTeil {
            get {
                return this.datenTeilField;
            }
            set {
                this.datenTeilField = value;
                this.RaisePropertyChanged("DatenTeil");
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
