using Microsoft.AspNetCore.Mvc;
using MVCSession1112.Models;

namespace MVCSession1112.Controllers
{
    public class student2Controller : Controller
    {
        public IActionResult Index()
        {
            //student std = new student();
            //int x = std.Id;
            //int x = student.Id;

            //student std = new student();

            student x= student.getInstance();
            int a = x.Id;
            return View();
        }
    }
}
