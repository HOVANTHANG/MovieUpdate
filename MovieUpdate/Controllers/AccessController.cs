using Microsoft.AspNetCore.Mvc;

namespace MovieUpdate.Controllers
{
    public class AccessController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {


            return View();
        }

        public IActionResult Logout()
        {

            return View();
        }
    }
}
