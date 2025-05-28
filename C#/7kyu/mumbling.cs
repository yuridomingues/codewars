/*
This time no story, no theory. The examples below show you how to write function accum:
Examples:

accum("abcd") -> "A-Bb-Ccc-Dddd"
accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
accum("cwAt") -> "C-Ww-Aaa-Tttt"

The parameter of accum is a string which includes only letters from a..z and A..Z.
*/

// My solution

using System;

public class Accumul 
{
	public static String Accum(string s) 
  {
      string result = ""; 
        
      for (int i = 0; i < s.Length; i++) 
      {
        result += char.ToUpper(s[i]); 
            
        for (int j = 0; j < i; j++) 
        {
          result += char.ToLower(s[i]);
        } 
          if (i < s.Length - 1)
            {
              result += "-";
            }
      }
        return result;
  }
}