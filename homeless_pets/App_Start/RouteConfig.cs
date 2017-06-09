using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace homeless_pets
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "EditPet",
            url: "Manage/Edit/{id}",
            defaults: new { controller = "Manage", action = "Edit", id = 1 }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" }
            );



            routes.MapRoute(
                name: "CardMap",
                url: "Catalog/{action}/{id}",
                defaults: new { controller = "Catalog", action = "Card", id = UrlParameter.Optional }
            );

            //routes.MapRoute(
            //name: "EditPetIdNull",
            //url: "Manage/Edit",
            //defaults: new { controller = "Manage", action = "Info" }
            //);



            routes.MapRoute(
            name: "Manage",
            url: "Manage/Delete/{id}",
            defaults: new { controller = "Manage", action = "Delete", id = UrlParameter.Optional },
            constraints: new { id = @"\d+" }
            );
        }
    }
}
