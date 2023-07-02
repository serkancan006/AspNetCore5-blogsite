using Microsoft.AspNetCore.Mvc;

namespace AspNetCore5_blogsite.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
