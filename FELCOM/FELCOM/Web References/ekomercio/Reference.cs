﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace FELCOM.ekomercio {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WSFEBuilderSoap", Namespace="http://www.ekomercio.com/")]
    public partial class WSFEBuilder : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback procesarXML_SVOperationCompleted;
        
        private System.Threading.SendOrPostCallback getPDF_SVOperationCompleted;
        
        private System.Threading.SendOrPostCallback getDocumentosOperationCompleted;
        
        private System.Threading.SendOrPostCallback enviar_ContigenciaOperationCompleted;
        
        private System.Threading.SendOrPostCallback procesarTextoPlanoOperationCompleted;
        
        private System.Threading.SendOrPostCallback enviar_InvalidacionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WSFEBuilder() {
            this.Url = global::FELCOM.Properties.Settings.Default.FELCOM_ekomercio_WSFEBuilder;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event procesarXML_SVCompletedEventHandler procesarXML_SVCompleted;
        
        /// <remarks/>
        public event getPDF_SVCompletedEventHandler getPDF_SVCompleted;
        
        /// <remarks/>
        public event getDocumentosCompletedEventHandler getDocumentosCompleted;
        
        /// <remarks/>
        public event enviar_ContigenciaCompletedEventHandler enviar_ContigenciaCompleted;
        
        /// <remarks/>
        public event procesarTextoPlanoCompletedEventHandler procesarTextoPlanoCompleted;
        
        /// <remarks/>
        public event enviar_InvalidacionCompletedEventHandler enviar_InvalidacionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ekomercio.com/procesarXML_SV", RequestNamespace="http://www.ekomercio.com/", ResponseNamespace="http://www.ekomercio.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string procesarXML_SV(string _XML) {
            object[] results = this.Invoke("procesarXML_SV", new object[] {
                        _XML});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void procesarXML_SVAsync(string _XML) {
            this.procesarXML_SVAsync(_XML, null);
        }
        
        /// <remarks/>
        public void procesarXML_SVAsync(string _XML, object userState) {
            if ((this.procesarXML_SVOperationCompleted == null)) {
                this.procesarXML_SVOperationCompleted = new System.Threading.SendOrPostCallback(this.OnprocesarXML_SVOperationCompleted);
            }
            this.InvokeAsync("procesarXML_SV", new object[] {
                        _XML}, this.procesarXML_SVOperationCompleted, userState);
        }
        
        private void OnprocesarXML_SVOperationCompleted(object arg) {
            if ((this.procesarXML_SVCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.procesarXML_SVCompleted(this, new procesarXML_SVCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ekomercio.com/getPDF_SV", RequestNamespace="http://www.ekomercio.com/", ResponseNamespace="http://www.ekomercio.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getPDF_SV(string User, string Password, string _UUID) {
            object[] results = this.Invoke("getPDF_SV", new object[] {
                        User,
                        Password,
                        _UUID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getPDF_SVAsync(string User, string Password, string _UUID) {
            this.getPDF_SVAsync(User, Password, _UUID, null);
        }
        
        /// <remarks/>
        public void getPDF_SVAsync(string User, string Password, string _UUID, object userState) {
            if ((this.getPDF_SVOperationCompleted == null)) {
                this.getPDF_SVOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetPDF_SVOperationCompleted);
            }
            this.InvokeAsync("getPDF_SV", new object[] {
                        User,
                        Password,
                        _UUID}, this.getPDF_SVOperationCompleted, userState);
        }
        
        private void OngetPDF_SVOperationCompleted(object arg) {
            if ((this.getPDF_SVCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getPDF_SVCompleted(this, new getPDF_SVCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ekomercio.com/getDocumentos", RequestNamespace="http://www.ekomercio.com/", ResponseNamespace="http://www.ekomercio.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getDocumentos(string Usuario, string Password, string _UUID, string ConsecutivoInterno, string NumeroControl) {
            object[] results = this.Invoke("getDocumentos", new object[] {
                        Usuario,
                        Password,
                        _UUID,
                        ConsecutivoInterno,
                        NumeroControl});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getDocumentosAsync(string Usuario, string Password, string _UUID, string ConsecutivoInterno, string NumeroControl) {
            this.getDocumentosAsync(Usuario, Password, _UUID, ConsecutivoInterno, NumeroControl, null);
        }
        
        /// <remarks/>
        public void getDocumentosAsync(string Usuario, string Password, string _UUID, string ConsecutivoInterno, string NumeroControl, object userState) {
            if ((this.getDocumentosOperationCompleted == null)) {
                this.getDocumentosOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetDocumentosOperationCompleted);
            }
            this.InvokeAsync("getDocumentos", new object[] {
                        Usuario,
                        Password,
                        _UUID,
                        ConsecutivoInterno,
                        NumeroControl}, this.getDocumentosOperationCompleted, userState);
        }
        
        private void OngetDocumentosOperationCompleted(object arg) {
            if ((this.getDocumentosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getDocumentosCompleted(this, new getDocumentosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ekomercio.com/enviar_Contigencia", RequestNamespace="http://www.ekomercio.com/", ResponseNamespace="http://www.ekomercio.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string enviar_Contigencia(string Usuario, string Password, string IdEmisor, string Encabezado, string Detalle) {
            object[] results = this.Invoke("enviar_Contigencia", new object[] {
                        Usuario,
                        Password,
                        IdEmisor,
                        Encabezado,
                        Detalle});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void enviar_ContigenciaAsync(string Usuario, string Password, string IdEmisor, string Encabezado, string Detalle) {
            this.enviar_ContigenciaAsync(Usuario, Password, IdEmisor, Encabezado, Detalle, null);
        }
        
        /// <remarks/>
        public void enviar_ContigenciaAsync(string Usuario, string Password, string IdEmisor, string Encabezado, string Detalle, object userState) {
            if ((this.enviar_ContigenciaOperationCompleted == null)) {
                this.enviar_ContigenciaOperationCompleted = new System.Threading.SendOrPostCallback(this.Onenviar_ContigenciaOperationCompleted);
            }
            this.InvokeAsync("enviar_Contigencia", new object[] {
                        Usuario,
                        Password,
                        IdEmisor,
                        Encabezado,
                        Detalle}, this.enviar_ContigenciaOperationCompleted, userState);
        }
        
        private void Onenviar_ContigenciaOperationCompleted(object arg) {
            if ((this.enviar_ContigenciaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.enviar_ContigenciaCompleted(this, new enviar_ContigenciaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ekomercio.com/procesarTextoPlano", RequestNamespace="http://www.ekomercio.com/", ResponseNamespace="http://www.ekomercio.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string procesarTextoPlano(ref string usuario, ref string password, ref string id, ref string textoPlano) {
            object[] results = this.Invoke("procesarTextoPlano", new object[] {
                        usuario,
                        password,
                        id,
                        textoPlano});
            usuario = ((string)(results[1]));
            password = ((string)(results[2]));
            id = ((string)(results[3]));
            textoPlano = ((string)(results[4]));
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void procesarTextoPlanoAsync(string usuario, string password, string id, string textoPlano) {
            this.procesarTextoPlanoAsync(usuario, password, id, textoPlano, null);
        }
        
        /// <remarks/>
        public void procesarTextoPlanoAsync(string usuario, string password, string id, string textoPlano, object userState) {
            if ((this.procesarTextoPlanoOperationCompleted == null)) {
                this.procesarTextoPlanoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnprocesarTextoPlanoOperationCompleted);
            }
            this.InvokeAsync("procesarTextoPlano", new object[] {
                        usuario,
                        password,
                        id,
                        textoPlano}, this.procesarTextoPlanoOperationCompleted, userState);
        }
        
        private void OnprocesarTextoPlanoOperationCompleted(object arg) {
            if ((this.procesarTextoPlanoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.procesarTextoPlanoCompleted(this, new procesarTextoPlanoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ekomercio.com/enviar_Invalidacion", RequestNamespace="http://www.ekomercio.com/", ResponseNamespace="http://www.ekomercio.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string enviar_Invalidacion(string Usuario, string Password, string IdEmisor, string textoPlano) {
            object[] results = this.Invoke("enviar_Invalidacion", new object[] {
                        Usuario,
                        Password,
                        IdEmisor,
                        textoPlano});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void enviar_InvalidacionAsync(string Usuario, string Password, string IdEmisor, string textoPlano) {
            this.enviar_InvalidacionAsync(Usuario, Password, IdEmisor, textoPlano, null);
        }
        
        /// <remarks/>
        public void enviar_InvalidacionAsync(string Usuario, string Password, string IdEmisor, string textoPlano, object userState) {
            if ((this.enviar_InvalidacionOperationCompleted == null)) {
                this.enviar_InvalidacionOperationCompleted = new System.Threading.SendOrPostCallback(this.Onenviar_InvalidacionOperationCompleted);
            }
            this.InvokeAsync("enviar_Invalidacion", new object[] {
                        Usuario,
                        Password,
                        IdEmisor,
                        textoPlano}, this.enviar_InvalidacionOperationCompleted, userState);
        }
        
        private void Onenviar_InvalidacionOperationCompleted(object arg) {
            if ((this.enviar_InvalidacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.enviar_InvalidacionCompleted(this, new enviar_InvalidacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void procesarXML_SVCompletedEventHandler(object sender, procesarXML_SVCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class procesarXML_SVCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal procesarXML_SVCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void getPDF_SVCompletedEventHandler(object sender, getPDF_SVCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getPDF_SVCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getPDF_SVCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void getDocumentosCompletedEventHandler(object sender, getDocumentosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getDocumentosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getDocumentosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void enviar_ContigenciaCompletedEventHandler(object sender, enviar_ContigenciaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class enviar_ContigenciaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal enviar_ContigenciaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void procesarTextoPlanoCompletedEventHandler(object sender, procesarTextoPlanoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class procesarTextoPlanoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal procesarTextoPlanoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string usuario {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string password {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
        
        /// <remarks/>
        public string id {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[3]));
            }
        }
        
        /// <remarks/>
        public string textoPlano {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[4]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void enviar_InvalidacionCompletedEventHandler(object sender, enviar_InvalidacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class enviar_InvalidacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal enviar_InvalidacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591