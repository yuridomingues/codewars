/*
Fix the bug so we can all go home early.
*/

// My solution

using System.Text.RegularExpressions;

public class Kata
{
  public static string ReplaceDots(string str)
  {
    return str.Replace(".", "-");
  }
}