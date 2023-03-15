using Microsoft.AspNetCore.Mvc;

namespace MVCSession1112.Controllers
{
	public class Employee4Controller : Controller
	{
		public IActionResult Index()
		{
			try
			{
				int x = 5;
				int y = 0;
				int z = x / y;
                return View("NewEmployee");
            }
			//catch(DivideByZeroException ex)
			//{
			//	//
			//}
			catch (Exception ex)
			{
				TempData["msg"] = ex.Message.ToString();

                return RedirectToAction("Index", "Errors");
			}

			
		}
	}
}
