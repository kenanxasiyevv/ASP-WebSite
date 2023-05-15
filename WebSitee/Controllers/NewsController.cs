using Microsoft.AspNetCore.Mvc;

namespace WebSitee.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult News()
        {
            return View();
        }
    }
}
