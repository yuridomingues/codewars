/*
Complete the square sum function so that it squares each number passed into it and then sums the results together.

For example, for [1, 2, 2] it should return 9 because 12+22+22=91^2 + 2^2 + 2^2 = 912+22+22=9.

*/

//My solution

public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    int sum = 0;
    /*
    For each number in the array, multiply for 2 and in the final sum everyone
    */
    foreach (int number in numbers)
    {
        sum += number * number;
    }

    return sum; 
  }
}