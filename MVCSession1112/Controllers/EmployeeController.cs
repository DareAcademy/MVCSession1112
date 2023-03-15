using Microsoft.AspNetCore.Mvc;
using MVCSession1112.Models;

namespace MVCSession1112.Controllers
{
	public class EmployeeController : Controller
	{
		[Route("xyz")]
		public IActionResult Index()
		{
			return View("NewEmployee");
		}

		public IActionResult saveData()
		{
			//ViewData["Name"] = Request.Form["txt1"];
			//ViewData["Salary"] = Request.Form["txt2"];

			Employee emp = new Employee();
			emp._name = Request.Form["txt1"];
			emp._salary = Convert.ToDouble(Request.Form["txt2"]);

            return View("EmployeeInfo", emp);
		}

		public IActionResult EmployeeList()
		{
			// list
			

			List<Employee> employees = new List<Employee>();
			Employee emp = new Employee();
			emp._name = "Ahmad";
			emp._salary = 1000;
			employees.Add(emp);
            emp = new Employee();
            emp._name = "Sarah";
            emp._salary = 900;
            employees.Add(emp);



            return View("ListofEmployees",employees);
		}

    }
}
