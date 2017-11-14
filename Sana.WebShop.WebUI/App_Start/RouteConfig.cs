using System.Web.Mvc;
using System.Web.Routing;

namespace Sana.WebShop.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{mode}",
                defaults: new { controller = "Products", action = "Index", mode=UrlParameter.Optional }
            );
        }
    }
}
