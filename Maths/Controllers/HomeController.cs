using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Maths.Models;
using System.Threading.Tasks;

namespace Maths.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }
        public ActionResult Solve(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        public ActionResult Solve(string firstNumber, string secondNumber, string returnUrl)
        {
            double FirstNumber = Math.Sqrt(Int32.Parse(firstNumber));
            double SecondNumber = Math.Sqrt(Int32.Parse(secondNumber));
            var model = new Solve();

            if(FirstNumber < 0 || SecondNumber < 0)
            {
                model.ErrorMessage = "One or two of the numbers you entered was negative. Please put another number";
                return View(model);
            }
            if(FirstNumber > SecondNumber)
            {
                model.SuccessMessage = "The number " + " " + firstNumber + " " + "with Square root " + " " + FirstNumber + " " + "has a higher square root than the number " + " " + secondNumber + " " + "with square root " + " " + SecondNumber + ".";
                return View(model);
            }
            else if(FirstNumber == SecondNumber)
            {
                model.ErrorMessage = "The 2 numbers you entered has the same square root. Please enter another value";
                return View(model);
            }
            else
            {
                model.SuccessMessage = "The number " + " " + secondNumber + " " + "with Square root " + " " + SecondNumber + " " + "has a higher square root than the number " + " " + firstNumber + " " + "with square root " + " " + FirstNumber + ".";
                return View(model);
            }

        }
    }
}