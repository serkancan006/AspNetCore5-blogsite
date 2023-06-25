using AspNetCore5_blogsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspNetCore5_blogsite.ViewComponents
{
	public class CommentList: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var CommentValues = new List<UserComment>
			{
				new UserComment
				{
					ID = 1,
					UserName = "Serkan",
				},
				new UserComment
				{
					ID = 2,
					UserName = "Mesut",
				},
				new UserComment
				{
					ID = 3,
					UserName = "Merve",
				}
			};
			return View(CommentValues);
		}
	}
}
