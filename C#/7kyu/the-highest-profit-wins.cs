/*
Write a function that returns both the minimum and maximum number of the given list/array. 
*/

// My solution

using System;
using System.Linq;

public class MinMax 
{
    public static int[] minMax(int[] lst) 
    {
      int maxValue = lst.Max();
      int minValue = lst.Min();
      return new int[] {minValue, maxValue};
    }
}