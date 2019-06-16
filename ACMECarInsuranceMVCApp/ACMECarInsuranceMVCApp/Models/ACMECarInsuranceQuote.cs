using ACMECarInsuranceMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ACMECarInsuranceMVCApp.Models
{
    public class ACMECarInsuranceQuote
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime BirthDate { get; set; }
        public int CurrentAge { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string DUI { get; set; }
        public int SpeedingTickets { get; set; }
        public string InsurancePlan { get; set; }
        public decimal QuoteTotal { get; set; }


        public int GetCurrentAge(ACMECarInsuranceQuote quote)
        {
            DateTime currentDate = DateTime.Today;
            var currentAge = currentDate.Year - quote.BirthDate.Year;
            quote.CurrentAge = Convert.ToInt32(currentAge);
            return quote.CurrentAge;
        }

        public decimal InsuranceQuote(ACMECarInsuranceQuote quote)
        {
            decimal monthlyTotal = 50.00m;

            if (quote.CurrentAge > 18 && quote.CurrentAge < 25)
            {
                monthlyTotal += 25.00m;
                Console.WriteLine("Since you are under 25 years old, an extra $25.00 is added to the monthly total");
            }
            if (quote.CurrentAge < 18)
            {
                monthlyTotal += 100.00m;
                Console.WriteLine("Since you are under 18 years old, an extra $100.00 is added to the monthly total.");
            }
            if (quote.CurrentAge >= 100)
            {
                monthlyTotal += 25.00m;
                Console.WriteLine("Since you are over 100 years old, an extra $25.00 is added to the monthly total.");
            }
            if (quote.CarYear < 2000)
            {
                monthlyTotal += 25.00m;
                Console.WriteLine("Since the car year is less than 2000, an extra $25.00 is added to the monthly total.");
            }
            if (quote.CarYear > 2015)
            {
                monthlyTotal += 25.00m;
                Console.WriteLine("Since the car year is greater than 2015, an extra $25.00 is added to the monthly total.");
            }
            if (quote.CarMake == "Porshe")
            {
                monthlyTotal += 25.00m;
                Console.WriteLine("Since the car make is Porshe, an extra $25.00 is added to the monthly total.");
            }
            if (quote.CarModel == "911 Carrera")
            {
                monthlyTotal += 25.00m;
                Console.WriteLine("Since the car model is a 911 Carrera, an extra $25.00 is added to the monthly total.");
            }
            if (quote.SpeedingTickets > 0)
            {
                monthlyTotal = monthlyTotal + (quote.SpeedingTickets * 10);
                Console.WriteLine("Since you have {0} speeding tickets, an extra {1} is added to the monthly total.", quote.SpeedingTickets, (quote.SpeedingTickets * 10).ToString("C"));
            }
            if (quote.DUI == "yes")
            {
                monthlyTotal = monthlyTotal + (12.50m);
                Console.WriteLine("Because you have a DUI, an extra $12.50 is added to your monthly total.");
            }
            if (quote.InsurancePlan == "full coverage")
            {
                monthlyTotal = monthlyTotal + (25.00m);
                Console.WriteLine("Because you have requested full coverage, an extra $25.00 is added to the monthly total.");
            }
            quote.QuoteTotal = monthlyTotal;

            return quote.QuoteTotal;
        }
    }
}

