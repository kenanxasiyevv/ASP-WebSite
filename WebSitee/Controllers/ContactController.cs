using Microsoft.AspNetCore.Mvc;

namespace WebSitee.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
