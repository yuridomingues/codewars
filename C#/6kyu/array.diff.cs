/*
Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

It should remove all values from list a, which are present in list b keeping their order.

Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}

If a value is present in b, all of its occurrences must be removed from the other:

Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}

*/

//My solution

using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    var DiffResult = new List<int>();

    foreach (var number in a)
    {
        if (!b.Contains(number))
        {
            DiffResult.Add(number); 
        } 
    }
    
    return DiffResult.ToArray();
  
  }
}
