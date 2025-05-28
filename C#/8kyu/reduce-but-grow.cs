/*
Given a non-empty array of integers, return the result of multiplying the values together in order. Example:

[1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24
*/

// My solution

using System;
public class Kata
{
  public static int Grow(int[] x)
  {
    int multiplication = 1;
    foreach (int value in x)
    {
      multiplication *= value;
    }
    return multiplication;
  }
}