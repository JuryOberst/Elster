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
namespace Dataline.Elster.Lohn.LStB201401 {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="lstb_BesteuerungsgrundlagenCType", Namespace="http://www.elsterlohn.de/2014-01/XMLSchema")]
    public partial class lstb_BesteuerungsgrundlagenCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private string anzahlUField;
        
        private decimal bruttoArbLohnField;
        
        private decimal lSteuerField;
        
        private decimal soliField;
        
        private decimal arbnKiSteuerField;
        
        private bool arbnKiSteuerFieldSpecified;
        
        private decimal ehegKiSteuerField;
        
        private bool ehegKiSteuerFieldSpecified;
        
        private System.Collections.Generic.List<LStB201401.lstb_BesteuerungsgrundlagenCTypeVBez> vBezField;
        
        private System.Collections.Generic.List<LStB201401.lstb_BesteuerungsgrundlagenCTypeErmStVBezMKalJahr> ermStVBezMKalJahrField;
        
        private decimal ermStBetrMKalJahrField;
        
        private bool ermStBetrMKalJahrFieldSpecified;
        
        private decimal lSteuerMKalJahrField;
        
        private decimal soliMKalJahrField;
        
        private decimal kiSteuerArbnMKalJahrField;
        
        private bool kiSteuerArbnMKalJahrFieldSpecified;
        
        private decimal kiSteuerEhegMKalJahrField;
        
        private bool kiSteuerEhegMKalJahrFieldSpecified;
        
        private decimal kurzArbGeldField;
        
        private bool kurzArbGeldFieldSpecified;
        
        private decimal stFreiArbLohnDBAField;
        
        private bool stFreiArbLohnDBAFieldSpecified;
        
        private decimal stFreiArbLohnATEField;
        
        private bool stFreiArbLohnATEFieldSpecified;
        
        private decimal stFreiArbgLeistgField;
        
        private bool stFreiArbgLeistgFieldSpecified;
        
        private decimal pauschArbgLeistgField;
        
        private bool pauschArbgLeistgFieldSpecified;
        
        private decimal stPflichtArbLohnMKalJahrField;
        
        private bool stPflichtArbLohnMKalJahrFieldSpecified;
        
        private decimal stFreiVerpflegField;
        
        private bool stFreiVerpflegFieldSpecified;
        
        private decimal stFreiDopHaushaltField;
        
        private bool stFreiDopHaushaltFieldSpecified;
        
        private decimal arbgAnteilRenVersField;
        
        private bool arbgAnteilRenVersFieldSpecified;
        
        private decimal arbgAnteilBerufsVersField;
        
        private bool arbgAnteilBerufsVersFieldSpecified;
        
        private decimal arbnAnteilRenVersField;
        
        private bool arbnAnteilRenVersFieldSpecified;
        
        private decimal arbnAnteilBerufsVersField;
        
        private bool arbnAnteilBerufsVersFieldSpecified;
        
        private decimal stFreiGeKrankVersField;
        
        private bool stFreiGeKrankVersFieldSpecified;
        
        private decimal stFreiPrKrankVersField;
        
        private bool stFreiPrKrankVersFieldSpecified;
        
        private decimal stFreiGePflegeVersField;
        
        private bool stFreiGePflegeVersFieldSpecified;
        
        private decimal arbnAnteilKrankVersField;
        
        private bool arbnAnteilKrankVersFieldSpecified;
        
        private decimal arbnAnteilPflegVersField;
        
        private bool arbnAnteilPflegVersFieldSpecified;
        
        private decimal arbnAnteilArblVersField;
        
        private bool arbnAnteilArblVersFieldSpecified;
        
        private decimal beitrPrKrankVersField;
        
        private bool beitrPrKrankVersFieldSpecified;
        
        private decimal ausgezKinderGeldField;
        
        private bool ausgezKinderGeldFieldSpecified;
        
        private string grossbuchstabenField;
        
        private System.Collections.Generic.List<LStB201401.lstb_BesteuerungsgrundlagenCTypeKammerbeitrag> kammerbeitragField;
        
        private decimal arbnAnteilWBUmlageField;
        
        private bool arbnAnteilWBUmlageFieldSpecified;
        
        private decimal arbgAnteilZusatzVersField;
        
        private bool arbgAnteilZusatzVersFieldSpecified;
        
        private decimal arbnAnteilZusatzVersField;
        
        private bool arbnAnteilZusatzVersFieldSpecified;
        
        private int anzahlArbTagField;
        
        private bool anzahlArbTagFieldSpecified;
        
        private decimal stFreiFahrtKAuswField;
        
        private bool stFreiFahrtKAuswFieldSpecified;
        
        private System.Collections.Generic.List<LStB201401.lstb_BesteuerungsgrundlagenCTypeNErmStVBezMKalJahr> nErmStVBezMKalJahrField;
        
        private decimal stFreiArbgZuschBerufsVersField;
        
        private bool stFreiArbgZuschBerufsVersFieldSpecified;
        
        private System.Collections.Generic.List<LStB201401.lstb_BesteuerungsgrundlagenCTypeWert> wertField;
        
        private System.Collections.Generic.List<LStB201401.lstb_BesteuerungsgrundlagenCTypeText> textField;
        
        private LStB201401.lstb_ArbeitgeberCType arbeitgeberField;
        
        /// <remarks/>
        public string AnzahlU {
            get {
                return this.anzahlUField;
            }
            set {
                this.anzahlUField = value;
                this.RaisePropertyChanged("AnzahlU");
            }
        }
        
        /// <remarks/>
        public decimal BruttoArbLohn {
            get {
                return this.bruttoArbLohnField;
            }
            set {
                this.bruttoArbLohnField = value;
                this.RaisePropertyChanged("BruttoArbLohn");
            }
        }
        
        /// <remarks/>
        public decimal LSteuer {
            get {
                return this.lSteuerField;
            }
            set {
                this.lSteuerField = value;
                this.RaisePropertyChanged("LSteuer");
            }
        }
        
        /// <remarks/>
        public decimal Soli {
            get {
                return this.soliField;
            }
            set {
                this.soliField = value;
                this.RaisePropertyChanged("Soli");
            }
        }
        
        /// <remarks/>
        public decimal ArbnKiSteuer {
            get {
                return this.arbnKiSteuerField;
            }
            set {
                this.arbnKiSteuerField = value;
                this.RaisePropertyChanged("ArbnKiSteuer");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbnKiSteuerSpecified {
            get {
                return this.arbnKiSteuerFieldSpecified;
            }
            set {
                this.arbnKiSteuerFieldSpecified = value;
                this.RaisePropertyChanged("ArbnKiSteuerSpecified");
            }
        }
        
        /// <remarks/>
        public decimal EhegKiSteuer {
            get {
                return this.ehegKiSteuerField;
            }
            set {
                this.ehegKiSteuerField = value;
                this.RaisePropertyChanged("EhegKiSteuer");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EhegKiSteuerSpecified {
            get {
                return this.ehegKiSteuerFieldSpecified;
            }
            set {
                this.ehegKiSteuerFieldSpecified = value;
                this.RaisePropertyChanged("EhegKiSteuerSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VBez")]
        public System.Collections.Generic.List<LStB201401.lstb_BesteuerungsgrundlagenCTypeVBez> VBez {
            get {
                return this.vBezField;
            }
            set {
                this.vBezField = value;
                this.RaisePropertyChanged("VBez");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ErmStVBezMKalJahr")]
        public System.Collections.Generic.List<LStB201401.lstb_BesteuerungsgrundlagenCTypeErmStVBezMKalJahr> ErmStVBezMKalJahr {
            get {
                return this.ermStVBezMKalJahrField;
            }
            set {
                this.ermStVBezMKalJahrField = value;
                this.RaisePropertyChanged("ErmStVBezMKalJahr");
            }
        }
        
        /// <remarks/>
        public decimal ErmStBetrMKalJahr {
            get {
                return this.ermStBetrMKalJahrField;
            }
            set {
                this.ermStBetrMKalJahrField = value;
                this.RaisePropertyChanged("ErmStBetrMKalJahr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ErmStBetrMKalJahrSpecified {
            get {
                return this.ermStBetrMKalJahrFieldSpecified;
            }
            set {
                this.ermStBetrMKalJahrFieldSpecified = value;
                this.RaisePropertyChanged("ErmStBetrMKalJahrSpecified");
            }
        }
        
        /// <remarks/>
        public decimal LSteuerMKalJahr {
            get {
                return this.lSteuerMKalJahrField;
            }
            set {
                this.lSteuerMKalJahrField = value;
                this.RaisePropertyChanged("LSteuerMKalJahr");
            }
        }
        
        /// <remarks/>
        public decimal SoliMKalJahr {
            get {
                return this.soliMKalJahrField;
            }
            set {
                this.soliMKalJahrField = value;
                this.RaisePropertyChanged("SoliMKalJahr");
            }
        }
        
        /// <remarks/>
        public decimal KiSteuerArbnMKalJahr {
            get {
                return this.kiSteuerArbnMKalJahrField;
            }
            set {
                this.kiSteuerArbnMKalJahrField = value;
                this.RaisePropertyChanged("KiSteuerArbnMKalJahr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KiSteuerArbnMKalJahrSpecified {
            get {
                return this.kiSteuerArbnMKalJahrFieldSpecified;
            }
            set {
                this.kiSteuerArbnMKalJahrFieldSpecified = value;
                this.RaisePropertyChanged("KiSteuerArbnMKalJahrSpecified");
            }
        }
        
        /// <remarks/>
        public decimal KiSteuerEhegMKalJahr {
            get {
                return this.kiSteuerEhegMKalJahrField;
            }
            set {
                this.kiSteuerEhegMKalJahrField = value;
                this.RaisePropertyChanged("KiSteuerEhegMKalJahr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KiSteuerEhegMKalJahrSpecified {
            get {
                return this.kiSteuerEhegMKalJahrFieldSpecified;
            }
            set {
                this.kiSteuerEhegMKalJahrFieldSpecified = value;
                this.RaisePropertyChanged("KiSteuerEhegMKalJahrSpecified");
            }
        }
        
        /// <remarks/>
        public decimal KurzArbGeld {
            get {
                return this.kurzArbGeldField;
            }
            set {
                this.kurzArbGeldField = value;
                this.RaisePropertyChanged("KurzArbGeld");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KurzArbGeldSpecified {
            get {
                return this.kurzArbGeldFieldSpecified;
            }
            set {
                this.kurzArbGeldFieldSpecified = value;
                this.RaisePropertyChanged("KurzArbGeldSpecified");
            }
        }
        
        /// <remarks/>
        public decimal StFreiArbLohnDBA {
            get {
                return this.stFreiArbLohnDBAField;
            }
            set {
                this.stFreiArbLohnDBAField = value;
                this.RaisePropertyChanged("StFreiArbLohnDBA");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiArbLohnDBASpecified {
            get {
                return this.stFreiArbLohnDBAFieldSpecified;
            }
            set {
                this.stFreiArbLohnDBAFieldSpecified = value;
                this.RaisePropertyChanged("StFreiArbLohnDBASpecified");
            }
        }
        
        /// <remarks/>
        public decimal StFreiArbLohnATE {
            get {
                return this.stFreiArbLohnATEField;
            }
            set {
                this.stFreiArbLohnATEField = value;
                this.RaisePropertyChanged("StFreiArbLohnATE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiArbLohnATESpecified {
            get {
                return this.stFreiArbLohnATEFieldSpecified;
            }
            set {
                this.stFreiArbLohnATEFieldSpecified = value;
                this.RaisePropertyChanged("StFreiArbLohnATESpecified");
            }
        }
        
        /// <remarks/>
        public decimal StFreiArbgLeistg {
            get {
                return this.stFreiArbgLeistgField;
            }
            set {
                this.stFreiArbgLeistgField = value;
                this.RaisePropertyChanged("StFreiArbgLeistg");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiArbgLeistgSpecified {
            get {
                return this.stFreiArbgLeistgFieldSpecified;
            }
            set {
                this.stFreiArbgLeistgFieldSpecified = value;
                this.RaisePropertyChanged("StFreiArbgLeistgSpecified");
            }
        }
        
        /// <remarks/>
        public decimal PauschArbgLeistg {
            get {
                return this.pauschArbgLeistgField;
            }
            set {
                this.pauschArbgLeistgField = value;
                this.RaisePropertyChanged("PauschArbgLeistg");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PauschArbgLeistgSpecified {
            get {
                return this.pauschArbgLeistgFieldSpecified;
            }
            set {
                this.pauschArbgLeistgFieldSpecified = value;
                this.RaisePropertyChanged("PauschArbgLeistgSpecified");
            }
        }
        
        /// <remarks/>
        public decimal StPflichtArbLohnMKalJahr {
            get {
                return this.stPflichtArbLohnMKalJahrField;
            }
            set {
                this.stPflichtArbLohnMKalJahrField = value;
                this.RaisePropertyChanged("StPflichtArbLohnMKalJahr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StPflichtArbLohnMKalJahrSpecified {
            get {
                return this.stPflichtArbLohnMKalJahrFieldSpecified;
            }
            set {
                this.stPflichtArbLohnMKalJahrFieldSpecified = value;
                this.RaisePropertyChanged("StPflichtArbLohnMKalJahrSpecified");
            }
        }
        
        /// <remarks/>
        public decimal StFreiVerpfleg {
            get {
                return this.stFreiVerpflegField;
            }
            set {
                this.stFreiVerpflegField = value;
                this.RaisePropertyChanged("StFreiVerpfleg");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiVerpflegSpecified {
            get {
                return this.stFreiVerpflegFieldSpecified;
            }
            set {
                this.stFreiVerpflegFieldSpecified = value;
                this.RaisePropertyChanged("StFreiVerpflegSpecified");
            }
        }
        
        /// <remarks/>
        public decimal StFreiDopHaushalt {
            get {
                return this.stFreiDopHaushaltField;
            }
            set {
                this.stFreiDopHaushaltField = value;
                this.RaisePropertyChanged("StFreiDopHaushalt");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiDopHaushaltSpecified {
            get {
                return this.stFreiDopHaushaltFieldSpecified;
            }
            set {
                this.stFreiDopHaushaltFieldSpecified = value;
                this.RaisePropertyChanged("StFreiDopHaushaltSpecified");
            }
        }
        
        /// <remarks/>
        public decimal ArbgAnteilRenVers {
            get {
                return this.arbgAnteilRenVersField;
            }
            set {
                this.arbgAnteilRenVersField = value;
                this.RaisePropertyChanged("ArbgAnteilRenVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbgAnteilRenVersSpecified {
            get {
                return this.arbgAnteilRenVersFieldSpecified;
            }
            set {
                this.arbgAnteilRenVersFieldSpecified = value;
                this.RaisePropertyChanged("ArbgAnteilRenVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal ArbgAnteilBerufsVers {
            get {
                return this.arbgAnteilBerufsVersField;
            }
            set {
                this.arbgAnteilBerufsVersField = value;
                this.RaisePropertyChanged("ArbgAnteilBerufsVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbgAnteilBerufsVersSpecified {
            get {
                return this.arbgAnteilBerufsVersFieldSpecified;
            }
            set {
                this.arbgAnteilBerufsVersFieldSpecified = value;
                this.RaisePropertyChanged("ArbgAnteilBerufsVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal ArbnAnteilRenVers {
            get {
                return this.arbnAnteilRenVersField;
            }
            set {
                this.arbnAnteilRenVersField = value;
                this.RaisePropertyChanged("ArbnAnteilRenVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbnAnteilRenVersSpecified {
            get {
                return this.arbnAnteilRenVersFieldSpecified;
            }
            set {
                this.arbnAnteilRenVersFieldSpecified = value;
                this.RaisePropertyChanged("ArbnAnteilRenVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal ArbnAnteilBerufsVers {
            get {
                return this.arbnAnteilBerufsVersField;
            }
            set {
                this.arbnAnteilBerufsVersField = value;
                this.RaisePropertyChanged("ArbnAnteilBerufsVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbnAnteilBerufsVersSpecified {
            get {
                return this.arbnAnteilBerufsVersFieldSpecified;
            }
            set {
                this.arbnAnteilBerufsVersFieldSpecified = value;
                this.RaisePropertyChanged("ArbnAnteilBerufsVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal StFreiGeKrankVers {
            get {
                return this.stFreiGeKrankVersField;
            }
            set {
                this.stFreiGeKrankVersField = value;
                this.RaisePropertyChanged("StFreiGeKrankVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiGeKrankVersSpecified {
            get {
                return this.stFreiGeKrankVersFieldSpecified;
            }
            set {
                this.stFreiGeKrankVersFieldSpecified = value;
                this.RaisePropertyChanged("StFreiGeKrankVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal StFreiPrKrankVers {
            get {
                return this.stFreiPrKrankVersField;
            }
            set {
                this.stFreiPrKrankVersField = value;
                this.RaisePropertyChanged("StFreiPrKrankVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiPrKrankVersSpecified {
            get {
                return this.stFreiPrKrankVersFieldSpecified;
            }
            set {
                this.stFreiPrKrankVersFieldSpecified = value;
                this.RaisePropertyChanged("StFreiPrKrankVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal StFreiGePflegeVers {
            get {
                return this.stFreiGePflegeVersField;
            }
            set {
                this.stFreiGePflegeVersField = value;
                this.RaisePropertyChanged("StFreiGePflegeVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiGePflegeVersSpecified {
            get {
                return this.stFreiGePflegeVersFieldSpecified;
            }
            set {
                this.stFreiGePflegeVersFieldSpecified = value;
                this.RaisePropertyChanged("StFreiGePflegeVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal ArbnAnteilKrankVers {
            get {
                return this.arbnAnteilKrankVersField;
            }
            set {
                this.arbnAnteilKrankVersField = value;
                this.RaisePropertyChanged("ArbnAnteilKrankVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbnAnteilKrankVersSpecified {
            get {
                return this.arbnAnteilKrankVersFieldSpecified;
            }
            set {
                this.arbnAnteilKrankVersFieldSpecified = value;
                this.RaisePropertyChanged("ArbnAnteilKrankVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal ArbnAnteilPflegVers {
            get {
                return this.arbnAnteilPflegVersField;
            }
            set {
                this.arbnAnteilPflegVersField = value;
                this.RaisePropertyChanged("ArbnAnteilPflegVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbnAnteilPflegVersSpecified {
            get {
                return this.arbnAnteilPflegVersFieldSpecified;
            }
            set {
                this.arbnAnteilPflegVersFieldSpecified = value;
                this.RaisePropertyChanged("ArbnAnteilPflegVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal ArbnAnteilArblVers {
            get {
                return this.arbnAnteilArblVersField;
            }
            set {
                this.arbnAnteilArblVersField = value;
                this.RaisePropertyChanged("ArbnAnteilArblVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbnAnteilArblVersSpecified {
            get {
                return this.arbnAnteilArblVersFieldSpecified;
            }
            set {
                this.arbnAnteilArblVersFieldSpecified = value;
                this.RaisePropertyChanged("ArbnAnteilArblVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal BeitrPrKrankVers {
            get {
                return this.beitrPrKrankVersField;
            }
            set {
                this.beitrPrKrankVersField = value;
                this.RaisePropertyChanged("BeitrPrKrankVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BeitrPrKrankVersSpecified {
            get {
                return this.beitrPrKrankVersFieldSpecified;
            }
            set {
                this.beitrPrKrankVersFieldSpecified = value;
                this.RaisePropertyChanged("BeitrPrKrankVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal AusgezKinderGeld {
            get {
                return this.ausgezKinderGeldField;
            }
            set {
                this.ausgezKinderGeldField = value;
                this.RaisePropertyChanged("AusgezKinderGeld");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AusgezKinderGeldSpecified {
            get {
                return this.ausgezKinderGeldFieldSpecified;
            }
            set {
                this.ausgezKinderGeldFieldSpecified = value;
                this.RaisePropertyChanged("AusgezKinderGeldSpecified");
            }
        }
        
        /// <remarks/>
        public string Grossbuchstaben {
            get {
                return this.grossbuchstabenField;
            }
            set {
                this.grossbuchstabenField = value;
                this.RaisePropertyChanged("Grossbuchstaben");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Kammerbeitrag")]
        public System.Collections.Generic.List<LStB201401.lstb_BesteuerungsgrundlagenCTypeKammerbeitrag> Kammerbeitrag {
            get {
                return this.kammerbeitragField;
            }
            set {
                this.kammerbeitragField = value;
                this.RaisePropertyChanged("Kammerbeitrag");
            }
        }
        
        /// <remarks/>
        public decimal ArbnAnteilWBUmlage {
            get {
                return this.arbnAnteilWBUmlageField;
            }
            set {
                this.arbnAnteilWBUmlageField = value;
                this.RaisePropertyChanged("ArbnAnteilWBUmlage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbnAnteilWBUmlageSpecified {
            get {
                return this.arbnAnteilWBUmlageFieldSpecified;
            }
            set {
                this.arbnAnteilWBUmlageFieldSpecified = value;
                this.RaisePropertyChanged("ArbnAnteilWBUmlageSpecified");
            }
        }
        
        /// <remarks/>
        public decimal ArbgAnteilZusatzVers {
            get {
                return this.arbgAnteilZusatzVersField;
            }
            set {
                this.arbgAnteilZusatzVersField = value;
                this.RaisePropertyChanged("ArbgAnteilZusatzVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbgAnteilZusatzVersSpecified {
            get {
                return this.arbgAnteilZusatzVersFieldSpecified;
            }
            set {
                this.arbgAnteilZusatzVersFieldSpecified = value;
                this.RaisePropertyChanged("ArbgAnteilZusatzVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal ArbnAnteilZusatzVers {
            get {
                return this.arbnAnteilZusatzVersField;
            }
            set {
                this.arbnAnteilZusatzVersField = value;
                this.RaisePropertyChanged("ArbnAnteilZusatzVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbnAnteilZusatzVersSpecified {
            get {
                return this.arbnAnteilZusatzVersFieldSpecified;
            }
            set {
                this.arbnAnteilZusatzVersFieldSpecified = value;
                this.RaisePropertyChanged("ArbnAnteilZusatzVersSpecified");
            }
        }
        
        /// <remarks/>
        public int AnzahlArbTag {
            get {
                return this.anzahlArbTagField;
            }
            set {
                this.anzahlArbTagField = value;
                this.RaisePropertyChanged("AnzahlArbTag");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnzahlArbTagSpecified {
            get {
                return this.anzahlArbTagFieldSpecified;
            }
            set {
                this.anzahlArbTagFieldSpecified = value;
                this.RaisePropertyChanged("AnzahlArbTagSpecified");
            }
        }
        
        /// <remarks/>
        public decimal StFreiFahrtKAusw {
            get {
                return this.stFreiFahrtKAuswField;
            }
            set {
                this.stFreiFahrtKAuswField = value;
                this.RaisePropertyChanged("StFreiFahrtKAusw");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiFahrtKAuswSpecified {
            get {
                return this.stFreiFahrtKAuswFieldSpecified;
            }
            set {
                this.stFreiFahrtKAuswFieldSpecified = value;
                this.RaisePropertyChanged("StFreiFahrtKAuswSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NErmStVBezMKalJahr")]
        public System.Collections.Generic.List<LStB201401.lstb_BesteuerungsgrundlagenCTypeNErmStVBezMKalJahr> NErmStVBezMKalJahr {
            get {
                return this.nErmStVBezMKalJahrField;
            }
            set {
                this.nErmStVBezMKalJahrField = value;
                this.RaisePropertyChanged("NErmStVBezMKalJahr");
            }
        }
        
        /// <remarks/>
        public decimal StFreiArbgZuschBerufsVers {
            get {
                return this.stFreiArbgZuschBerufsVersField;
            }
            set {
                this.stFreiArbgZuschBerufsVersField = value;
                this.RaisePropertyChanged("StFreiArbgZuschBerufsVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiArbgZuschBerufsVersSpecified {
            get {
                return this.stFreiArbgZuschBerufsVersFieldSpecified;
            }
            set {
                this.stFreiArbgZuschBerufsVersFieldSpecified = value;
                this.RaisePropertyChanged("StFreiArbgZuschBerufsVersSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Wert")]
        public System.Collections.Generic.List<LStB201401.lstb_BesteuerungsgrundlagenCTypeWert> Wert {
            get {
                return this.wertField;
            }
            set {
                this.wertField = value;
                this.RaisePropertyChanged("Wert");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Text")]
        public System.Collections.Generic.List<LStB201401.lstb_BesteuerungsgrundlagenCTypeText> Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
                this.RaisePropertyChanged("Text");
            }
        }
        
        /// <remarks/>
        public LStB201401.lstb_ArbeitgeberCType Arbeitgeber {
            get {
                return this.arbeitgeberField;
            }
            set {
                this.arbeitgeberField = value;
                this.RaisePropertyChanged("Arbeitgeber");
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