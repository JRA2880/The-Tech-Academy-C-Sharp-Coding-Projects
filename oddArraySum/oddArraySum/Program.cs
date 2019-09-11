//Programmer: John R. Adams
//Date: 9/10/2019
//
//Interview Task: Given an array of integers, write a method to total the odd numbers.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int oddSum = 0;
            
            int[] numArray = new int[] { 1, 2, 3,5,6,7,8,9};

            for(i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] % 2 > 0)
                {
                    oddSum = oddSum + numArray[i];
                }
            }
            Console.WriteLine("The sum of the odd numbers in the number array is: {0}", oddSum);     
        }
    }
}
