using Microsoft.AspNetCore.Mvc;

namespace MVCSession1112.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View("NewStudent");
        }
    }
}
