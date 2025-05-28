/*
Complete the solution so that it reverses all of the words within the string passed in.

Words are separated by exactly one space and there are no leading or trailing spaces.
*/

// My solution

using System;

public class Kata
{
  public static string ReverseWords(string str)
  {
    string[] words = str.Split(' ');
    Array.Reverse(words);
    return string.Join(" ", words); 
  }
}