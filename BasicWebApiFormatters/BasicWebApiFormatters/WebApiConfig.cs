using System.Web.Http;

namespace BasicWebApiFormatters
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
            configuration.Routes.MapHttpRoute(
                name: "Default",
                routeTemplate: "api/person/{id}",
                defaults: new { id = RouteParameter.Optional, controller = "Person" }
                );
        }
    }
}