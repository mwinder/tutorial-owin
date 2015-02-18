using Nancy;

namespace SimpleNancyApplication.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                var model = new { title = "We've Got Issues..." };
                return View["Home", model];
            };
        }
    }
}