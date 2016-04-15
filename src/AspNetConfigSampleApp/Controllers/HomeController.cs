using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Configuration;

namespace AspNetConfigSampleApp.Controllers
{
    public class HomeController : Controller
    {
        private IConfigurationRoot _configuration;

        public HomeController(IConfigurationRoot configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {            
              var clientName = _configuration["ClientSettings:Name"];
            return Content($"Client {clientName}");
        }
    }
}
