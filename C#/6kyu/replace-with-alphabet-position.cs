/*
Welcome.

In this kata you are required to, given a string, replace every letter with its position in the alphabet.

If anything in the text isn't a letter, ignore it and don't return it.
*/

// My solution

using System;
using System.Linq;

public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    return string.Join(
    " ",
    text.ToLower()
    .Where(i => (i - 96) < 27 && (i - 96) > 0)
    .Select(i => i - 96));
  }
}