using Microsoft.AspNetCore.Mvc;

namespace WebSitee.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Products()
        {
            return View();
        }
    }
}
