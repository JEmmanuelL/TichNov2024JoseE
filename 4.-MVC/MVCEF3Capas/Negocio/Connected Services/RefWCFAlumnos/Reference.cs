﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Negocio.RefWCFAlumnos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AportacionesIMSS", Namespace="http://schemas.datacontract.org/2004/07/WCFAlumnos")]
    [System.SerializableAttribute()]
    public partial class AportacionesIMSS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal CesantiaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal EnfermedadMaternidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal InfonavitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal InvalidezVidaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal RetiroField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Cesantia {
            get {
                return this.CesantiaField;
            }
            set {
                if ((this.CesantiaField.Equals(value) != true)) {
                    this.CesantiaField = value;
                    this.RaisePropertyChanged("Cesantia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal EnfermedadMaternidad {
            get {
                return this.EnfermedadMaternidadField;
            }
            set {
                if ((this.EnfermedadMaternidadField.Equals(value) != true)) {
                    this.EnfermedadMaternidadField = value;
                    this.RaisePropertyChanged("EnfermedadMaternidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Infonavit {
            get {
                return this.InfonavitField;
            }
            set {
                if ((this.InfonavitField.Equals(value) != true)) {
                    this.InfonavitField = value;
                    this.RaisePropertyChanged("Infonavit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal InvalidezVida {
            get {
                return this.InvalidezVidaField;
            }
            set {
                if ((this.InvalidezVidaField.Equals(value) != true)) {
                    this.InvalidezVidaField = value;
                    this.RaisePropertyChanged("InvalidezVida");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Retiro {
            get {
                return this.RetiroField;
            }
            set {
                if ((this.RetiroField.Equals(value) != true)) {
                    this.RetiroField = value;
                    this.RaisePropertyChanged("Retiro");
                }
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ItemTablaISR", Namespace="http://schemas.datacontract.org/2004/07/WCFAlumnos")]
    [System.SerializableAttribute()]
    public partial class ItemTablaISR : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal CuotaFijaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ExcedenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ISRField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal LimitInfField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal LimitSupField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal SubsidioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal CuotaFija {
            get {
                return this.CuotaFijaField;
            }
            set {
                if ((this.CuotaFijaField.Equals(value) != true)) {
                    this.CuotaFijaField = value;
                    this.RaisePropertyChanged("CuotaFija");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Excedente {
            get {
                return this.ExcedenteField;
            }
            set {
                if ((this.ExcedenteField.Equals(value) != true)) {
                    this.ExcedenteField = value;
                    this.RaisePropertyChanged("Excedente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ISR {
            get {
                return this.ISRField;
            }
            set {
                if ((this.ISRField.Equals(value) != true)) {
                    this.ISRField = value;
                    this.RaisePropertyChanged("ISR");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal LimitInf {
            get {
                return this.LimitInfField;
            }
            set {
                if ((this.LimitInfField.Equals(value) != true)) {
                    this.LimitInfField = value;
                    this.RaisePropertyChanged("LimitInf");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal LimitSup {
            get {
                return this.LimitSupField;
            }
            set {
                if ((this.LimitSupField.Equals(value) != true)) {
                    this.LimitSupField = value;
                    this.RaisePropertyChanged("LimitSup");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Subsidio {
            get {
                return this.SubsidioField;
            }
            set {
                if ((this.SubsidioField.Equals(value) != true)) {
                    this.SubsidioField = value;
                    this.RaisePropertyChanged("Subsidio");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RefWCFAlumnos.IWCFAlumnos")]
    public interface IWCFAlumnos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAlumnos/CalcularIMSS", ReplyAction="http://tempuri.org/IWCFAlumnos/CalcularIMSSResponse")]
        Negocio.RefWCFAlumnos.AportacionesIMSS CalcularIMSS(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAlumnos/CalcularIMSS", ReplyAction="http://tempuri.org/IWCFAlumnos/CalcularIMSSResponse")]
        System.Threading.Tasks.Task<Negocio.RefWCFAlumnos.AportacionesIMSS> CalcularIMSSAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAlumnos/CalcularISR1", ReplyAction="http://tempuri.org/IWCFAlumnos/CalcularISR1Response")]
        Negocio.RefWCFAlumnos.ItemTablaISR CalcularISR1(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAlumnos/CalcularISR1", ReplyAction="http://tempuri.org/IWCFAlumnos/CalcularISR1Response")]
        System.Threading.Tasks.Task<Negocio.RefWCFAlumnos.ItemTablaISR> CalcularISR1Async(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWCFAlumnosChannel : Negocio.RefWCFAlumnos.IWCFAlumnos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFAlumnosClient : System.ServiceModel.ClientBase<Negocio.RefWCFAlumnos.IWCFAlumnos>, Negocio.RefWCFAlumnos.IWCFAlumnos {
        
        public WCFAlumnosClient() {
        }
        
        public WCFAlumnosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFAlumnosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFAlumnosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFAlumnosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Negocio.RefWCFAlumnos.AportacionesIMSS CalcularIMSS(int id) {
            return base.Channel.CalcularIMSS(id);
        }
        
        public System.Threading.Tasks.Task<Negocio.RefWCFAlumnos.AportacionesIMSS> CalcularIMSSAsync(int id) {
            return base.Channel.CalcularIMSSAsync(id);
        }
        
        public Negocio.RefWCFAlumnos.ItemTablaISR CalcularISR1(int id) {
            return base.Channel.CalcularISR1(id);
        }
        
        public System.Threading.Tasks.Task<Negocio.RefWCFAlumnos.ItemTablaISR> CalcularISR1Async(int id) {
            return base.Channel.CalcularISR1Async(id);
        }
    }
}