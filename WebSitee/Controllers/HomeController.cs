using Microsoft.AspNetCore.Mvc;

namespace WebSitee.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
