﻿namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code")]
    public class VariableNullFields : INotifyPropertyChanged
    {
        private bool folderField = false;
        private bool interfaceValuesField = false;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Folder
        {
            get
            {
                return this.folderField;
            }
            set
            {
                this.folderField = value;
                this.RaisePropertyChanged("Folder");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool InterfaceValues
        {
            get
            {
                return this.interfaceValuesField;
            }
            set
            {
                this.interfaceValuesField = value;
                this.RaisePropertyChanged("InterfaceValues");
            }
        }
    }
}

