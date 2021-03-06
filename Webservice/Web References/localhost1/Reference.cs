﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Webservice.localhost1 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://microsoft.com/webservices/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[]))]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetWebsiteHtmlOperationCompleted;
        
        private System.Threading.SendOrPostCallback objectsOperationCompleted;
        
        private System.Threading.SendOrPostCallback javaobjectsOperationCompleted;
        
        private System.Threading.SendOrPostCallback getTableOperationCompleted;
        
        private System.Threading.SendOrPostCallback ToArrayOperationCompleted;
        
        private System.Threading.SendOrPostCallback sqlstringOperationCompleted;
        
        private System.Threading.SendOrPostCallback UploadOperationCompleted;
        
        private System.Threading.SendOrPostCallback txtFileOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = global::Webservice.Properties.Settings.Default.Webservice_localhost1_WebService1;
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
        public event GetWebsiteHtmlCompletedEventHandler GetWebsiteHtmlCompleted;
        
        /// <remarks/>
        public event objectsCompletedEventHandler objectsCompleted;
        
        /// <remarks/>
        public event javaobjectsCompletedEventHandler javaobjectsCompleted;
        
        /// <remarks/>
        public event getTableCompletedEventHandler getTableCompleted;
        
        /// <remarks/>
        public event ToArrayCompletedEventHandler ToArrayCompleted;
        
        /// <remarks/>
        public event sqlstringCompletedEventHandler sqlstringCompleted;
        
        /// <remarks/>
        public event UploadCompletedEventHandler UploadCompleted;
        
        /// <remarks/>
        public event txtFileCompletedEventHandler txtFileCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://microsoft.com/webservices/GetWebsiteHtml", RequestNamespace="http://microsoft.com/webservices/", ResponseNamespace="http://microsoft.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetWebsiteHtml(string url) {
            object[] results = this.Invoke("GetWebsiteHtml", new object[] {
                        url});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetWebsiteHtmlAsync(string url) {
            this.GetWebsiteHtmlAsync(url, null);
        }
        
        /// <remarks/>
        public void GetWebsiteHtmlAsync(string url, object userState) {
            if ((this.GetWebsiteHtmlOperationCompleted == null)) {
                this.GetWebsiteHtmlOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetWebsiteHtmlOperationCompleted);
            }
            this.InvokeAsync("GetWebsiteHtml", new object[] {
                        url}, this.GetWebsiteHtmlOperationCompleted, userState);
        }
        
        private void OnGetWebsiteHtmlOperationCompleted(object arg) {
            if ((this.GetWebsiteHtmlCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetWebsiteHtmlCompleted(this, new GetWebsiteHtmlCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://microsoft.com/webservices/objects", RequestNamespace="http://microsoft.com/webservices/", ResponseNamespace="http://microsoft.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object[] objects() {
            object[] results = this.Invoke("objects", new object[0]);
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public void objectsAsync() {
            this.objectsAsync(null);
        }
        
        /// <remarks/>
        public void objectsAsync(object userState) {
            if ((this.objectsOperationCompleted == null)) {
                this.objectsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnobjectsOperationCompleted);
            }
            this.InvokeAsync("objects", new object[0], this.objectsOperationCompleted, userState);
        }
        
        private void OnobjectsOperationCompleted(object arg) {
            if ((this.objectsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.objectsCompleted(this, new objectsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://microsoft.com/webservices/javaobjects", RequestNamespace="http://microsoft.com/webservices/", ResponseNamespace="http://microsoft.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("ArrayOfString")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(NestingLevel=1)]
        public string[][] javaobjects() {
            object[] results = this.Invoke("javaobjects", new object[0]);
            return ((string[][])(results[0]));
        }
        
        /// <remarks/>
        public void javaobjectsAsync() {
            this.javaobjectsAsync(null);
        }
        
        /// <remarks/>
        public void javaobjectsAsync(object userState) {
            if ((this.javaobjectsOperationCompleted == null)) {
                this.javaobjectsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnjavaobjectsOperationCompleted);
            }
            this.InvokeAsync("javaobjects", new object[0], this.javaobjectsOperationCompleted, userState);
        }
        
        private void OnjavaobjectsOperationCompleted(object arg) {
            if ((this.javaobjectsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.javaobjectsCompleted(this, new javaobjectsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://microsoft.com/webservices/getTable", RequestNamespace="http://microsoft.com/webservices/", ResponseNamespace="http://microsoft.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object[] getTable() {
            object[] results = this.Invoke("getTable", new object[0]);
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public void getTableAsync() {
            this.getTableAsync(null);
        }
        
        /// <remarks/>
        public void getTableAsync(object userState) {
            if ((this.getTableOperationCompleted == null)) {
                this.getTableOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetTableOperationCompleted);
            }
            this.InvokeAsync("getTable", new object[0], this.getTableOperationCompleted, userState);
        }
        
        private void OngetTableOperationCompleted(object arg) {
            if ((this.getTableCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getTableCompleted(this, new getTableCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://microsoft.com/webservices/ToArray", RequestNamespace="http://microsoft.com/webservices/", ResponseNamespace="http://microsoft.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object[] ToArray() {
            object[] results = this.Invoke("ToArray", new object[0]);
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public void ToArrayAsync() {
            this.ToArrayAsync(null);
        }
        
        /// <remarks/>
        public void ToArrayAsync(object userState) {
            if ((this.ToArrayOperationCompleted == null)) {
                this.ToArrayOperationCompleted = new System.Threading.SendOrPostCallback(this.OnToArrayOperationCompleted);
            }
            this.InvokeAsync("ToArray", new object[0], this.ToArrayOperationCompleted, userState);
        }
        
        private void OnToArrayOperationCompleted(object arg) {
            if ((this.ToArrayCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ToArrayCompleted(this, new ToArrayCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://microsoft.com/webservices/sqlstring", RequestNamespace="http://microsoft.com/webservices/", ResponseNamespace="http://microsoft.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable sqlstring() {
            object[] results = this.Invoke("sqlstring", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void sqlstringAsync() {
            this.sqlstringAsync(null);
        }
        
        /// <remarks/>
        public void sqlstringAsync(object userState) {
            if ((this.sqlstringOperationCompleted == null)) {
                this.sqlstringOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsqlstringOperationCompleted);
            }
            this.InvokeAsync("sqlstring", new object[0], this.sqlstringOperationCompleted, userState);
        }
        
        private void OnsqlstringOperationCompleted(object arg) {
            if ((this.sqlstringCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.sqlstringCompleted(this, new sqlstringCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://microsoft.com/webservices/Upload", RequestNamespace="http://microsoft.com/webservices/", ResponseNamespace="http://microsoft.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Upload([System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] contents, string filenamesave) {
            this.Invoke("Upload", new object[] {
                        contents,
                        filenamesave});
        }
        
        /// <remarks/>
        public void UploadAsync(byte[] contents, string filenamesave) {
            this.UploadAsync(contents, filenamesave, null);
        }
        
        /// <remarks/>
        public void UploadAsync(byte[] contents, string filenamesave, object userState) {
            if ((this.UploadOperationCompleted == null)) {
                this.UploadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUploadOperationCompleted);
            }
            this.InvokeAsync("Upload", new object[] {
                        contents,
                        filenamesave}, this.UploadOperationCompleted, userState);
        }
        
        private void OnUploadOperationCompleted(object arg) {
            if ((this.UploadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UploadCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://microsoft.com/webservices/txtFile", RequestNamespace="http://microsoft.com/webservices/", ResponseNamespace="http://microsoft.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string txtFile(string filename) {
            object[] results = this.Invoke("txtFile", new object[] {
                        filename});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void txtFileAsync(string filename) {
            this.txtFileAsync(filename, null);
        }
        
        /// <remarks/>
        public void txtFileAsync(string filename, object userState) {
            if ((this.txtFileOperationCompleted == null)) {
                this.txtFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OntxtFileOperationCompleted);
            }
            this.InvokeAsync("txtFile", new object[] {
                        filename}, this.txtFileOperationCompleted, userState);
        }
        
        private void OntxtFileOperationCompleted(object arg) {
            if ((this.txtFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.txtFileCompleted(this, new txtFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetWebsiteHtmlCompletedEventHandler(object sender, GetWebsiteHtmlCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetWebsiteHtmlCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetWebsiteHtmlCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void objectsCompletedEventHandler(object sender, objectsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class objectsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal objectsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void javaobjectsCompletedEventHandler(object sender, javaobjectsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class javaobjectsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal javaobjectsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[][] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[][])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void getTableCompletedEventHandler(object sender, getTableCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getTableCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getTableCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void ToArrayCompletedEventHandler(object sender, ToArrayCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ToArrayCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ToArrayCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void sqlstringCompletedEventHandler(object sender, sqlstringCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class sqlstringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal sqlstringCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void UploadCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void txtFileCompletedEventHandler(object sender, txtFileCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class txtFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal txtFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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