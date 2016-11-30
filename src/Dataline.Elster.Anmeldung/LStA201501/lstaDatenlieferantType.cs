namespace Dataline.Elster.Anmeldung.LStA201501
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThrough()]
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
                return nameField;
            }
            set {
                nameField = value;
                RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        public string Strasse {
            get {
                return strasseField;
            }
            set {
                strasseField = value;
                RaisePropertyChanged("Strasse");
            }
        }
        
        /// <remarks/>
        public string PLZ {
            get {
                return pLZField;
            }
            set {
                pLZField = value;
                RaisePropertyChanged("PLZ");
            }
        }
        
        /// <remarks/>
        public string Ort {
            get {
                return ortField;
            }
            set {
                ortField = value;
                RaisePropertyChanged("Ort");
            }
        }
        
        /// <remarks/>
        public string Telefon {
            get {
                return telefonField;
            }
            set {
                telefonField = value;
                RaisePropertyChanged("Telefon");
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return emailField;
            }
            set {
                emailField = value;
                RaisePropertyChanged("Email");
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
