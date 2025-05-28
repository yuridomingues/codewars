/*
Given a random non-negative number, you have to return the digits of this number within an array in reverse order.
Example(Input => Output):

35231 => [1,3,2,5,3]
0 => [0]
*/

//My solution

using System;
using System.Linq;

namespace Solution
{
    class Digitizer
    {
        public static int[] Digitize(long n)
        {
            string reversedStr = new string(n.ToString().Reverse().ToArray());
            
            return reversedStr.Select(digit => int.Parse(digit.ToString())).ToArray();
        }
        
        public static void Main()
        {
            Console.Write("Please write a non-negative integer number: ");
            
            long number;
            
            if (long.TryParse(Console.ReadLine(), out number) && number >= 0)
            {
                int[] result = Digitize(number);
                
                Console.WriteLine(string.Join(", ", result));
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }
        }
    }
}