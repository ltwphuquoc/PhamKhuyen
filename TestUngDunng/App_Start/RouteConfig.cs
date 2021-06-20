using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestUngDunng
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "Details",
               url: "{controller}/{action}/{proID}",
               defaults: new { controller = "SanPham", action = "Details", proID = UrlParameter.Optional }
           );
            //routes.MapRoute(
            //    name: "Delete",
            //    url: "{controller}/{action}/{UserAcount}",
            //    defaults: new { controller = "User", action = "Delete", UserAcount = UrlParameter.Optional }
            //);
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
