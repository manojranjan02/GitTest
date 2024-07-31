using GitTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GitTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult reg()
        {
            return View();
        }

        public IActionResult Insert()
        {
            return View();
        }
        public IActionResult Del()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
