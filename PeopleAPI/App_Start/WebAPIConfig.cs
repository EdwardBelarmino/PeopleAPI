using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace PeopleAPI
{
    public static class WebAPIConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/(controller)/(action)(id)",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}