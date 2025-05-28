/*
In this kata you will create a function that takes in a list and returns a list with the reverse order.
*/

// My solution

using System.Collections.Generic;

public class Kata
{
  public static List<int> ReverseList(List<int> list)
  {
    var newList = new List<int>(list);
    newList.Reverse();
    return newList;
  }
}