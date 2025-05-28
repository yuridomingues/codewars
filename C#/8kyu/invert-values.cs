/*
Given a set of numbers, return the additive inverse of each. Each positive becomes negatives, and the negatives become positives.

[1, 2, 3, 4, 5] --> [-1, -2, -3, -4, -5]
[1, -2, 3, -4, 5] --> [-1, 2, -3, 4, -5]
[] --> []
*/

// My solution

using System;
namespace Solution
{
  public static class ArraysInversion
  {
    public static int[] InvertValues(int[] input)
    {
      int[] invertedValues = new int[input.Length];
      for (int i = 0; i < input.Length; i++)
      {
        invertedValues[i] = input[i] * -1;
      }
      return invertedValues;
    }
  }
}