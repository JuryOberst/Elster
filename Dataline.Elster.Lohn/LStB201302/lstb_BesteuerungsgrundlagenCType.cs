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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="lstb_BesteuerungsgrundlagenCType", Namespace="http://www.elsterlohn.de/2013-02/XMLSchema")]
    public partial class lstb_BesteuerungsgrundlagenCType: object, System.ComponentModel.INotifyPropertyChanged {
        
        private string anzahlUField;
        
        private decimal bruttoArbLohnField;
        
        private decimal lSteuerField;
        
        private decimal soliField;
        
        private decimal arbnKiSteuerField;
        
        private bool arbnKiSteuerFieldSpecified;
        
        private decimal ehegKiSteuerField;
        
        private bool ehegKiSteuerFieldSpecified;
        
        private System.Collections.Generic.List<LStB201302.lstb_BesteuerungsgrundlagenCTypeVBez> vBezField;
        
        private System.Collections.Generic.List<LStB201302.lstb_BesteuerungsgrundlagenCTypeErmStVBezMKalJahr> ermStVBezMKalJahrField;
        
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
        
        private System.Collections.Generic.List<LStB201302.lstb_BesteuerungsgrundlagenCTypeKammerbeitrag> kammerbeitragField;
        
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
        
        private System.Collections.Generic.List<LStB201302.lstb_BesteuerungsgrundlagenCTypeNErmStVBezMKalJahr> nErmStVBezMKalJahrField;
        
        private decimal stFreiArbgZuschBerufsVersField;
        
        private bool stFreiArbgZuschBerufsVersFieldSpecified;
        
        private System.Collections.Generic.List<LStB201302.lstb_BesteuerungsgrundlagenCTypeWert> wertField;
        
        private System.Collections.Generic.List<LStB201302.lstb_BesteuerungsgrundlagenCTypeText> textField;
        
        private LStB201302.lstb_ArbeitgeberCType arbeitgeberField;
        
        /// <remarks/>
        public string AnzahlU {
            get {
                return anzahlUField;
            }
            set {
                anzahlUField = value;
                RaisePropertyChanged("AnzahlU");
            }
        }
        
        /// <remarks/>
        public decimal BruttoArbLohn {
            get {
                return bruttoArbLohnField;
            }
            set {
                bruttoArbLohnField = value;
                RaisePropertyChanged("BruttoArbLohn");
            }
        }
        
        /// <remarks/>
        public decimal LSteuer {
            get {
                return lSteuerField;
            }
            set {
                lSteuerField = value;
                RaisePropertyChanged("LSteuer");
            }
        }
        
        /// <remarks/>
        public decimal Soli {
            get {
                return soliField;
            }
            set {
                soliField = value;
                RaisePropertyChanged("Soli");
            }
        }
        
        /// <remarks/>
        public decimal ArbnKiSteuer {
            get {
                return arbnKiSteuerField;
            }
            set {
                arbnKiSteuerField = value;
                RaisePropertyChanged("ArbnKiSteuer");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbnKiSteuerSpecified {
            get {
                return arbnKiSteuerFieldSpecified;
            }
            set {
                arbnKiSteuerFieldSpecified = value;
                RaisePropertyChanged("ArbnKiSteuerSpecified");
            }
        }
        
        /// <remarks/>
        public decimal EhegKiSteuer {
            get {
                return ehegKiSteuerField;
            }
            set {
                ehegKiSteuerField = value;
                RaisePropertyChanged("EhegKiSteuer");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EhegKiSteuerSpecified {
            get {
                return ehegKiSteuerFieldSpecified;
            }
            set {
                ehegKiSteuerFieldSpecified = value;
                RaisePropertyChanged("EhegKiSteuerSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VBez")]
        public System.Collections.Generic.List<LStB201302.lstb_BesteuerungsgrundlagenCTypeVBez> VBez {
            get {
                return vBezField;
            }
            set {
                vBezField = value;
                RaisePropertyChanged("VBez");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ErmStVBezMKalJahr")]
        public System.Collections.Generic.List<LStB201302.lstb_BesteuerungsgrundlagenCTypeErmStVBezMKalJahr> ErmStVBezMKalJahr {
            get {
                return ermStVBezMKalJahrField;
            }
            set {
                ermStVBezMKalJahrField = value;
                RaisePropertyChanged("ErmStVBezMKalJahr");
            }
        }
        
        /// <remarks/>
        public decimal ErmStBetrMKalJahr {
            get {
                return ermStBetrMKalJahrField;
            }
            set {
                ermStBetrMKalJahrField = value;
                RaisePropertyChanged("ErmStBetrMKalJahr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ErmStBetrMKalJahrSpecified {
            get {
                return ermStBetrMKalJahrFieldSpecified;
            }
            set {
                ermStBetrMKalJahrFieldSpecified = value;
                RaisePropertyChanged("ErmStBetrMKalJahrSpecified");
            }
        }
        
        /// <remarks/>
        public decimal LSteuerMKalJahr {
            get {
                return lSteuerMKalJahrField;
            }
            set {
                lSteuerMKalJahrField = value;
                RaisePropertyChanged("LSteuerMKalJahr");
            }
        }
        
        /// <remarks/>
        public decimal SoliMKalJahr {
            get {
                return soliMKalJahrField;
            }
            set {
                soliMKalJahrField = value;
                RaisePropertyChanged("SoliMKalJahr");
            }
        }
        
        /// <remarks/>
        public decimal KiSteuerArbnMKalJahr {
            get {
                return kiSteuerArbnMKalJahrField;
            }
            set {
                kiSteuerArbnMKalJahrField = value;
                RaisePropertyChanged("KiSteuerArbnMKalJahr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KiSteuerArbnMKalJahrSpecified {
            get {
                return kiSteuerArbnMKalJahrFieldSpecified;
            }
            set {
                kiSteuerArbnMKalJahrFieldSpecified = value;
                RaisePropertyChanged("KiSteuerArbnMKalJahrSpecified");
            }
        }
        
        /// <remarks/>
        public decimal KiSteuerEhegMKalJahr {
            get {
                return kiSteuerEhegMKalJahrField;
            }
            set {
                kiSteuerEhegMKalJahrField = value;
                RaisePropertyChanged("KiSteuerEhegMKalJahr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KiSteuerEhegMKalJahrSpecified {
            get {
                return kiSteuerEhegMKalJahrFieldSpecified;
            }
            set {
                kiSteuerEhegMKalJahrFieldSpecified = value;
                RaisePropertyChanged("KiSteuerEhegMKalJahrSpecified");
            }
        }
        
        /// <remarks/>
        public decimal KurzArbGeld {
            get {
                return kurzArbGeldField;
            }
            set {
                kurzArbGeldField = value;
                RaisePropertyChanged("KurzArbGeld");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KurzArbGeldSpecified {
            get {
                return kurzArbGeldFieldSpecified;
            }
            set {
                kurzArbGeldFieldSpecified = value;
                RaisePropertyChanged("KurzArbGeldSpecified");
            }
        }
        
        /// <remarks/>
        public decimal StFreiArbLohnDBA {
            get {
                return stFreiArbLohnDBAField;
            }
            set {
                stFreiArbLohnDBAField = value;
                RaisePropertyChanged("StFreiArbLohnDBA");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiArbLohnDBASpecified {
            get {
                return stFreiArbLohnDBAFieldSpecified;
            }
            set {
                stFreiArbLohnDBAFieldSpecified = value;
                RaisePropertyChanged("StFreiArbLohnDBASpecified");
            }
        }
        
        /// <remarks/>
        public decimal StFreiArbLohnATE {
            get {
                return stFreiArbLohnATEField;
            }
            set {
                stFreiArbLohnATEField = value;
                RaisePropertyChanged("StFreiArbLohnATE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiArbLohnATESpecified {
            get {
                return stFreiArbLohnATEFieldSpecified;
            }
            set {
                stFreiArbLohnATEFieldSpecified = value;
                RaisePropertyChanged("StFreiArbLohnATESpecified");
            }
        }
        
        /// <remarks/>
        public decimal StFreiArbgLeistg {
            get {
                return stFreiArbgLeistgField;
            }
            set {
                stFreiArbgLeistgField = value;
                RaisePropertyChanged("StFreiArbgLeistg");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiArbgLeistgSpecified {
            get {
                return stFreiArbgLeistgFieldSpecified;
            }
            set {
                stFreiArbgLeistgFieldSpecified = value;
                RaisePropertyChanged("StFreiArbgLeistgSpecified");
            }
        }
        
        /// <remarks/>
        public decimal PauschArbgLeistg {
            get {
                return pauschArbgLeistgField;
            }
            set {
                pauschArbgLeistgField = value;
                RaisePropertyChanged("PauschArbgLeistg");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PauschArbgLeistgSpecified {
            get {
                return pauschArbgLeistgFieldSpecified;
            }
            set {
                pauschArbgLeistgFieldSpecified = value;
                RaisePropertyChanged("PauschArbgLeistgSpecified");
            }
        }
        
        /// <remarks/>
        public decimal StPflichtArbLohnMKalJahr {
            get {
                return stPflichtArbLohnMKalJahrField;
            }
            set {
                stPflichtArbLohnMKalJahrField = value;
                RaisePropertyChanged("StPflichtArbLohnMKalJahr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StPflichtArbLohnMKalJahrSpecified {
            get {
                return stPflichtArbLohnMKalJahrFieldSpecified;
            }
            set {
                stPflichtArbLohnMKalJahrFieldSpecified = value;
                RaisePropertyChanged("StPflichtArbLohnMKalJahrSpecified");
            }
        }
        
        /// <remarks/>
        public decimal StFreiVerpfleg {
            get {
                return stFreiVerpflegField;
            }
            set {
                stFreiVerpflegField = value;
                RaisePropertyChanged("StFreiVerpfleg");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiVerpflegSpecified {
            get {
                return stFreiVerpflegFieldSpecified;
            }
            set {
                stFreiVerpflegFieldSpecified = value;
                RaisePropertyChanged("StFreiVerpflegSpecified");
            }
        }
        
        /// <remarks/>
        public decimal StFreiDopHaushalt {
            get {
                return stFreiDopHaushaltField;
            }
            set {
                stFreiDopHaushaltField = value;
                RaisePropertyChanged("StFreiDopHaushalt");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiDopHaushaltSpecified {
            get {
                return stFreiDopHaushaltFieldSpecified;
            }
            set {
                stFreiDopHaushaltFieldSpecified = value;
                RaisePropertyChanged("StFreiDopHaushaltSpecified");
            }
        }
        
        /// <remarks/>
        public decimal ArbgAnteilRenVers {
            get {
                return arbgAnteilRenVersField;
            }
            set {
                arbgAnteilRenVersField = value;
                RaisePropertyChanged("ArbgAnteilRenVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbgAnteilRenVersSpecified {
            get {
                return arbgAnteilRenVersFieldSpecified;
            }
            set {
                arbgAnteilRenVersFieldSpecified = value;
                RaisePropertyChanged("ArbgAnteilRenVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal ArbgAnteilBerufsVers {
            get {
                return arbgAnteilBerufsVersField;
            }
            set {
                arbgAnteilBerufsVersField = value;
                RaisePropertyChanged("ArbgAnteilBerufsVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbgAnteilBerufsVersSpecified {
            get {
                return arbgAnteilBerufsVersFieldSpecified;
            }
            set {
                arbgAnteilBerufsVersFieldSpecified = value;
                RaisePropertyChanged("ArbgAnteilBerufsVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal ArbnAnteilRenVers {
            get {
                return arbnAnteilRenVersField;
            }
            set {
                arbnAnteilRenVersField = value;
                RaisePropertyChanged("ArbnAnteilRenVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbnAnteilRenVersSpecified {
            get {
                return arbnAnteilRenVersFieldSpecified;
            }
            set {
                arbnAnteilRenVersFieldSpecified = value;
                RaisePropertyChanged("ArbnAnteilRenVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal ArbnAnteilBerufsVers {
            get {
                return arbnAnteilBerufsVersField;
            }
            set {
                arbnAnteilBerufsVersField = value;
                RaisePropertyChanged("ArbnAnteilBerufsVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbnAnteilBerufsVersSpecified {
            get {
                return arbnAnteilBerufsVersFieldSpecified;
            }
            set {
                arbnAnteilBerufsVersFieldSpecified = value;
                RaisePropertyChanged("ArbnAnteilBerufsVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal StFreiGeKrankVers {
            get {
                return stFreiGeKrankVersField;
            }
            set {
                stFreiGeKrankVersField = value;
                RaisePropertyChanged("StFreiGeKrankVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiGeKrankVersSpecified {
            get {
                return stFreiGeKrankVersFieldSpecified;
            }
            set {
                stFreiGeKrankVersFieldSpecified = value;
                RaisePropertyChanged("StFreiGeKrankVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal StFreiPrKrankVers {
            get {
                return stFreiPrKrankVersField;
            }
            set {
                stFreiPrKrankVersField = value;
                RaisePropertyChanged("StFreiPrKrankVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiPrKrankVersSpecified {
            get {
                return stFreiPrKrankVersFieldSpecified;
            }
            set {
                stFreiPrKrankVersFieldSpecified = value;
                RaisePropertyChanged("StFreiPrKrankVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal StFreiGePflegeVers {
            get {
                return stFreiGePflegeVersField;
            }
            set {
                stFreiGePflegeVersField = value;
                RaisePropertyChanged("StFreiGePflegeVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiGePflegeVersSpecified {
            get {
                return stFreiGePflegeVersFieldSpecified;
            }
            set {
                stFreiGePflegeVersFieldSpecified = value;
                RaisePropertyChanged("StFreiGePflegeVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal ArbnAnteilKrankVers {
            get {
                return arbnAnteilKrankVersField;
            }
            set {
                arbnAnteilKrankVersField = value;
                RaisePropertyChanged("ArbnAnteilKrankVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbnAnteilKrankVersSpecified {
            get {
                return arbnAnteilKrankVersFieldSpecified;
            }
            set {
                arbnAnteilKrankVersFieldSpecified = value;
                RaisePropertyChanged("ArbnAnteilKrankVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal ArbnAnteilPflegVers {
            get {
                return arbnAnteilPflegVersField;
            }
            set {
                arbnAnteilPflegVersField = value;
                RaisePropertyChanged("ArbnAnteilPflegVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbnAnteilPflegVersSpecified {
            get {
                return arbnAnteilPflegVersFieldSpecified;
            }
            set {
                arbnAnteilPflegVersFieldSpecified = value;
                RaisePropertyChanged("ArbnAnteilPflegVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal ArbnAnteilArblVers {
            get {
                return arbnAnteilArblVersField;
            }
            set {
                arbnAnteilArblVersField = value;
                RaisePropertyChanged("ArbnAnteilArblVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbnAnteilArblVersSpecified {
            get {
                return arbnAnteilArblVersFieldSpecified;
            }
            set {
                arbnAnteilArblVersFieldSpecified = value;
                RaisePropertyChanged("ArbnAnteilArblVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal BeitrPrKrankVers {
            get {
                return beitrPrKrankVersField;
            }
            set {
                beitrPrKrankVersField = value;
                RaisePropertyChanged("BeitrPrKrankVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BeitrPrKrankVersSpecified {
            get {
                return beitrPrKrankVersFieldSpecified;
            }
            set {
                beitrPrKrankVersFieldSpecified = value;
                RaisePropertyChanged("BeitrPrKrankVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal AusgezKinderGeld {
            get {
                return ausgezKinderGeldField;
            }
            set {
                ausgezKinderGeldField = value;
                RaisePropertyChanged("AusgezKinderGeld");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AusgezKinderGeldSpecified {
            get {
                return ausgezKinderGeldFieldSpecified;
            }
            set {
                ausgezKinderGeldFieldSpecified = value;
                RaisePropertyChanged("AusgezKinderGeldSpecified");
            }
        }
        
        /// <remarks/>
        public string Grossbuchstaben {
            get {
                return grossbuchstabenField;
            }
            set {
                grossbuchstabenField = value;
                RaisePropertyChanged("Grossbuchstaben");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Kammerbeitrag")]
        public System.Collections.Generic.List<LStB201302.lstb_BesteuerungsgrundlagenCTypeKammerbeitrag> Kammerbeitrag {
            get {
                return kammerbeitragField;
            }
            set {
                kammerbeitragField = value;
                RaisePropertyChanged("Kammerbeitrag");
            }
        }
        
        /// <remarks/>
        public decimal ArbnAnteilWBUmlage {
            get {
                return arbnAnteilWBUmlageField;
            }
            set {
                arbnAnteilWBUmlageField = value;
                RaisePropertyChanged("ArbnAnteilWBUmlage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbnAnteilWBUmlageSpecified {
            get {
                return arbnAnteilWBUmlageFieldSpecified;
            }
            set {
                arbnAnteilWBUmlageFieldSpecified = value;
                RaisePropertyChanged("ArbnAnteilWBUmlageSpecified");
            }
        }
        
        /// <remarks/>
        public decimal ArbgAnteilZusatzVers {
            get {
                return arbgAnteilZusatzVersField;
            }
            set {
                arbgAnteilZusatzVersField = value;
                RaisePropertyChanged("ArbgAnteilZusatzVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbgAnteilZusatzVersSpecified {
            get {
                return arbgAnteilZusatzVersFieldSpecified;
            }
            set {
                arbgAnteilZusatzVersFieldSpecified = value;
                RaisePropertyChanged("ArbgAnteilZusatzVersSpecified");
            }
        }
        
        /// <remarks/>
        public decimal ArbnAnteilZusatzVers {
            get {
                return arbnAnteilZusatzVersField;
            }
            set {
                arbnAnteilZusatzVersField = value;
                RaisePropertyChanged("ArbnAnteilZusatzVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArbnAnteilZusatzVersSpecified {
            get {
                return arbnAnteilZusatzVersFieldSpecified;
            }
            set {
                arbnAnteilZusatzVersFieldSpecified = value;
                RaisePropertyChanged("ArbnAnteilZusatzVersSpecified");
            }
        }
        
        /// <remarks/>
        public int AnzahlArbTag {
            get {
                return anzahlArbTagField;
            }
            set {
                anzahlArbTagField = value;
                RaisePropertyChanged("AnzahlArbTag");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnzahlArbTagSpecified {
            get {
                return anzahlArbTagFieldSpecified;
            }
            set {
                anzahlArbTagFieldSpecified = value;
                RaisePropertyChanged("AnzahlArbTagSpecified");
            }
        }
        
        /// <remarks/>
        public decimal StFreiFahrtKAusw {
            get {
                return stFreiFahrtKAuswField;
            }
            set {
                stFreiFahrtKAuswField = value;
                RaisePropertyChanged("StFreiFahrtKAusw");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiFahrtKAuswSpecified {
            get {
                return stFreiFahrtKAuswFieldSpecified;
            }
            set {
                stFreiFahrtKAuswFieldSpecified = value;
                RaisePropertyChanged("StFreiFahrtKAuswSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NErmStVBezMKalJahr")]
        public System.Collections.Generic.List<LStB201302.lstb_BesteuerungsgrundlagenCTypeNErmStVBezMKalJahr> NErmStVBezMKalJahr {
            get {
                return nErmStVBezMKalJahrField;
            }
            set {
                nErmStVBezMKalJahrField = value;
                RaisePropertyChanged("NErmStVBezMKalJahr");
            }
        }
        
        /// <remarks/>
        public decimal StFreiArbgZuschBerufsVers {
            get {
                return stFreiArbgZuschBerufsVersField;
            }
            set {
                stFreiArbgZuschBerufsVersField = value;
                RaisePropertyChanged("StFreiArbgZuschBerufsVers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StFreiArbgZuschBerufsVersSpecified {
            get {
                return stFreiArbgZuschBerufsVersFieldSpecified;
            }
            set {
                stFreiArbgZuschBerufsVersFieldSpecified = value;
                RaisePropertyChanged("StFreiArbgZuschBerufsVersSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Wert")]
        public System.Collections.Generic.List<LStB201302.lstb_BesteuerungsgrundlagenCTypeWert> Wert {
            get {
                return wertField;
            }
            set {
                wertField = value;
                RaisePropertyChanged("Wert");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Text")]
        public System.Collections.Generic.List<LStB201302.lstb_BesteuerungsgrundlagenCTypeText> Text {
            get {
                return textField;
            }
            set {
                textField = value;
                RaisePropertyChanged("Text");
            }
        }
        
        /// <remarks/>
        public LStB201302.lstb_ArbeitgeberCType Arbeitgeber {
            get {
                return arbeitgeberField;
            }
            set {
                arbeitgeberField = value;
                RaisePropertyChanged("Arbeitgeber");
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