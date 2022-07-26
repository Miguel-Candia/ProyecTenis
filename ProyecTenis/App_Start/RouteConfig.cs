using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProyecTenis
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes) {
            

            /**
            * Para definir las rutas.
            * 1- crear controlador con funcion de renderizado.
            * 2- propiedad name eso solo una Referencia
            **/

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Admin", action = "Index", id = UrlParameter.Optional }
            );

            // add user route.
            routes.MapRoute(
                name: "User",
                url: "{controller}/{action}",
                defaults: new { controller = "User", action = "Index"}
            );

            routes.MapRoute(
                name: "Booking",
                url: "{controller}/{action}",
                defaults: new { controller = "Booking", action = "Index"}
            );

            routes.MapRoute(
                name: "Cancha",
                url: "{controller}/{action}",
                defaults: new { controller = "Cancha", action = "Index"}
            );


            routes.MapRoute(
                name: "Teacher",
                url: "{controller}/{action}",
                defaults: new { controller = "Teacher", action = "Index"}
            );

        }
    }
}
