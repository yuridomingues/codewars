/*
Create a function that checks if a number n is divisible by two numbers x AND y. All inputs are positive, non-zero numbers.
*/

// My solution

public class DivisibleNb 
{
  public static bool IsDivisible(int n, int x, int y) 
  {
    if (n % x == 0 && n % y == 0)
    {
      return true; 
    }
    else
    {
      return false;
    }
  }
}
