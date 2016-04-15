using Microsoft.AspNet.Mvc;

namespace AspNetConfigSampleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {            
            var clientName = Startup.Configuration["ClientSettings:Name"];
            return Content($"Client {clientName}");
        }
    }
}
