using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;

namespace AspNetConfigSampleApp.Controllers
{
    public class HomeController : Controller
    {
        private ClientSettings _clientSettings;

        public HomeController(IOptions<ClientSettings> clientSettings)
        {
            _clientSettings = clientSettings.Value;
        }
        public IActionResult Index()
        {            
              var clientName = _clientSettings;
            return Content($"{_clientSettings.Name} {_clientSettings.PageSize} {_clientSettings.ShowTitle}");
        }
    }
}
