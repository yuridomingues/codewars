/*
The Western Suburbs Croquet Club has two categories of membership, Senior and Open. They would like your help with an application form that will tell prospective members which category they will be placed.

To be a senior, a member must be at least 55 years old and have a handicap greater than 7. In this croquet club, handicaps range from -2 to +26; the better the player the lower the handicap.
Input

Input will consist of a list of pairs. Each pair contains information for a single potential member. Information consists of an integer for the person's age and an integer for the person's handicap.
Output

Output will consist of a list of string values (in Haskell and C: Open or Senior) stating whether the respective member is to be placed in the senior or open category.
*/

// My solution

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
      List<string> categories = new List<string>(); // creating new empty list
      
      foreach (var member in data)
      {
        int age = member[0];
        int handicap = member[1];
        
        if (age >= 55 && handicap > 7)
        {
          categories.Add("Senior");
        }
        else 
        {
          categories.Add("Open");
        }
      }
      return categories; 
    }
}