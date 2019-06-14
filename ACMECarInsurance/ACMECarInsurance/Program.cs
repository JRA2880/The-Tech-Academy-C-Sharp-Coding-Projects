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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\tWelcome to ACME Car Insurance! If you got a pulse, you can get car insurance!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Customer customer = new Customer();

            Console.WriteLine("Please enter the following information to determine a car insurance quote >> ");
            Console.Write("First Name >> ");
            customer.FirstName = Console.ReadLine();
            Console.Write("Last Name >> ");
            customer.LastName = Console.ReadLine();
            Console.Write("Email Address >> ");
            customer.EmailAddress = Console.ReadLine();
            Console.Write("Your Date of Birth >> ");
            customer.BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("The year of your car >> ");
            customer.CarYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("The make of your car >> ");
            customer.CarMake = Console.ReadLine();
            Console.Write("The model of your car >> ");
            customer.CarModel = Console.ReadLine();
            Console.Write("Have you ever had a DUI? Please enter yes or no >> ");
            customer.DUI = Console.ReadLine();
            Console.Write("How many speeding tickets do you have >> ");
            customer.SpeedingTickets = Convert.ToInt32(Console.ReadLine());
            Console.Write("What type of insurance would you like? full coverage or liability? >> ");
            customer.CarInsuranceType = Console.ReadLine();
            Console.WriteLine();

            customer.Output(customer);
            Console.ReadLine();

            customer.InsuranceQuote(customer);
            Console.ReadLine();

           


        }
    }
}
