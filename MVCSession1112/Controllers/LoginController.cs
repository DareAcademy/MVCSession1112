using Microsoft.AspNetCore.Mvc;

namespace MVCSession1112.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }

        public IActionResult LoginValidate()
        {
            //return View("Profile");

            //username & password true
            bool x = true;
            if (x==true) {
                string uname = Request.Form["txt1"];
                TempData["username"] = uname;
            return RedirectToAction("Index", "Profile");
            }
            else
            {
                return View("Login");
            }
        }

    }
}
