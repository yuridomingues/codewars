/*
Create a function that takes 2 integers in form of a string as an input, and outputs the sum (also as a string):

Example: (Input1, Input2 -->Output)

"4",  "5" --> "9"
"34", "5" --> "39"
"", "" --> "0"
"2", "" --> "2"
"-5", "3" --> "-2"

Notes:

    If either input is an empty string, consider it as zero.

    Inputs and the expected output will never exceed the signed 32-bit integer limit (2^31 - 1)
*/

// My solution

using System;

namespace Solution
{
    public static class Program
    {
        public static string StringsSum(string s1, string s2)
        {
          int num1 = string.IsNullOrEmpty(s1) ? 0 : int.Parse(s1);
          int num2 = string.IsNullOrEmpty(s2) ? 0 : int.Parse(s2);
          int sum = num1 + num2;
            
          return sum.ToString();
        }    
    }
}