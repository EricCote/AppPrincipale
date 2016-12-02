using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AppPrincipale
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "EnleverTest",
                url: "abonnement/test",
                defaults: new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
                name: "Bonjour",
                url: "bonjour/{prenom}/{nom}",
                defaults: new { controller= "Abonnement", action="Test" }
            );

            routes.MapRoute(
               name: "picture",
               url: "picture/{id}",
               defaults: new { controller = "Produit", action = "GetPicture" }
           );

         // routes.Add(new Route("picture/{ID}", new PictureRouteHandler()));

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        


        }
    }


    public class PictureRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new Picture() { RequestContext = requestContext };
        }
    }
}
