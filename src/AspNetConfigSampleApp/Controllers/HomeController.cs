using Microsoft.AspNet.Mvc;

namespace AspNetConfigSampleApp.Controllers
{
    public class HomeController : Controller
    {
       private ClientSettings _clientSettings;

        public HomeController(ClientSettings clientSettings)
        {
            _clientSettings = clientSettings;
        }
        public IActionResult Index()
        {            
            var clientName = _clientSettings;
            return Content($"{_clientSettings.Name} {_clientSettings.PageSize} {_clientSettings.ShowTitle}");
        }
    }
}
