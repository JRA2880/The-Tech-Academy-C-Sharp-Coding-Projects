//Programer: John R. Adams
//Date: 09-10-2019
//
//Task: Given a string, reverse it.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedStringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string forwardString;
            string reversedString;

            forwardString = "nacirema";
            reversedString = "";

            Console.WriteLine("String is {0}", forwardString);

            // find string length
            int len;
            len = forwardString.Length - 1;

            while (len >= 0)
            {
                reversedString = reversedString + forwardString[len];
                len--;
            }
            Console.WriteLine("Reversed String is {0}", reversedString);
            Console.ReadLine();
        }
    }
}
