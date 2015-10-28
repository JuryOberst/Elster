﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 1591

using Dataline.Elster.Basis;

// 
// Dieser Quellcode wurde automatisch generiert von xsd, Version=4.6.81.0.
// 
namespace Dataline.Elster.Datenabholung {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class NutzdatenCType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private DatenabholungCType datenabholungField;
        
        /// <remarks/>
        public DatenabholungCType Datenabholung {
            get {
                return this.datenabholungField;
            }
            set {
                this.datenabholungField = value;
                this.RaisePropertyChanged("Datenabholung");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class DatenabholungCType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private object itemField;
        
        private object item1Field;
        
        private DatenabholungCTypeVersion versionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Abholzertifikat", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Fingerprint", typeof(FingerprintCType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Abholung", typeof(AbholungCType))]
        [System.Xml.Serialization.XmlElementAttribute("Anfrage", typeof(AnfrageCType))]
        [System.Xml.Serialization.XmlElementAttribute("Empfangsbestaetigung", typeof(EmpfangsbestaetigungCType))]
        public object Item1 {
            get {
                return this.item1Field;
            }
            set {
                this.item1Field = value;
                this.RaisePropertyChanged("Item1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DatenabholungCTypeVersion version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
                this.RaisePropertyChanged("version");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class FingerprintCType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private byte[] nameField;
        
        private byte[] valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="hexBinary")]
        public byte[] name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
        public byte[] Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class AbholungCType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private object itemField;
        
        private AbholungCTypeMetadaten metadatenField;
        
        private string idField;
        
        private string idnrField;
        
        private string veranlagungsjahrField;
        
        private bool metadatenField1;
        
        private AbholungCTypeUebertragungsweg uebertragungswegField;
        
        private bool uebertragungswegFieldSpecified;
        
        public AbholungCType() {
            this.metadatenField1 = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Datenpaket", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Download", typeof(AbholungCTypeDownload))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
            }
        }
        
        /// <remarks/>
        public AbholungCTypeMetadaten Metadaten {
            get {
                return this.metadatenField;
            }
            set {
                this.metadatenField = value;
                this.RaisePropertyChanged("Metadaten");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string idnr {
            get {
                return this.idnrField;
            }
            set {
                this.idnrField = value;
                this.RaisePropertyChanged("idnr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="gYear")]
        public string veranlagungsjahr {
            get {
                return this.veranlagungsjahrField;
            }
            set {
                this.veranlagungsjahrField = value;
                this.RaisePropertyChanged("veranlagungsjahr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("metadaten")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool hatMetadaten {
            get {
                return this.metadatenField1;
            }
            set {
                this.metadatenField1 = value;
                this.RaisePropertyChanged("metadaten");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AbholungCTypeUebertragungsweg uebertragungsweg {
            get {
                return this.uebertragungswegField;
            }
            set {
                this.uebertragungswegField = value;
                this.RaisePropertyChanged("uebertragungsweg");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool uebertragungswegSpecified {
            get {
                return this.uebertragungswegFieldSpecified;
            }
            set {
                this.uebertragungswegFieldSpecified = value;
                this.RaisePropertyChanged("uebertragungswegSpecified");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class AbholungCTypeDownload : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string urlField;
        
        private string benutzerField;
        
        private string passwortField;
        
        /// <remarks/>
        public string Url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
                this.RaisePropertyChanged("Url");
            }
        }
        
        /// <remarks/>
        public string Benutzer {
            get {
                return this.benutzerField;
            }
            set {
                this.benutzerField = value;
                this.RaisePropertyChanged("Benutzer");
            }
        }
        
        /// <remarks/>
        public string Passwort {
            get {
                return this.passwortField;
            }
            set {
                this.passwortField = value;
                this.RaisePropertyChanged("Passwort");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class AbholungCTypeMetadaten : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string artField;
        
        private string codingField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string art {
            get {
                return this.artField;
            }
            set {
                this.artField = value;
                this.RaisePropertyChanged("art");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string coding {
            get {
                return this.codingField;
            }
            set {
                this.codingField = value;
                this.RaisePropertyChanged("coding");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.elster.de/2002/XMLSchema")]
    public enum AbholungCTypeUebertragungsweg {
        
        /// <remarks/>
        direkt,
        
        /// <remarks/>
        link,
        
        /// <remarks/>
        sammellink,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class AnfrageCType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private AntwortIdCType[] idField;
        
        private AnfrageCTypeEinschraenkung einschraenkungField;
        
        private string vonField;
        
        private string bisField;
        
        private string veranlagungsjahrField;
        
        private string steuerartField;
        
        private string finanzamtField;
        
        private AnfrageCTypeBundesland bundeslandField;
        
        private bool bundeslandFieldSpecified;
        
        private string maxField;
        
        private string anforderungsticketField;
        
        private string agstnrField;
        
        private string schemaversionField;
        
        private string lieferticketField;
        
        private string idnrField;
        
        private string belegartField;
        
        public AnfrageCType() {
            this.einschraenkungField = AnfrageCTypeEinschraenkung.alle;
            this.maxField = "100";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public AntwortIdCType[] Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(AnfrageCTypeEinschraenkung.alle)]
        public AnfrageCTypeEinschraenkung einschraenkung {
            get {
                return this.einschraenkungField;
            }
            set {
                this.einschraenkungField = value;
                this.RaisePropertyChanged("einschraenkung");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string von {
            get {
                return this.vonField;
            }
            set {
                this.vonField = value;
                this.RaisePropertyChanged("von");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bis {
            get {
                return this.bisField;
            }
            set {
                this.bisField = value;
                this.RaisePropertyChanged("bis");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="gYear")]
        public string veranlagungsjahr {
            get {
                return this.veranlagungsjahrField;
            }
            set {
                this.veranlagungsjahrField = value;
                this.RaisePropertyChanged("veranlagungsjahr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string steuerart {
            get {
                return this.steuerartField;
            }
            set {
                this.steuerartField = value;
                this.RaisePropertyChanged("steuerart");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string finanzamt {
            get {
                return this.finanzamtField;
            }
            set {
                this.finanzamtField = value;
                this.RaisePropertyChanged("finanzamt");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AnfrageCTypeBundesland bundesland {
            get {
                return this.bundeslandField;
            }
            set {
                this.bundeslandField = value;
                this.RaisePropertyChanged("bundesland");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bundeslandSpecified {
            get {
                return this.bundeslandFieldSpecified;
            }
            set {
                this.bundeslandFieldSpecified = value;
                this.RaisePropertyChanged("bundeslandSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        [System.ComponentModel.DefaultValueAttribute("100")]
        public string max {
            get {
                return this.maxField;
            }
            set {
                this.maxField = value;
                this.RaisePropertyChanged("max");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string anforderungsticket {
            get {
                return this.anforderungsticketField;
            }
            set {
                this.anforderungsticketField = value;
                this.RaisePropertyChanged("anforderungsticket");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string agstnr {
            get {
                return this.agstnrField;
            }
            set {
                this.agstnrField = value;
                this.RaisePropertyChanged("agstnr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string schemaversion {
            get {
                return this.schemaversionField;
            }
            set {
                this.schemaversionField = value;
                this.RaisePropertyChanged("schemaversion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lieferticket {
            get {
                return this.lieferticketField;
            }
            set {
                this.lieferticketField = value;
                this.RaisePropertyChanged("lieferticket");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string idnr {
            get {
                return this.idnrField;
            }
            set {
                this.idnrField = value;
                this.RaisePropertyChanged("idnr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string belegart {
            get {
                return this.belegartField;
            }
            set {
                this.belegartField = value;
                this.RaisePropertyChanged("belegart");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class AntwortIdCType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string groesseField;
        
        private string steuerartField;
        
        private string belegartField;
        
        private string schemaversionField;
        
        private string hashwertField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string groesse {
            get {
                return this.groesseField;
            }
            set {
                this.groesseField = value;
                this.RaisePropertyChanged("groesse");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string steuerart {
            get {
                return this.steuerartField;
            }
            set {
                this.steuerartField = value;
                this.RaisePropertyChanged("steuerart");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string belegart {
            get {
                return this.belegartField;
            }
            set {
                this.belegartField = value;
                this.RaisePropertyChanged("belegart");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string schemaversion {
            get {
                return this.schemaversionField;
            }
            set {
                this.schemaversionField = value;
                this.RaisePropertyChanged("schemaversion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string hashwert {
            get {
                return this.hashwertField;
            }
            set {
                this.hashwertField = value;
                this.RaisePropertyChanged("hashwert");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.elster.de/2002/XMLSchema")]
    public enum AnfrageCTypeEinschraenkung {
        
        /// <remarks/>
        neue,
        
        /// <remarks/>
        alle,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.elster.de/2002/XMLSchema")]
    public enum AnfrageCTypeBundesland {
        
        /// <remarks/>
        BW,
        
        /// <remarks/>
        BY,
        
        /// <remarks/>
        BE,
        
        /// <remarks/>
        BB,
        
        /// <remarks/>
        HB,
        
        /// <remarks/>
        HH,
        
        /// <remarks/>
        HE,
        
        /// <remarks/>
        MV,
        
        /// <remarks/>
        ND,
        
        /// <remarks/>
        NW,
        
        /// <remarks/>
        RP,
        
        /// <remarks/>
        SL,
        
        /// <remarks/>
        SN,
        
        /// <remarks/>
        ST,
        
        /// <remarks/>
        SH,
        
        /// <remarks/>
        TH,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class EmpfangsbestaetigungCType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string idField;
        
        private string idnrField;
        
        private string veranlagungsjahrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string idnr {
            get {
                return this.idnrField;
            }
            set {
                this.idnrField = value;
                this.RaisePropertyChanged("idnr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="gYear")]
        public string veranlagungsjahr {
            get {
                return this.veranlagungsjahrField;
            }
            set {
                this.veranlagungsjahrField = value;
                this.RaisePropertyChanged("veranlagungsjahr");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.elster.de/2002/XMLSchema")]
    public enum DatenabholungCTypeVersion {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class NutzdatenblockCType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private NutzdatenHeaderCType nutzdatenHeaderField;
        
        private NutzdatenCType nutzdatenField;
        
        /// <remarks/>
        public NutzdatenHeaderCType NutzdatenHeader {
            get {
                return this.nutzdatenHeaderField;
            }
            set {
                this.nutzdatenHeaderField = value;
                this.RaisePropertyChanged("NutzdatenHeader");
            }
        }
        
        /// <remarks/>
        public NutzdatenCType Nutzdaten {
            get {
                return this.nutzdatenField;
            }
            set {
                this.nutzdatenField = value;
                this.RaisePropertyChanged("Nutzdaten");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class NDH_ZusatzCType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string[] infoField;
        
        private string[] elsterInfoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Info")]
        public string[] Info {
            get {
                return this.infoField;
            }
            set {
                this.infoField = value;
                this.RaisePropertyChanged("Info");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ElsterInfo")]
        public string[] ElsterInfo {
            get {
                return this.elsterInfoField;
            }
            set {
                this.elsterInfoField = value;
                this.RaisePropertyChanged("ElsterInfo");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class DatenTeilCType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private NutzdatenblockCType[] nutzdatenblockField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Nutzdatenblock")]
        public NutzdatenblockCType[] Nutzdatenblock {
            get {
                return this.nutzdatenblockField;
            }
            set {
                this.nutzdatenblockField = value;
                this.RaisePropertyChanged("Nutzdatenblock");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.elster.de/2002/XMLSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.elster.de/2002/XMLSchema", IsNullable=false)]
    public partial class Elster : object, System.ComponentModel.INotifyPropertyChanged {
        
        private TransferHeaderCType transferHeaderField;
        
        private DatenTeilCType datenTeilField;
        
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
        public DatenTeilCType DatenTeil {
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
