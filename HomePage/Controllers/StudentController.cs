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
        public IActionResult Index()
        {
            var students = context.Students
                .ToList();
            return View(students);
        }
    }
}
