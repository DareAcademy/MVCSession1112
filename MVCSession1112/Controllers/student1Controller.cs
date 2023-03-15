using Microsoft.AspNetCore.Mvc;
using MVCSession1112.Models;

namespace MVCSession1112.Controllers
{
    public class student1Controller : Controller
    {
        public IActionResult Index()
        {
            //student std = new student();
            //std.Id = 5;
            //student.Id = 5;

            //student std = new student();

            student y = student.getInstance();
            y.Id = 5;
            return View();
        }
    }
}
