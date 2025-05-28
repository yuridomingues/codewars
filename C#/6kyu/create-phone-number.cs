/*
Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.
Example

Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"

The returned format must be correct in order to complete this challenge.

Don't forget the space after the closing parentheses!
*/

// My solution

using System;

public class Kata
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        if (numbers.Length != 10)
        {
          return "Please, enter 10 numbers.";
        }
      
        return string.Format(
          "({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",
          numbers[0], numbers[1], numbers[2],
          numbers[3], numbers[4], numbers[5],
          numbers[6], numbers[7], numbers[8], numbers[9]
        );
    }
}
