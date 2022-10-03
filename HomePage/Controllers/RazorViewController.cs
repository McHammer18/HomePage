using Microsoft.AspNetCore.Mvc;

namespace HomePage.Controllers
{
    public class RazorViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
