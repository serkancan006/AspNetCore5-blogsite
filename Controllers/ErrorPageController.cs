using Microsoft.AspNetCore.Mvc;

namespace AspNetCore5_blogsite.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Error1(int code)
		{
			return View();
		}
	}
}
