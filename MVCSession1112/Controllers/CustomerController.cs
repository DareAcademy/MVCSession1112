using Microsoft.AspNetCore.Mvc;
using MVCSession1112.Models;

namespace MVCSession1112.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View("NewCustomer");
        }

        public IActionResult SaveData(Customer cust)
        {

            if (ModelState.IsValid==true)
            {
                //save

            }

            //Customer cust = new Customer();
            //cust.BDate = Convert.ToDateTime(Request.Form["txtBDate"]);
            //Customer cust = new Customer();
            //cust.Name = Request.Form["txt1"];
            //cust.Phone = Request.Form["txt2"];
            //cust.amount = Convert.ToDouble(Request.Form["txt3"]);
            //cust.Password = Request.Form["txt4"];
            //cust.Confirm = Request.Form["txt5"];

            return View("NewCustomer");
        }

        public IActionResult Load()
        {
            Customer cust = new Customer();
            cust.Name = "Yousef";
            cust.Phone = "0771234567";
            cust.amount = 900;
            cust.Password = "123";
            cust.Confirm = "123";

            return View("NewCustomer",cust);
        }

        public IActionResult CustomerInfo()
        {
            return View("CustomerInfo");
        }
        public IActionResult customerDetails()
        {
            vmcustomer vm = new vmcustomer();

            vm.liCust = new List<Customer>();
            Customer c = new Customer();
            c.Name = "ahmad";
            c.Phone = "079999999";
            c.amount = 900;
            vm.liCust.Add(c);
            c = new Customer();
            c.Name = "yousef";
            c.Phone = "077777777";
            c.amount = 800;
            vm.liCust.Add(c);
            return View("customerDetails",vm);
        }

        
    }
}
