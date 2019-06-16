using ACMECarInsuranceMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace ACMECarInsuranceMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           return View();
        }
        [HttpPost]
        public ActionResult GetQuote(string firstName, string lastName, string emailAddress, DateTime birthDate, int carYear, string carMake, string carModel, string dui, int speedingTickets, string insurancePlan)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
                {
                    return View("~/Views/Shared/Error.cshtml");
                }
            else
           { 
             using (ACMECarInsuranceEntities db = new ACMECarInsuranceEntities())
                {
                    DateTime CurrentDate = DateTime.Today;
                    decimal MonthlyTotal = 50.00M;
                    var quote = new ACMEQuote();
                    quote.FirstName = firstName;
                    quote.LastName = lastName;
                    quote.EmailAddress = emailAddress;
                    quote.BirthDate = birthDate;
                    var birthyear = birthDate.Year;
                    var age = CurrentDate.Year - birthyear;
                    quote.CurrentAge = Convert.ToInt32(age);
                    quote.CarYear = carYear;
                    quote.CarMake = carMake;
                    quote.CarModel = carModel;
                    quote.DUI = dui;
                    quote.SpeedingTickets = speedingTickets;
                    quote.InsurancePlan = insurancePlan;
                    
                    if (quote.CurrentAge < 18)
                    {
                        MonthlyTotal += 100.00M;
                    }
                    if (quote.CurrentAge > 18 && quote.CurrentAge < 25)
                    {
                        MonthlyTotal += 25.00M;
                    }
                    if (quote.CurrentAge >= 100)
                    {
                        MonthlyTotal += 25.00M;
                    }
                    if (quote.CarYear < 2000)
                    {
                        MonthlyTotal += 25.00M;
                    }
                    if (quote.CarYear > 2015)
                    {
                        MonthlyTotal += 25.00M;
                    }
                    if (quote.CarMake == "Porshe")
                    {
                        MonthlyTotal += 25.00M;
                    } 
                    if (quote.CarModel == "911 Carrera")
                    {
                        MonthlyTotal += 25.00M;
                    }
                    if (quote.SpeedingTickets > 0)
                    {
                        decimal tickets = Convert.ToDecimal(quote.SpeedingTickets * 10.0);
                        MonthlyTotal = MonthlyTotal + tickets;
                    }
                    if (quote.DUI == "yes" || quote.DUI == "YES")
                    {
                        MonthlyTotal = MonthlyTotal + (12.50M);
                    }
                    if (quote.InsurancePlan == "full coverage" || quote.InsurancePlan == "FULL COVERAGE")
                    {
                        MonthlyTotal = MonthlyTotal + (25.0M);
                    }
                    quote.QuoteTotal = MonthlyTotal;

                    db.ACMEQuotes.Add(quote);
                    db.SaveChanges();

                }
             return View("Success");
           }     
        }
    }
}