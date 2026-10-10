using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApiContrib.Formatting.Jsonp;

namespace WebApiDemo
{
    public static class WebApiConfig
    {
        public class CustomeJsonFromatter : JsonMediaTypeFormatter
        {
            public CustomeJsonFromatter()
            {
                this.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));
            }

            public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType)
            {
                base.SetDefaultContentHeaders(type, headers, mediaType);
                headers.ContentType = new MediaTypeHeaderValue("application/json");
            }
        }

        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Remove XML data formatter and support only JSON formatter
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            //config.Formatters.Remove(config.Formatters.JsonFormatter);

            //always get json data when request from browser. Bacause from browser we will get data in XML format only.
            //config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));

            config.Formatters.Add(new CustomeJsonFromatter());

            // to get the data in json format for Indentetation
            config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;

            // for camel case for properties name
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            //********************* This Cors Policy Enables Globally means for All Controllers and Action Methods ***************

            //======================= ENABLE CORS USING JSONP (Json Padding) START =======================
            // Enable CORS Policy using JsonP (where we wrap our data into an callbackfunction). The Nuget package is already available in solution if not then we have to install it in our solution.
            //var jsonpFormatter = new JsonpMediaTypeFormatter(config.Formatters.JsonFormatter);
            //config.Formatters.Insert(0,jsonpFormatter); // 0 defines the Index Position.
            //======================= END =======================

            //======================= ENABLE CORS USING Enable Cors Attribute START =======================
            // 1. * - Means we allow all web sites and all types of headers
            // 2.Here we only mention Get,Post means we only allow Get and Post method fro Cross Domain Request.
            // Parameters of EnableCorsAttribute 
            // 1.origins
            // 2.headers
            // 3.methods

            //EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "Get,Post");
            //config.EnableCors(cors);

            //EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "Get,Post");
            config.EnableCors();

            //======================= END =======================

            //********************** END **********************

            //Register services which redirects request from HTTP to HTTPS 
            config.Filters.Add(new RequireHttpsAttribute());


        }
    }
}
