using Microsoft.AspNetCore.Mvc;

namespace FmDemoWeb.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
