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
namespace Dataline.Elster.Datenuebermittler2015 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.elster.de/elo2/datenuebermittler/aenderungsliste/2015")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.elster.de/elo2/datenuebermittler/aenderungsliste/2015", IsNullable=false)]
    public partial class Aenderungsliste : object, System.ComponentModel.INotifyPropertyChanged {
        
        private ArbeitgeberComplex arbeitgeberField;
        
        private string stnrDUeField;
        
        private string transferTicketField;
        
        private string nutzdatenTicketField;
        
        private ArtSimple artField;
        
        private int laufendeNummerField;
        
        private int anzahlTeillistenField;
        
        private string schemaversionField;
        
        /// <remarks/>
        public ArbeitgeberComplex Arbeitgeber {
            get {
                return this.arbeitgeberField;
            }
            set {
                this.arbeitgeberField = value;
                this.RaisePropertyChanged("Arbeitgeber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string stnrDUe {
            get {
                return this.stnrDUeField;
            }
            set {
                this.stnrDUeField = value;
                this.RaisePropertyChanged("stnrDUe");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string transferTicket {
            get {
                return this.transferTicketField;
            }
            set {
                this.transferTicketField = value;
                this.RaisePropertyChanged("transferTicket");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nutzdatenTicket {
            get {
                return this.nutzdatenTicketField;
            }
            set {
                this.nutzdatenTicketField = value;
                this.RaisePropertyChanged("nutzdatenTicket");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ArtSimple art {
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
        public int laufendeNummer {
            get {
                return this.laufendeNummerField;
            }
            set {
                this.laufendeNummerField = value;
                this.RaisePropertyChanged("laufendeNummer");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int anzahlTeillisten {
            get {
                return this.anzahlTeillistenField;
            }
            set {
                this.anzahlTeillistenField = value;
                this.RaisePropertyChanged("anzahlTeillisten");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/elo2/datenuebermittler/aenderungsliste/2015")]
    public partial class ArbeitgeberComplex : object, System.ComponentModel.INotifyPropertyChanged {
        
        private ArbeitnehmerComplex[] arbeitnehmerField;
        
        private AGVerfahrenshinweisComplex aGVerfahrenshinweisField;
        
        private SteuernummerHinweisComplex steuernummerhinweisField;
        
        private string stnrAGField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Arbeitnehmer")]
        public ArbeitnehmerComplex[] Arbeitnehmer {
            get {
                return this.arbeitnehmerField;
            }
            set {
                this.arbeitnehmerField = value;
                this.RaisePropertyChanged("Arbeitnehmer");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AG-Verfahrenshinweis")]
        public AGVerfahrenshinweisComplex AGVerfahrenshinweis {
            get {
                return this.aGVerfahrenshinweisField;
            }
            set {
                this.aGVerfahrenshinweisField = value;
                this.RaisePropertyChanged("AGVerfahrenshinweis");
            }
        }
        
        /// <remarks/>
        public SteuernummerHinweisComplex Steuernummerhinweis {
            get {
                return this.steuernummerhinweisField;
            }
            set {
                this.steuernummerhinweisField = value;
                this.RaisePropertyChanged("Steuernummerhinweis");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string stnrAG {
            get {
                return this.stnrAGField;
            }
            set {
                this.stnrAGField = value;
                this.RaisePropertyChanged("stnrAG");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/elo2/datenuebermittler/aenderungsliste/2015")]
    public partial class ArbeitnehmerComplex : object, System.ComponentModel.INotifyPropertyChanged {
        
        private ELStAMComplex[] eLStAMField;
        
        private ANVerfahrenshinweisComplex[] aNVerfahrenshinweisField;
        
        private string idnrField;
        
        private string beschaeftigungsbeginnField;
        
        private string refDatumAGField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ELStAM")]
        public ELStAMComplex[] ELStAM {
            get {
                return this.eLStAMField;
            }
            set {
                this.eLStAMField = value;
                this.RaisePropertyChanged("ELStAM");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AN-Verfahrenshinweis")]
        public ANVerfahrenshinweisComplex[] ANVerfahrenshinweis {
            get {
                return this.aNVerfahrenshinweisField;
            }
            set {
                this.aNVerfahrenshinweisField = value;
                this.RaisePropertyChanged("ANVerfahrenshinweis");
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
        public string beschaeftigungsbeginn {
            get {
                return this.beschaeftigungsbeginnField;
            }
            set {
                this.beschaeftigungsbeginnField = value;
                this.RaisePropertyChanged("beschaeftigungsbeginn");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string refDatumAG {
            get {
                return this.refDatumAGField;
            }
            set {
                this.refDatumAGField = value;
                this.RaisePropertyChanged("refDatumAG");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/elo2/datenuebermittler/aenderungsliste/2015")]
    public partial class ELStAMComplex : object, System.ComponentModel.INotifyPropertyChanged {
        
        private SteuerklasseComplex steuerklasseField;
        
        private KinderFreibetragComplex kinderfreibetragField;
        
        private KirchensteuerComplex kirchensteuerField;
        
        private KirchensteuerComplex kirchensteuerPartnerField;
        
        private FaktorComplex faktorField;
        
        private FreibetragComplex freibetragField;
        
        private HinzurechnungsbetragComplex hinzurechnungsbetragField;
        
        private string gueltigAbField;
        
        /// <remarks/>
        public SteuerklasseComplex Steuerklasse {
            get {
                return this.steuerklasseField;
            }
            set {
                this.steuerklasseField = value;
                this.RaisePropertyChanged("Steuerklasse");
            }
        }
        
        /// <remarks/>
        public KinderFreibetragComplex Kinderfreibetrag {
            get {
                return this.kinderfreibetragField;
            }
            set {
                this.kinderfreibetragField = value;
                this.RaisePropertyChanged("Kinderfreibetrag");
            }
        }
        
        /// <remarks/>
        public KirchensteuerComplex Kirchensteuer {
            get {
                return this.kirchensteuerField;
            }
            set {
                this.kirchensteuerField = value;
                this.RaisePropertyChanged("Kirchensteuer");
            }
        }
        
        /// <remarks/>
        public KirchensteuerComplex KirchensteuerPartner {
            get {
                return this.kirchensteuerPartnerField;
            }
            set {
                this.kirchensteuerPartnerField = value;
                this.RaisePropertyChanged("KirchensteuerPartner");
            }
        }
        
        /// <remarks/>
        public FaktorComplex Faktor {
            get {
                return this.faktorField;
            }
            set {
                this.faktorField = value;
                this.RaisePropertyChanged("Faktor");
            }
        }
        
        /// <remarks/>
        public FreibetragComplex Freibetrag {
            get {
                return this.freibetragField;
            }
            set {
                this.freibetragField = value;
                this.RaisePropertyChanged("Freibetrag");
            }
        }
        
        /// <remarks/>
        public HinzurechnungsbetragComplex Hinzurechnungsbetrag {
            get {
                return this.hinzurechnungsbetragField;
            }
            set {
                this.hinzurechnungsbetragField = value;
                this.RaisePropertyChanged("Hinzurechnungsbetrag");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string gueltigAb {
            get {
                return this.gueltigAbField;
            }
            set {
                this.gueltigAbField = value;
                this.RaisePropertyChanged("gueltigAb");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/elo2/datenuebermittler/aenderungsliste/2015")]
    public partial class SteuerklasseComplex : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nummerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string nummer {
            get {
                return this.nummerField;
            }
            set {
                this.nummerField = value;
                this.RaisePropertyChanged("nummer");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/elo2/datenuebermittler/aenderungsliste/2015")]
    public partial class SteuernummerHinweisComplex : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codeField;
        
        private string messageField;
        
        private HinweisSimple typeField;
        
        private string steuernummerField;
        
        public SteuernummerHinweisComplex() {
            this.codeField = "551000009";
            this.messageField = "Bitte verwenden Sie im Verfahren ElsterLohn II die im Attribut steuernummer entha" +
                "ltene Steuernummer";
            this.typeField = HinweisSimple.INFORMATION;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HinweisSimple type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("type");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string steuernummer {
            get {
                return this.steuernummerField;
            }
            set {
                this.steuernummerField = value;
                this.RaisePropertyChanged("steuernummer");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/elo2/datenuebermittler/aenderungsliste/2015")]
    public enum HinweisSimple {
        
        /// <remarks/>
        INFORMATION,
        
        /// <remarks/>
        ABLEHNUNG,
        
        /// <remarks/>
        FEHLER,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="AG-VerfahrenshinweisComplex", Namespace="http://www.elster.de/elo2/datenuebermittler/aenderungsliste/2015")]
    public partial class AGVerfahrenshinweisComplex : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codeField;
        
        private string messageField;
        
        private HinweisSimple typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HinweisSimple type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("type");
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="AN-VerfahrenshinweisComplex", Namespace="http://www.elster.de/elo2/datenuebermittler/aenderungsliste/2015")]
    public partial class ANVerfahrenshinweisComplex : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codeField;
        
        private string datumField;
        
        private string datumAltField;
        
        private string messageField;
        
        private HinweisSimple typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string datum {
            get {
                return this.datumField;
            }
            set {
                this.datumField = value;
                this.RaisePropertyChanged("datum");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string datumAlt {
            get {
                return this.datumAltField;
            }
            set {
                this.datumAltField = value;
                this.RaisePropertyChanged("datumAlt");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HinweisSimple type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("type");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/elo2/datenuebermittler/aenderungsliste/2015")]
    public partial class HinzurechnungsbetragComplex : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string jahrField;
        
        private string monatField;
        
        private decimal wocheField;
        
        private decimal tagField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string jahr {
            get {
                return this.jahrField;
            }
            set {
                this.jahrField = value;
                this.RaisePropertyChanged("jahr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string monat {
            get {
                return this.monatField;
            }
            set {
                this.monatField = value;
                this.RaisePropertyChanged("monat");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal woche {
            get {
                return this.wocheField;
            }
            set {
                this.wocheField = value;
                this.RaisePropertyChanged("woche");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal tag {
            get {
                return this.tagField;
            }
            set {
                this.tagField = value;
                this.RaisePropertyChanged("tag");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/elo2/datenuebermittler/aenderungsliste/2015")]
    public partial class FreibetragComplex : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string jahrField;
        
        private string monatField;
        
        private decimal wocheField;
        
        private decimal tagField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string jahr {
            get {
                return this.jahrField;
            }
            set {
                this.jahrField = value;
                this.RaisePropertyChanged("jahr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string monat {
            get {
                return this.monatField;
            }
            set {
                this.monatField = value;
                this.RaisePropertyChanged("monat");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal woche {
            get {
                return this.wocheField;
            }
            set {
                this.wocheField = value;
                this.RaisePropertyChanged("woche");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal tag {
            get {
                return this.tagField;
            }
            set {
                this.tagField = value;
                this.RaisePropertyChanged("tag");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/elo2/datenuebermittler/aenderungsliste/2015")]
    public partial class FaktorComplex : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int wertField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int wert {
            get {
                return this.wertField;
            }
            set {
                this.wertField = value;
                this.RaisePropertyChanged("wert");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/elo2/datenuebermittler/aenderungsliste/2015")]
    public partial class KirchensteuerComplex : object, System.ComponentModel.INotifyPropertyChanged {
        
        private KonfessionSimple konfessionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public KonfessionSimple konfession {
            get {
                return this.konfessionField;
            }
            set {
                this.konfessionField = value;
                this.RaisePropertyChanged("konfession");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/elo2/datenuebermittler/aenderungsliste/2015")]
    public enum KonfessionSimple {
        
        /// <remarks/>
        ak,
        
        /// <remarks/>
        ev,
        
        /// <remarks/>
        fa,
        
        /// <remarks/>
        fb,
        
        /// <remarks/>
        fg,
        
        /// <remarks/>
        fm,
        
        /// <remarks/>
        fr,
        
        /// <remarks/>
        fs,
        
        /// <remarks/>
        ib,
        
        /// <remarks/>
        ih,
        
        /// <remarks/>
        il,
        
        /// <remarks/>
        @is,
        
        /// <remarks/>
        iw,
        
        /// <remarks/>
        jd,
        
        /// <remarks/>
        jh,
        
        /// <remarks/>
        lt,
        
        /// <remarks/>
        na,
        
        /// <remarks/>
        rf,
        
        /// <remarks/>
        rk,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("--")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/elo2/datenuebermittler/aenderungsliste/2015")]
    public partial class KinderFreibetragComplex : object, System.ComponentModel.INotifyPropertyChanged {
        
        private decimal anzahlField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal anzahl {
            get {
                return this.anzahlField;
            }
            set {
                this.anzahlField = value;
                this.RaisePropertyChanged("anzahl");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/elo2/datenuebermittler/aenderungsliste/2015")]
    public enum ArtSimple {
        
        /// <remarks/>
        BRUTTOLISTE,
        
        /// <remarks/>
        MONATSLISTE,
        
        /// <remarks/>
        ANMELDEBESTAETIGUNGSLISTE,
        
        /// <remarks/>
        ABMELDEBESTAETIGUNGSLISTE,
        
        /// <remarks/>
        UMMELDEBESTAETIGUNGSLISTE,
    }
}
