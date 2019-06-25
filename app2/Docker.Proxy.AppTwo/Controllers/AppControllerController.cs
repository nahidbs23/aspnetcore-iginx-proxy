using Microsoft.AspNetCore.Mvc;

namespace Docker.Proxy.AppTwo.Controllers
{
    [Route("app2")]
    public class AppControllerController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}