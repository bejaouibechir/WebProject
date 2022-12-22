using Microsoft.AspNetCore.Mvc;
using MonWebApp.Models;
using MonWebApp.Services;
using System.Diagnostics;

namespace MonWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogService _logservice;

        public HomeController(ILogService logservice)
        {
            _logservice = logservice;
        }

        public IActionResult Index()
        {
            _logservice.Log("Visite de la page index du " +
                "Home controller");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}