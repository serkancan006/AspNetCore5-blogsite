using Microsoft.AspNetCore.Mvc;

namespace AspNetCore5_blogsite.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
