using Microsoft.AspNetCore.Mvc;

namespace Docker.Proxy.AppOne.Controllers
{
    [Route("app1")]
    public class AppController : Controller
    {
        [HttpGet("")]
        public IActionResult Index(string id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}