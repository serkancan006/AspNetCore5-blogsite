using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore5_blogsite.ViewComponents.Category
{
	public class CategoryList : ViewComponent
	{
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());
		public IViewComponentResult Invoke()
		{
			var values = cm.GetList();
			return View(values);
		}
	}
}
