/*
Given a year, return the century it is in.
*/

// My solution

public static class Kata
{
  public static int СenturyFromYear(int year)
  {
    if (year % 100 == 0)
    {
      return year / 100;
    }
    else 
    {
      return year / 100 + 1; 
    }
  }
}