/*
Create a function called shortcut to remove the lowercase vowels (a, e, i, o, u ) in a given string.
*/

// My solution

using System;
using System.Linq;

public class Kata
{
  public static string Shortcut(string input)
  {
    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
    return string.Concat(input.Where(c => !vowels.Contains(char.ToLower(c))));
  }
}