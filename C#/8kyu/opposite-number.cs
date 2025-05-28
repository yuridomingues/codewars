/*
Very simple, given a number (integer / decimal / both depending on the language), find its opposite (additive inverse).

Examples:

1: -1
14: -14
-34: 34
*/

// My solution

using System;

public class Kata
    {
        public  static int Opposite(int number)
        {
          if (number < number + 1)
          { 
            return number * -1;
          }
          else
          {
            return number * 1;
          }
        }
    }