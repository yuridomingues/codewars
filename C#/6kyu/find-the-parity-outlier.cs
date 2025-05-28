/*
You are given an array (which will have a length of at least 3, but could be very large) containing integers. 
The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N. 
Write a method that takes the array as an argument and returns this "outlier" N.
*/

// My solution

public class Kata
{
    public static int Find(int[] integers)
    {
      int evenNumber = 0;
      int oddNumber = 0;
      int evenCount = 0;
      int oddCount = 0;

      foreach (int number in integers)
      {
        if (number % 2 == 0)
        {
          evenNumber = number;
          evenCount++;
        }
        else
        {
          oddNumber = number;
          oddCount++;
        }
      }
        if (oddCount > evenCount)
        {
          return evenNumber;
        }
        else
        {
          return oddNumber;
        }
    }
}
