/*
Count the number of divisors of a positive integer n.

Random tests go up to n = 500000, but fixed tests go higher.
*/

// My solution

public class Kata
{
  public static int Divisors(int n)
  {
    int count = 0;
    
    for (int i = 1; i <= n; i++)
    {
      if (n % i == 0)
      {
        count++;
      }
    }
    return count;
  }
}