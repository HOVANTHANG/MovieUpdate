using Microsoft.AspNetCore.Mvc;

namespace MovieUpdate.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    [Route("admin/home")]
    public class HomeController : Controller
    {

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
