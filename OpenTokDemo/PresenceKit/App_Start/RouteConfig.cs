using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using OpenTokSDK;

namespace PresenceKit
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }


    public class Settings
    {
        // Replace these values with the values from your TokBox Dashboard
        const string Secret = "72bea282984b144904e257193b1d5cffe200c7ce";
        const int ApiKey = 46666732;
        public static OpenTok Tk = new OpenTok(ApiKey, Secret);
    }
}
