using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return Content("con ga tan");
        }
    }
}
