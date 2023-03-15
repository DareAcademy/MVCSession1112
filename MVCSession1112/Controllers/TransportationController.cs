using Microsoft.AspNetCore.Mvc;
using MVCSession1112.Models;

namespace MVCSession1112.Controllers
{
    public class TransportationController : Controller
    {
        //Bus b;
        IBus b;
        public TransportationController(IBus _b) {
            //b = new Bus();
            //b = Factory.GetInstance();
            b = _b;
        }

        public IActionResult Index()
        {
            //Factory f = new Factory();
            //Bus b = Factory.GetInstance();
            //1 
            //Bus b = new Bus();
            //2
            b.Go();
            return View();
        }

        public IActionResult Save()
        {
            //Factory f = new Factory();
            //Bus b = Factory.GetInstance();
            //Bus b = new Bus();
            b.Go();
            return View();
        }
    }
}
