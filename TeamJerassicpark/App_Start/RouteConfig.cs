using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TeamJerassicpark
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();//Enableing attribute based Routing

            routes.MapRoute(
                name: "Default1",
                url: "pistahouse/pizza",
                defaults: new { controller = "New", action = "Index" ,id=UrlParameter.Optional}
            );


            routes.MapRoute(
              name: "Default2",
              url: "shahghouse/pizza",
              defaults: new { controller = "New", action = "Index", id = UrlParameter.Optional }
          );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
