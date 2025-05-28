/*
Write a function to split a string and convert it into an array of words.
*/

// My solution

namespace Solution {
  using System;
  using System.Linq;

  public class Solution
  {
    public static string[] StringToArray(string str)
    {
      return str.Split(' ').ToArray();
    }
  }
}