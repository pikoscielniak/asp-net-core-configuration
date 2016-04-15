using Microsoft.AspNet.Mvc;

namespace AspNetConfigSampleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {            
            return Content($"Client");
        }
    }
}
