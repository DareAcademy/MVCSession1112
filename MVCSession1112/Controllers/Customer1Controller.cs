using Microsoft.AspNetCore.Mvc;

namespace MVCSession1112.Controllers
{
    public class Customer1Controller : Controller
    {
        public IActionResult Index()
        {
            List<string> li = new List<string>();
            li.Add("hi");
            li.Add("hi1");
            li.Add("hi2");

            ViewData["values"] = li;

            ViewBag.values1 = li;
            return View();
        }

        public IActionResult Goto()
        {
            string value = Request.Form["txt1"];
            TempData["xyz"] = value;
            return RedirectToAction("Index", "Customer2");
        }
    }
}

