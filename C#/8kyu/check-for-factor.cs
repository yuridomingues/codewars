/*
This function should test if the factor is a factor of base.

Return true if it is a factor or false if it is not.
*/

// My solution

using System;

public class Kata
{
  public static bool CheckForFactor(int num, int factor)
  {
    if (num % factor == 0)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}