//Programmer: John R. Adams
//Date: 9/10/2019
//
//Interview Task: Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int arraySum = 0;

            int[] numArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9,1000,2500,3000,450000};

            for (i = 0; i < numArray.Length; i++)
            {
                arraySum = arraySum + numArray[i];
            }
            Console.WriteLine("The sum of the numbers in the number array is: {0}", arraySum);
        }
    }
}