using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Biblioteca
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //http://localhost:54720/libro/metodo?idBibioteca=4&titulo=chima      
        
        //    routes.MapRoute(
        //    name: "Libro",
        //    url: "Libro/metodo/{idBibioteca}/{titulo}",
        //    defaults: new { controller = "Libro", action = "metodo" }
        //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

          
        }
    }
}
