/*
Given an array of integers as strings and numbers, return the sum of the array values as if all were numbers.

Return your answer as a number.
*/

// My solution

using System;

public class Kata
{
  public static int SumMix(object[] x)
  {
    int sum = 0;
    for (int i = 0; i < x.Length; i++)
    {
      sum += Convert.ToInt32(x[i]);
    }
    return sum;
  }
}