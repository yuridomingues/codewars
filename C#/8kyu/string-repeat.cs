/*
Write a function that accepts an integer n and a string s as parameters, and returns a string of s repeated exactly n times.
*/

// My solution

using System;
using System.Text;

namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s)
    {
        return new StringBuilder(s.Length * (int)n)
        .Insert(0, s, (int)n)
        .ToString();   }
  }
}