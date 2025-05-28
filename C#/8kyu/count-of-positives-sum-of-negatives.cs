/*
Given an array of integers.

Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers. 0 is neither positive nor negative.

If the input is an empty array or is null, return an empty array.
*/

// My solution

using System;

public class Kata
{
  public static int[] CountPositivesSumNegatives(int[] input)
  {
    if (input == null || input.Length == 0)
    {
      return Array.Empty<int>();
    }

    int countOfPositives = 0;
    int sumOfNegatives = 0;

    foreach (int num in input)
    {
      if (num > 0)
      {
        countOfPositives++;
      }
      else if (num < 0)
      {
        sumOfNegatives += num;
      }
    }

    return new int[] { countOfPositives, sumOfNegatives };
  }
}
