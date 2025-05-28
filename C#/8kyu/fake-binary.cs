/*
Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.

Note: input will never be an empty string
*/

// My solution

public class Kata
{
  public static string FakeBin(string x)
  {
    string result = "";
    for (int i = 0; i < x.Length; i++)
    {
      if (x[i] >= '5')
      {
        result += '1';
      }
      else
      {
        result += '0';
      }
    }
    return result;
  }
}