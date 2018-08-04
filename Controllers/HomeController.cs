using Insurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Insurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Quote(string FirstName, string LastName, string EmailAddress, string DateOfBirth, int CarYear, string CarMake,
            string CarModel, bool DUI, int Tickets, string Coverage, decimal TotalQuote)
        {
                using (InsuranceEntities db = new InsuranceEntities())
                {
                var user = new Quote();
                user.FirstName = FirstName;
                user.LastName = LastName;
                user.EmailAddress = EmailAddress;
                user.DateOfBirth = DateOfBirth;
                user.CarYear = CarYear;
                user.CarMake = CarMake;
                user.CarModel = CarModel;
                user.DUI = Convert.ToString(DUI);
                user.Tickets = Tickets;
                user.Coverage = Coverage;
                user.TotalQuote = Convert.ToInt32(TotalQuote);
                    
                db.Quotes.Add(user);
                db.SaveChanges();

                }
                return View("Success");
        }

    }
}