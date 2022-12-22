using Microsoft.AspNetCore.Mvc;

namespace MonWebApp.Controllers
{
    public class DevController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
