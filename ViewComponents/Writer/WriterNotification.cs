using Microsoft.AspNetCore.Mvc;

namespace AspNetCore5_blogsite.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
