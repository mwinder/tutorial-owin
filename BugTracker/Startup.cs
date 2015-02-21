using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BugTracker.Startup))]

namespace BugTracker
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}