namespace Dataline.Elster.Anmeldung.LStA201501
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.elster.de/2002/XMLSchema")]
    public partial class lstaSteuerfallType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private AdresseCType beraterField;
        
        private MandantCType mandantField;
        
        private AdresseCType unternehmerField;
        
        private lstaSteuerfallTypeLohnsteueranmeldung lohnsteueranmeldungField;
        
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
        public lstaSteuerfallTypeLohnsteueranmeldung Lohnsteueranmeldung {
            get {
                return lohnsteueranmeldungField;
            }
            set {
                lohnsteueranmeldungField = value;
                RaisePropertyChanged("Lohnsteueranmeldung");
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
