using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SimpleNancyApplication.Startup))]

namespace SimpleNancyApplication
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}