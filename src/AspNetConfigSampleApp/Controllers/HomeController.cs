using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;

namespace AspNetConfigSampleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
