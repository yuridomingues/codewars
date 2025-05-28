/*
Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.
*/

// My solution

using System;

public static class Kata
{
  public static string ReverseWords(string str)
  {
    string[] words = str.Split(' ');
    for (int i = 0; i < words.Length; i++)
    {
      char[] charArray = words[i].ToCharArray();
      Array.Reverse(charArray);
      words[i] = new string(charArray);
    }
    return string.Join(" ", words);
  }
}
