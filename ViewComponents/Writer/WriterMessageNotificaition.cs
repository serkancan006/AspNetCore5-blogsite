using Microsoft.AspNetCore.Mvc;

namespace AspNetCore5_blogsite.ViewComponents.Writer
{
    public class WriterMessageNotificaition : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            return View();
        }
    }
}
