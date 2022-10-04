using HomePage.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomePage.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private StudentContext context;

        public StudentController(ILogger<HomeController> logger, StudentContext dbcontext)
        {
            _logger = logger;
            context = dbcontext;
        }
        [HttpGet]
        public IActionResult Index(int userAccess)
        {
            var students = context.Students
                .ToList();
            ViewBag.userAccess = userAccess;
            return View(students);
        }
    }
}
