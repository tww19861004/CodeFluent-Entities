﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftFluent.Samples.AngularJs.ReferenceData.Services
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Tuesday, 03 February 2015 15:42.
    // Build:1.0.61214.0786
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0786")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.softfluent.com/samples/angularjs/referencedata")]
    public partial interface IProductService
    {
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="Validate", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        string Validate(SoftFluent.Samples.AngularJs.ReferenceData.Product product, string culture);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="Delete", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        bool Delete(SoftFluent.Samples.AngularJs.ReferenceData.Product product);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="Load", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        SoftFluent.Samples.AngularJs.ReferenceData.Product Load(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="LoadById", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        SoftFluent.Samples.AngularJs.ReferenceData.Product LoadById(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="Save", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        bool Save(SoftFluent.Samples.AngularJs.ReferenceData.Product product);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="LoadByEntityKey", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        SoftFluent.Samples.AngularJs.ReferenceData.Product LoadByEntityKey(string key);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="DeleteByKey", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        bool DeleteByKey(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="SaveAll", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        void SaveAll(SoftFluent.Samples.AngularJs.ReferenceData.ProductCollection productCollection);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="PageLoadAll", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        SoftFluent.Samples.AngularJs.ReferenceData.ProductCollection PageLoadAll(int pageIndex, int pageSize, CodeFluent.Runtime.PageOptions pageOptions);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="LoadAll", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        SoftFluent.Samples.AngularJs.ReferenceData.ProductCollection LoadAll();
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="PageLoadProductsOrdersByOrder", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        SoftFluent.Samples.AngularJs.ReferenceData.ProductCollection PageLoadProductsOrdersByOrder(int pageIndex, int pageSize, CodeFluent.Runtime.PageOptions pageOptions, string orderEntityKey);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="LoadProductsOrdersByOrder", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        SoftFluent.Samples.AngularJs.ReferenceData.ProductCollection LoadProductsOrdersByOrder(string orderEntityKey);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, Method="GET")]
        System.IO.Stream JsonGet(CodeFluent.Runtime.Model.ProjectInvokeOptions options);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute()]
        System.IO.Stream JsonPost(System.IO.Stream data);
    }
}