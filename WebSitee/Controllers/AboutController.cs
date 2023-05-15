using Microsoft.AspNetCore.Mvc;

namespace WebSitee.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
