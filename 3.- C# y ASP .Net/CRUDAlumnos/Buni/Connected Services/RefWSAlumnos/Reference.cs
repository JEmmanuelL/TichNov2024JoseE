﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Buni.RefWSAlumnos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AportacionesIMSS", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class AportacionesIMSS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private decimal EnfermedadMaternidadField;
        
        private decimal InvalidezVidaField;
        
        private decimal RetiroField;
        
        private decimal CesantiaField;
        
        private decimal InfonavitField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ItemTablaISR", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ItemTablaISR : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private decimal LimitInfField;
        
        private decimal LimitSupField;
        
        private decimal CuotaFijaField;
        
        private decimal ExcedenteField;
        
        private decimal SubsidioField;
        
        private decimal ISRField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RefWSAlumnos.WSAlumnosSoap")]
    public interface WSAlumnosSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento CalcularIMSSResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcularIMSS", ReplyAction="*")]
        Buni.RefWSAlumnos.CalcularIMSSResponse CalcularIMSS(Buni.RefWSAlumnos.CalcularIMSSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcularIMSS", ReplyAction="*")]
        System.Threading.Tasks.Task<Buni.RefWSAlumnos.CalcularIMSSResponse> CalcularIMSSAsync(Buni.RefWSAlumnos.CalcularIMSSRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento CalcularISRResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcularISR", ReplyAction="*")]
        Buni.RefWSAlumnos.CalcularISRResponse CalcularISR(Buni.RefWSAlumnos.CalcularISRRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcularISR", ReplyAction="*")]
        System.Threading.Tasks.Task<Buni.RefWSAlumnos.CalcularISRResponse> CalcularISRAsync(Buni.RefWSAlumnos.CalcularISRRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalcularIMSSRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalcularIMSS", Namespace="http://tempuri.org/", Order=0)]
        public Buni.RefWSAlumnos.CalcularIMSSRequestBody Body;
        
        public CalcularIMSSRequest() {
        }
        
        public CalcularIMSSRequest(Buni.RefWSAlumnos.CalcularIMSSRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalcularIMSSRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public CalcularIMSSRequestBody() {
        }
        
        public CalcularIMSSRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalcularIMSSResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalcularIMSSResponse", Namespace="http://tempuri.org/", Order=0)]
        public Buni.RefWSAlumnos.CalcularIMSSResponseBody Body;
        
        public CalcularIMSSResponse() {
        }
        
        public CalcularIMSSResponse(Buni.RefWSAlumnos.CalcularIMSSResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalcularIMSSResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Buni.RefWSAlumnos.AportacionesIMSS CalcularIMSSResult;
        
        public CalcularIMSSResponseBody() {
        }
        
        public CalcularIMSSResponseBody(Buni.RefWSAlumnos.AportacionesIMSS CalcularIMSSResult) {
            this.CalcularIMSSResult = CalcularIMSSResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalcularISRRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalcularISR", Namespace="http://tempuri.org/", Order=0)]
        public Buni.RefWSAlumnos.CalcularISRRequestBody Body;
        
        public CalcularISRRequest() {
        }
        
        public CalcularISRRequest(Buni.RefWSAlumnos.CalcularISRRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalcularISRRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public CalcularISRRequestBody() {
        }
        
        public CalcularISRRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalcularISRResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalcularISRResponse", Namespace="http://tempuri.org/", Order=0)]
        public Buni.RefWSAlumnos.CalcularISRResponseBody Body;
        
        public CalcularISRResponse() {
        }
        
        public CalcularISRResponse(Buni.RefWSAlumnos.CalcularISRResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalcularISRResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Buni.RefWSAlumnos.ItemTablaISR CalcularISRResult;
        
        public CalcularISRResponseBody() {
        }
        
        public CalcularISRResponseBody(Buni.RefWSAlumnos.ItemTablaISR CalcularISRResult) {
            this.CalcularISRResult = CalcularISRResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSAlumnosSoapChannel : Buni.RefWSAlumnos.WSAlumnosSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSAlumnosSoapClient : System.ServiceModel.ClientBase<Buni.RefWSAlumnos.WSAlumnosSoap>, Buni.RefWSAlumnos.WSAlumnosSoap {
        
        public WSAlumnosSoapClient() {
        }
        
        public WSAlumnosSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSAlumnosSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSAlumnosSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSAlumnosSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Buni.RefWSAlumnos.CalcularIMSSResponse Buni.RefWSAlumnos.WSAlumnosSoap.CalcularIMSS(Buni.RefWSAlumnos.CalcularIMSSRequest request) {
            return base.Channel.CalcularIMSS(request);
        }
        
        public Buni.RefWSAlumnos.AportacionesIMSS CalcularIMSS(int id) {
            Buni.RefWSAlumnos.CalcularIMSSRequest inValue = new Buni.RefWSAlumnos.CalcularIMSSRequest();
            inValue.Body = new Buni.RefWSAlumnos.CalcularIMSSRequestBody();
            inValue.Body.id = id;
            Buni.RefWSAlumnos.CalcularIMSSResponse retVal = ((Buni.RefWSAlumnos.WSAlumnosSoap)(this)).CalcularIMSS(inValue);
            return retVal.Body.CalcularIMSSResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Buni.RefWSAlumnos.CalcularIMSSResponse> Buni.RefWSAlumnos.WSAlumnosSoap.CalcularIMSSAsync(Buni.RefWSAlumnos.CalcularIMSSRequest request) {
            return base.Channel.CalcularIMSSAsync(request);
        }
        
        public System.Threading.Tasks.Task<Buni.RefWSAlumnos.CalcularIMSSResponse> CalcularIMSSAsync(int id) {
            Buni.RefWSAlumnos.CalcularIMSSRequest inValue = new Buni.RefWSAlumnos.CalcularIMSSRequest();
            inValue.Body = new Buni.RefWSAlumnos.CalcularIMSSRequestBody();
            inValue.Body.id = id;
            return ((Buni.RefWSAlumnos.WSAlumnosSoap)(this)).CalcularIMSSAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Buni.RefWSAlumnos.CalcularISRResponse Buni.RefWSAlumnos.WSAlumnosSoap.CalcularISR(Buni.RefWSAlumnos.CalcularISRRequest request) {
            return base.Channel.CalcularISR(request);
        }
        
        public Buni.RefWSAlumnos.ItemTablaISR CalcularISR(int id) {
            Buni.RefWSAlumnos.CalcularISRRequest inValue = new Buni.RefWSAlumnos.CalcularISRRequest();
            inValue.Body = new Buni.RefWSAlumnos.CalcularISRRequestBody();
            inValue.Body.id = id;
            Buni.RefWSAlumnos.CalcularISRResponse retVal = ((Buni.RefWSAlumnos.WSAlumnosSoap)(this)).CalcularISR(inValue);
            return retVal.Body.CalcularISRResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Buni.RefWSAlumnos.CalcularISRResponse> Buni.RefWSAlumnos.WSAlumnosSoap.CalcularISRAsync(Buni.RefWSAlumnos.CalcularISRRequest request) {
            return base.Channel.CalcularISRAsync(request);
        }
        
        public System.Threading.Tasks.Task<Buni.RefWSAlumnos.CalcularISRResponse> CalcularISRAsync(int id) {
            Buni.RefWSAlumnos.CalcularISRRequest inValue = new Buni.RefWSAlumnos.CalcularISRRequest();
            inValue.Body = new Buni.RefWSAlumnos.CalcularISRRequestBody();
            inValue.Body.id = id;
            return ((Buni.RefWSAlumnos.WSAlumnosSoap)(this)).CalcularISRAsync(inValue);
        }
    }
}
