/*
Write a function which calculates the average of the numbers in a given list.

Note: Empty arrays should return 0.
*/

// My solution

using System;
using System.Linq;

class AverageSolution
{
    public static double FindAverage(double[] array)
    {
        if (array == null || array.Length == 0)
        {
            return 0;
        }
        else
        {
            return array.Average();
        }
    }
}
