using Microsoft.AspNetCore.Mvc;

namespace MVCWebApplication1.Controllers
{
    public class CategoryController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
