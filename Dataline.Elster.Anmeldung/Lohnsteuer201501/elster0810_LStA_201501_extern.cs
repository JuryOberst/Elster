﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Dieser Quellcode wurde automatisch generiert von xsd, Version=4.6.81.0.
// 

using Dataline.Elster.Basis;

namespace Dataline.Elster.Anmeldung.Lohnsteuer200151 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class NutzdatenCType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private AnmeldungssteuernCType anmeldungssteuernField;
        
        /// <remarks/>
        public AnmeldungssteuernCType Anmeldungssteuern {
            get {
                return this.anmeldungssteuernField;
            }
            set {
                this.anmeldungssteuernField = value;
                this.RaisePropertyChanged("Anmeldungssteuern");
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
    public partial class AnmeldungssteuernCType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private lstaDatenlieferantType datenLieferantField;
        
        private string erstellungsdatumField;
        
        private lstaSteuerfallType steuerfallField;
        
        private string artField;
        
        private AnmeldungssteuernCTypeVersion versionField;
        
        public AnmeldungssteuernCType() {
            this.artField = "LStA";
        }
        
        /// <remarks/>
        public lstaDatenlieferantType DatenLieferant {
            get {
                return this.datenLieferantField;
            }
            set {
                this.datenLieferantField = value;
                this.RaisePropertyChanged("DatenLieferant");
            }
        }
        
        /// <remarks/>
        public string Erstellungsdatum {
            get {
                return this.erstellungsdatumField;
            }
            set {
                this.erstellungsdatumField = value;
                this.RaisePropertyChanged("Erstellungsdatum");
            }
        }
        
        /// <remarks/>
        public lstaSteuerfallType Steuerfall {
            get {
                return this.steuerfallField;
            }
            set {
                this.steuerfallField = value;
                this.RaisePropertyChanged("Steuerfall");
            }
        }
        
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
        public AnmeldungssteuernCTypeVersion version {
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
    public partial class lstaDatenlieferantType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string strasseField;
        
        private string pLZField;
        
        private string ortField;
        
        private string telefonField;
        
        private string emailField;
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        public string Strasse {
            get {
                return this.strasseField;
            }
            set {
                this.strasseField = value;
                this.RaisePropertyChanged("Strasse");
            }
        }
        
        /// <remarks/>
        public string PLZ {
            get {
                return this.pLZField;
            }
            set {
                this.pLZField = value;
                this.RaisePropertyChanged("PLZ");
            }
        }
        
        /// <remarks/>
        public string Ort {
            get {
                return this.ortField;
            }
            set {
                this.ortField = value;
                this.RaisePropertyChanged("Ort");
            }
        }
        
        /// <remarks/>
        public string Telefon {
            get {
                return this.telefonField;
            }
            set {
                this.telefonField = value;
                this.RaisePropertyChanged("Telefon");
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
                this.RaisePropertyChanged("Email");
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
    public partial class lstaSteuerfallType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private AdresseCType beraterField;
        
        private MandantCType mandantField;
        
        private AdresseCType unternehmerField;
        
        private lstaSteuerfallTypeLohnsteueranmeldung lohnsteueranmeldungField;
        
        /// <remarks/>
        public AdresseCType Berater {
            get {
                return this.beraterField;
            }
            set {
                this.beraterField = value;
                this.RaisePropertyChanged("Berater");
            }
        }
        
        /// <remarks/>
        public MandantCType Mandant {
            get {
                return this.mandantField;
            }
            set {
                this.mandantField = value;
                this.RaisePropertyChanged("Mandant");
            }
        }
        
        /// <remarks/>
        public AdresseCType Unternehmer {
            get {
                return this.unternehmerField;
            }
            set {
                this.unternehmerField = value;
                this.RaisePropertyChanged("Unternehmer");
            }
        }
        
        /// <remarks/>
        public lstaSteuerfallTypeLohnsteueranmeldung Lohnsteueranmeldung {
            get {
                return this.lohnsteueranmeldungField;
            }
            set {
                this.lohnsteueranmeldungField = value;
                this.RaisePropertyChanged("Lohnsteueranmeldung");
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
    public partial class AdresseCType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string bezeichnungField;
        
        private string nameField;
        
        private string vornameField;
        
        private string namensvorsatzField;
        
        private string namenszusatzField;
        
        private string strField;
        
        private string hausnummerField;
        
        private string hNrZusatzField;
        
        private string anschriftenZusatzField;
        
        private string ortField;
        
        private string pLZField;
        
        private string auslandsPLZField;
        
        private string landField;
        
        private string postfachOrtField;
        
        private string postfachField;
        
        private string postfachPLZField;
        
        private string gKPLZField;
        
        private string telefonField;
        
        private string emailField;
        
        /// <remarks/>
        public string Bezeichnung {
            get {
                return this.bezeichnungField;
            }
            set {
                this.bezeichnungField = value;
                this.RaisePropertyChanged("Bezeichnung");
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        public string Vorname {
            get {
                return this.vornameField;
            }
            set {
                this.vornameField = value;
                this.RaisePropertyChanged("Vorname");
            }
        }
        
        /// <remarks/>
        public string Namensvorsatz {
            get {
                return this.namensvorsatzField;
            }
            set {
                this.namensvorsatzField = value;
                this.RaisePropertyChanged("Namensvorsatz");
            }
        }
        
        /// <remarks/>
        public string Namenszusatz {
            get {
                return this.namenszusatzField;
            }
            set {
                this.namenszusatzField = value;
                this.RaisePropertyChanged("Namenszusatz");
            }
        }
        
        /// <remarks/>
        public string Str {
            get {
                return this.strField;
            }
            set {
                this.strField = value;
                this.RaisePropertyChanged("Str");
            }
        }
        
        /// <remarks/>
        public string Hausnummer {
            get {
                return this.hausnummerField;
            }
            set {
                this.hausnummerField = value;
                this.RaisePropertyChanged("Hausnummer");
            }
        }
        
        /// <remarks/>
        public string HNrZusatz {
            get {
                return this.hNrZusatzField;
            }
            set {
                this.hNrZusatzField = value;
                this.RaisePropertyChanged("HNrZusatz");
            }
        }
        
        /// <remarks/>
        public string AnschriftenZusatz {
            get {
                return this.anschriftenZusatzField;
            }
            set {
                this.anschriftenZusatzField = value;
                this.RaisePropertyChanged("AnschriftenZusatz");
            }
        }
        
        /// <remarks/>
        public string Ort {
            get {
                return this.ortField;
            }
            set {
                this.ortField = value;
                this.RaisePropertyChanged("Ort");
            }
        }
        
        /// <remarks/>
        public string PLZ {
            get {
                return this.pLZField;
            }
            set {
                this.pLZField = value;
                this.RaisePropertyChanged("PLZ");
            }
        }
        
        /// <remarks/>
        public string AuslandsPLZ {
            get {
                return this.auslandsPLZField;
            }
            set {
                this.auslandsPLZField = value;
                this.RaisePropertyChanged("AuslandsPLZ");
            }
        }
        
        /// <remarks/>
        public string Land {
            get {
                return this.landField;
            }
            set {
                this.landField = value;
                this.RaisePropertyChanged("Land");
            }
        }
        
        /// <remarks/>
        public string PostfachOrt {
            get {
                return this.postfachOrtField;
            }
            set {
                this.postfachOrtField = value;
                this.RaisePropertyChanged("PostfachOrt");
            }
        }
        
        /// <remarks/>
        public string Postfach {
            get {
                return this.postfachField;
            }
            set {
                this.postfachField = value;
                this.RaisePropertyChanged("Postfach");
            }
        }
        
        /// <remarks/>
        public string PostfachPLZ {
            get {
                return this.postfachPLZField;
            }
            set {
                this.postfachPLZField = value;
                this.RaisePropertyChanged("PostfachPLZ");
            }
        }
        
        /// <remarks/>
        public string GKPLZ {
            get {
                return this.gKPLZField;
            }
            set {
                this.gKPLZField = value;
                this.RaisePropertyChanged("GKPLZ");
            }
        }
        
        /// <remarks/>
        public string Telefon {
            get {
                return this.telefonField;
            }
            set {
                this.telefonField = value;
                this.RaisePropertyChanged("Telefon");
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
                this.RaisePropertyChanged("Email");
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
    public partial class MandantCType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string vornameField;
        
        private string mandantenNrField;
        
        private string bearbeiterkennzeichenField;
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        public string Vorname {
            get {
                return this.vornameField;
            }
            set {
                this.vornameField = value;
                this.RaisePropertyChanged("Vorname");
            }
        }
        
        /// <remarks/>
        public string MandantenNr {
            get {
                return this.mandantenNrField;
            }
            set {
                this.mandantenNrField = value;
                this.RaisePropertyChanged("MandantenNr");
            }
        }
        
        /// <remarks/>
        public string Bearbeiterkennzeichen {
            get {
                return this.bearbeiterkennzeichenField;
            }
            set {
                this.bearbeiterkennzeichenField = value;
                this.RaisePropertyChanged("Bearbeiterkennzeichen");
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
    public partial class lstaSteuerfallTypeLohnsteueranmeldung : object, System.ComponentModel.INotifyPropertyChanged {
        
        private lstaJahrSType jahrField;
        
        private lstaZeitraumSType zeitraumField;
        
        private string steuernummerField;
        
        private string kz09Field;
        
        private Kz10 kz10Field;
        
        private bool kz10FieldSpecified;
        
        private Kz26 kz26Field;
        
        private bool kz26FieldSpecified;
        
        private Kz29 kz29Field;
        
        private bool kz29FieldSpecified;
        
        private string kz33Field;
        
        private string kz41Field;
        
        private string kz42Field;
        
        private string kz43Field;
        
        private string kz44Field;
        
        private string kz47Field;
        
        private string kz48Field;
        
        private string kz49Field;
        
        private string kz61Field;
        
        private string kz62Field;
        
        private string kz63Field;
        
        private string kz64Field;
        
        private string kz65Field;
        
        private string kz66Field;
        
        private string kz67Field;
        
        private string kz68Field;
        
        private string kz70Field;
        
        private string kz72Field;
        
        private string kz73Field;
        
        private string kz74Field;
        
        private string kz78Field;
        
        private string kz83Field;
        
        private string kz86Field;
        
        /// <remarks/>
        public lstaJahrSType Jahr {
            get {
                return this.jahrField;
            }
            set {
                this.jahrField = value;
                this.RaisePropertyChanged("Jahr");
            }
        }
        
        /// <remarks/>
        public lstaZeitraumSType Zeitraum {
            get {
                return this.zeitraumField;
            }
            set {
                this.zeitraumField = value;
                this.RaisePropertyChanged("Zeitraum");
            }
        }
        
        /// <remarks/>
        public string Steuernummer {
            get {
                return this.steuernummerField;
            }
            set {
                this.steuernummerField = value;
                this.RaisePropertyChanged("Steuernummer");
            }
        }
        
        /// <remarks/>
        public string Kz09 {
            get {
                return this.kz09Field;
            }
            set {
                this.kz09Field = value;
                this.RaisePropertyChanged("Kz09");
            }
        }
        
        /// <remarks/>
        public Kz10 Kz10 {
            get {
                return this.kz10Field;
            }
            set {
                this.kz10Field = value;
                this.RaisePropertyChanged("Kz10");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Kz10Specified {
            get {
                return this.kz10FieldSpecified;
            }
            set {
                this.kz10FieldSpecified = value;
                this.RaisePropertyChanged("Kz10Specified");
            }
        }
        
        /// <remarks/>
        public Kz26 Kz26 {
            get {
                return this.kz26Field;
            }
            set {
                this.kz26Field = value;
                this.RaisePropertyChanged("Kz26");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Kz26Specified {
            get {
                return this.kz26FieldSpecified;
            }
            set {
                this.kz26FieldSpecified = value;
                this.RaisePropertyChanged("Kz26Specified");
            }
        }
        
        /// <remarks/>
        public Kz29 Kz29 {
            get {
                return this.kz29Field;
            }
            set {
                this.kz29Field = value;
                this.RaisePropertyChanged("Kz29");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Kz29Specified {
            get {
                return this.kz29FieldSpecified;
            }
            set {
                this.kz29FieldSpecified = value;
                this.RaisePropertyChanged("Kz29Specified");
            }
        }
        
        /// <remarks/>
        public string Kz33 {
            get {
                return this.kz33Field;
            }
            set {
                this.kz33Field = value;
                this.RaisePropertyChanged("Kz33");
            }
        }
        
        /// <remarks/>
        public string Kz41 {
            get {
                return this.kz41Field;
            }
            set {
                this.kz41Field = value;
                this.RaisePropertyChanged("Kz41");
            }
        }
        
        /// <remarks/>
        public string Kz42 {
            get {
                return this.kz42Field;
            }
            set {
                this.kz42Field = value;
                this.RaisePropertyChanged("Kz42");
            }
        }
        
        /// <remarks/>
        public string Kz43 {
            get {
                return this.kz43Field;
            }
            set {
                this.kz43Field = value;
                this.RaisePropertyChanged("Kz43");
            }
        }
        
        /// <remarks/>
        public string Kz44 {
            get {
                return this.kz44Field;
            }
            set {
                this.kz44Field = value;
                this.RaisePropertyChanged("Kz44");
            }
        }
        
        /// <remarks/>
        public string Kz47 {
            get {
                return this.kz47Field;
            }
            set {
                this.kz47Field = value;
                this.RaisePropertyChanged("Kz47");
            }
        }
        
        /// <remarks/>
        public string Kz48 {
            get {
                return this.kz48Field;
            }
            set {
                this.kz48Field = value;
                this.RaisePropertyChanged("Kz48");
            }
        }
        
        /// <remarks/>
        public string Kz49 {
            get {
                return this.kz49Field;
            }
            set {
                this.kz49Field = value;
                this.RaisePropertyChanged("Kz49");
            }
        }
        
        /// <remarks/>
        public string Kz61 {
            get {
                return this.kz61Field;
            }
            set {
                this.kz61Field = value;
                this.RaisePropertyChanged("Kz61");
            }
        }
        
        /// <remarks/>
        public string Kz62 {
            get {
                return this.kz62Field;
            }
            set {
                this.kz62Field = value;
                this.RaisePropertyChanged("Kz62");
            }
        }
        
        /// <remarks/>
        public string Kz63 {
            get {
                return this.kz63Field;
            }
            set {
                this.kz63Field = value;
                this.RaisePropertyChanged("Kz63");
            }
        }
        
        /// <remarks/>
        public string Kz64 {
            get {
                return this.kz64Field;
            }
            set {
                this.kz64Field = value;
                this.RaisePropertyChanged("Kz64");
            }
        }
        
        /// <remarks/>
        public string Kz65 {
            get {
                return this.kz65Field;
            }
            set {
                this.kz65Field = value;
                this.RaisePropertyChanged("Kz65");
            }
        }
        
        /// <remarks/>
        public string Kz66 {
            get {
                return this.kz66Field;
            }
            set {
                this.kz66Field = value;
                this.RaisePropertyChanged("Kz66");
            }
        }
        
        /// <remarks/>
        public string Kz67 {
            get {
                return this.kz67Field;
            }
            set {
                this.kz67Field = value;
                this.RaisePropertyChanged("Kz67");
            }
        }
        
        /// <remarks/>
        public string Kz68 {
            get {
                return this.kz68Field;
            }
            set {
                this.kz68Field = value;
                this.RaisePropertyChanged("Kz68");
            }
        }
        
        /// <remarks/>
        public string Kz70 {
            get {
                return this.kz70Field;
            }
            set {
                this.kz70Field = value;
                this.RaisePropertyChanged("Kz70");
            }
        }
        
        /// <remarks/>
        public string Kz72 {
            get {
                return this.kz72Field;
            }
            set {
                this.kz72Field = value;
                this.RaisePropertyChanged("Kz72");
            }
        }
        
        /// <remarks/>
        public string Kz73 {
            get {
                return this.kz73Field;
            }
            set {
                this.kz73Field = value;
                this.RaisePropertyChanged("Kz73");
            }
        }
        
        /// <remarks/>
        public string Kz74 {
            get {
                return this.kz74Field;
            }
            set {
                this.kz74Field = value;
                this.RaisePropertyChanged("Kz74");
            }
        }
        
        /// <remarks/>
        public string Kz78 {
            get {
                return this.kz78Field;
            }
            set {
                this.kz78Field = value;
                this.RaisePropertyChanged("Kz78");
            }
        }
        
        /// <remarks/>
        public string Kz83 {
            get {
                return this.kz83Field;
            }
            set {
                this.kz83Field = value;
                this.RaisePropertyChanged("Kz83");
            }
        }
        
        /// <remarks/>
        public string Kz86 {
            get {
                return this.kz86Field;
            }
            set {
                this.kz86Field = value;
                this.RaisePropertyChanged("Kz86");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/2002/XMLSchema")]
    public enum lstaJahrSType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2015")]
        Item2015,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/2002/XMLSchema")]
    public enum lstaZeitraumSType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("19")]
        Item19,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42")]
        Item42,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("43")]
        Item43,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("44")]
        Item44,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/2002/XMLSchema")]
    public enum Kz10 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/2002/XMLSchema")]
    public enum Kz26 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/2002/XMLSchema")]
    public enum Kz29 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.elster.de/2002/XMLSchema")]
    public enum AnmeldungssteuernCTypeVersion {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("201501")]
        Item201501,
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
    public partial class LStACType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private AnmeldungssteuernCType anmeldungssteuernField;
        
        /// <remarks/>
        public AnmeldungssteuernCType Anmeldungssteuern {
            get {
                return this.anmeldungssteuernField;
            }
            set {
                this.anmeldungssteuernField = value;
                this.RaisePropertyChanged("Anmeldungssteuern");
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
        
        private NutzdatenblockCType[] datenTeilField;
        
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
        public NutzdatenblockCType[] DatenTeil {
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
