/*
Your task is to make a function that can take any non-negative integer as an argument and return it with its digits in descending order. Essentially, rearrange the digits to create the highest possible number.
*/

// My solution

using System;
using System.Linq;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    string numString = num.ToString();
    string orderedString = string.Concat(numString.OrderByDescending(c => c));
    return int.Parse(orderedString);
  }
}
