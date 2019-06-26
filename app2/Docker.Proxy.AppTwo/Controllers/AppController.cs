using Microsoft.AspNetCore.Mvc;

namespace Docker.Proxy.AppTwo.Controllers
{
    [Route("app2")]
    public class AppController : Controller
    {
        [HttpGet("")]
        public IActionResult Index(string id)
        {
            ViewBag.Id = id;
            return View();
        }

        [HttpGet("{id}/test")]
        public IActionResult Nested(string id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}