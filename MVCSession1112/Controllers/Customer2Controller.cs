using Microsoft.AspNetCore.Mvc;

namespace MVCSession1112.Controllers
{
    public class Customer2Controller : Controller
    {
        public IActionResult Index()
        {
            string a = (string)TempData["xyz"];
            return View();
        }
    }
}
