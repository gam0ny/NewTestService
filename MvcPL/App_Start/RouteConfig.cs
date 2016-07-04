using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcPL
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
            routes.MapRoute(null,
               "",
               new
               {
                   controller = "Test",
                   action = "List",
                   page = 1
               }
           );
            routes.MapRoute(null,
                "Page{page}",
                new { controller = "Test", action = "List" },
                new { page = @"\d+" }
            );


            routes.MapRoute(null, "{controller}/{action}");
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Test", action = "List", id = UrlParameter.Optional }
            );
        }
    }
}
