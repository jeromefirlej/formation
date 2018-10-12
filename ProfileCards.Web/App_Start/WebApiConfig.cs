namespace ProfileCards.Web
{
    using System;
    using System.Web.Http;

    using Core;

    using Newtonsoft.Json.Serialization;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config, IServiceProvider serviceProvider)
        {
            config.MapHttpAttributeRoutes();
            var jsonMediaTypeFormatter = config.Formatters.JsonFormatter;
            jsonMediaTypeFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.DependencyResolver = new DefaultDependencyResolver(serviceProvider);
        }
    }
}