using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.MapRoute(
            //    "MovieReleaseByDate",
            //    "Movies/Released/{Year}/{Month}",
            //    new
            //    {
            //        controller = "Movies",
            //        action = "ByReleaseDate"
            //    },
            //    new
            //    {
            //        year = @"2015|2016",
            //        month = @"\d{2}"
            //    }
               
            //     );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional }
            );
        }
    }
}
