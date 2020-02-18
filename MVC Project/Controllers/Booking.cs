using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class Booking : Controller
    {
        // GET: Booking
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BookingController(int firstNumber,int secondNumber)
        {
            firstNumber = 4;
            secondNumber = 4;
            int total = firstNumber + secondNumber;
            return View(total);
        }
    }
}