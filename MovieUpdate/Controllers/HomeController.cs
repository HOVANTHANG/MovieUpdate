using Microsoft.AspNetCore.Mvc;
using MovieUpdate.Models;
using System.Diagnostics;

namespace MovieUpdate.Controllers
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

        public IActionResult ABout()
        {
            return View();
        }

        public IActionResult Price()
        {

            return View();
        }

        public IActionResult Sale()
        {

            return View();
        }

        public IActionResult Schedule()
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
