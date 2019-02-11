﻿using Cede_Dotnet_MedicalAppointment_EF.Entities;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Cede_Dotnet_MedicalAppointment_Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            //// Web API routes
            //config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{action}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //
            var cors = new EnableCorsAttribute("127.0.0.1", "*", "*");
            config.EnableCors();

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings
            .ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);

            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            //var model = builder.GetEdmModel();

            builder.EntitySet<User>("User");
            config.MapODataServiceRoute("User", "api", builder.GetEdmModel());

            //builder.EntitySet<Appointment>("Appointment");
            //config.MapODataServiceRoute("Appointment", "api", model);
            config.Filter().Count().OrderBy().Select().Expand().MaxTop(10000);

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}
