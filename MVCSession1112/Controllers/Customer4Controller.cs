using Microsoft.AspNetCore.Mvc;

namespace MVCSession1112.Controllers
{
	public class Customer4Controller : Controller
	{
		public IActionResult Index()
		{
			return View("NewCustomer");
		}
	}
}
