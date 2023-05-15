using Microsoft.AspNetCore.Mvc;

namespace WebSitee.Controllers
{
    public class FashionController : Controller
    {
        public IActionResult Fashion()
        {
            return View();
        }
    }
}
