using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(BugTracker.Startup))]

namespace BugTracker
{
    public class Startup
    {
        public void Configuration(IAppBuilder application)
        {
            var configuration = new HttpConfiguration();
            configuration.MapHttpAttributeRoutes();
            configuration.Routes.MapHttpRoute("DefaultAction", "api/{controller}/{action}/{id}", new { id = RouteParameter.Optional });
            configuration.Routes.MapHttpRoute("Default", "api/{controller}/{id}", new { id = RouteParameter.Optional });
            application.UseWebApi(configuration);

            application.UseNancy();
        }
    }
}