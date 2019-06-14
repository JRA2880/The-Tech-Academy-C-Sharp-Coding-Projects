//Programmer: John R. Adams
//Date: 06-14-2019
//
//Programming Exercise: Develop Console Application to build framework for controller in future MVC Web Application for ACME Car Insurance.
//
//REQUIREMENTS:
//
//You must get the following information from the user:
//1.) First Name
//2.) Last Name
//3.) Email Address
//4.)  Date of Birth
//5.) Car Year
//6.) Car Make
//7.) Car Model
//8.) If they have ever had a DUI.
//9.) How many speeding tickets they have.
//10.) Would they like full coverage or liability?
//
// Use the following rules to calculate a quote:
//11.) Start with a base of $50 / month.
//12.) If the user is under 25, add $25 to the monthly total.
//13.) If the user is under 18, add $100 to the monthly total.
//14.) If the user is over 100, add $25 to the monthly total.
//15.) If the car's year is before 2000, add $25 to the monthly total.
//16.) If the car's year is after 2015, add $25 to the monthly total.
//17.) If the car's Make is a Porsche, add $25 to the price.
//18.) If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
//19.) Add $10 to the monthly total for every speeding ticket the user has.
//20.) If the user has ever had a DUI, add 25% to the total.
//21.) If it's full coverage, add 50% to the total.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMECarInsurance
{
    public class Customer
    {
        public Customer()
        {
        }
        public Customer(string firstName,string lastName,string emailAddress,DateTime birthdate,int currentAge,int carYear, string carMake, string carModel, string dui, int speedingTickets, string carInsuranceType)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            BirthDate = birthdate;
            CurrentAge = currentAge;
            CarYear = carYear;
            CarMake = carMake;
            CarModel = carModel;
            DUI = dui;
            SpeedingTickets = speedingTickets;
            CarInsuranceType = carInsuranceType;
        }
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
        public string CarInsuranceType { get; set; }

        public void Output(Customer customer)
        {
            Console.WriteLine("First Name:       {0}", customer.FirstName);
            Console.WriteLine("Last Name:        {0}", customer.LastName);
            Console.WriteLine("Email Address:    {0}", customer.EmailAddress);
            Console.WriteLine("Birth Year:       {0}", customer.BirthDate.Year.ToString());

            DateTime currentDate = DateTime.Today;
            var currentAge = currentDate.Year - customer.BirthDate.Year;
            customer.CurrentAge = Convert.ToInt32(currentAge);

            Console.WriteLine("Current Age:      {0}", customer.CurrentAge.ToString());

            Console.WriteLine("Car Year:         {0}", customer.CarYear.ToString());
            Console.WriteLine("Car Make:         {0}", customer.CarMake);
            Console.WriteLine("Car Model:        {0}", customer.CarModel);
            Console.WriteLine("DUI:              {0}", customer.DUI);
            Console.WriteLine("Speeding Tickets: {0}", customer.SpeedingTickets.ToString());
            Console.WriteLine("Car Insurance     {0}", customer.CarInsuranceType);
        }

        public void InsuranceQuote(Customer customer)
        { 
            double monthlyTotal = 50.0;
    
            if (customer.CurrentAge >18 && customer.CurrentAge < 25)
            {
                monthlyTotal += 25.0;
                Console.WriteLine("Since you are under 25 years old, an extra $25.00 is added to the monthly total");
            }
            if (customer.CurrentAge < 18)
            {
                monthlyTotal += 100.0;
                Console.WriteLine("Since you are under 18 years old, an extra $100.00 is added to the monthly total.");
            }
            if (customer.CurrentAge >= 100)
            {
                monthlyTotal += 25.0;
                Console.WriteLine("Since you are over 100 years old, an extra $25.00 is added to the monthly total.");
            }
            if (customer.CarYear < 2000)
            {
                monthlyTotal += 25.0;
                Console.WriteLine("Since the car year is less than 2000, an extra $25.00 is added to the monthly total.");
            }
            if (customer.CarYear > 2015)
            { 
                monthlyTotal += 25.0;
                Console.WriteLine("Since the car year is greater than 2015, an extra $25.00 is added to the monthly total.");
            }
            if (customer.CarMake == "Porshe")
            { 
                monthlyTotal += 25.0;
                Console.WriteLine("Since the car make is Porshe, an extra $25.00 is added to the monthly total.");
            }
            if (customer.CarModel == "911 Carrera")
            {
                monthlyTotal += 25.0;
                Console.WriteLine("Since the car model is a 911 Carrera, an extra $25.00 is added to the monthly total.");
            }
            if (customer.SpeedingTickets > 0)
            {
                monthlyTotal = monthlyTotal + (customer.SpeedingTickets * 10);
                Console.WriteLine("Since you have {0} speeding tickets, an extra {1} is added to the monthly total.", customer.SpeedingTickets, (customer.SpeedingTickets * 10).ToString("C"));
            }
            if (customer.DUI == "yes")
            {
                monthlyTotal = monthlyTotal + (12.50);
                Console.WriteLine("Because you have a DUI, an extra $12.50 is added to your monthly total.");
            }
            if (customer.CarInsuranceType == "full coverage")
            {
                monthlyTotal = monthlyTotal + (25.0);
                Console.WriteLine("Because you have requested full coverage, an extra $25.00 is added to the monthly total.");
            }
            Console.WriteLine("Your monthly total is {0}.", monthlyTotal.ToString("C"));
        }
    }
}
