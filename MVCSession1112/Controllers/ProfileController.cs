using Microsoft.AspNetCore.Mvc;

namespace MVCSession1112.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            //string username = TempData["username"].ToString();
            return View("Profile");
        }
    }
}
