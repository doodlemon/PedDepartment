using Microsoft.AspNetCore.Mvc;
using PediatricsDepartment.Models;
using System.Diagnostics;

namespace PediatricsDepartment.Controllers
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

        public IActionResult Assistant()
        {
            return View();
        }

        public IActionResult Hocalar()
        {
            return View();
        }


        public IActionResult Department()
        {
            return View();
        }

        public IActionResult Emergency()
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
    }
}
