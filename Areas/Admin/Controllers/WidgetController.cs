﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetCore5_blogsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WidgetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
