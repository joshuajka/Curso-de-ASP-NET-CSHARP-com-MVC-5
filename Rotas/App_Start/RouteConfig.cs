using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Rotas
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Todas as Noticias",
                url: "noticias/",
                defaults: new {controller = "Home", action = "TodasAsNoticias", id = UrlParameter.Optional}
                );

            routes.MapRoute(
                name: "Mostra Categoria Especifica",
                url: "noticias/{categoria}/",
                defaults: new { controller = "Home", action = "MostraCategoria", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Mostra Noticia Especifica",
                url: "noticias/{categoria}/{titulo}",
                defaults: new { controller = "Home", action = "MostraNoticia", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
