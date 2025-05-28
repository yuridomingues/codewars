/*
Numbers ending with zeros are boring.

They might be fun in your world, but not here.

Get rid of them. Only the ending ones.

1450 -> 145
960000 -> 96
1050 -> 105
-1050 -> -105

Zero alone is fine, don't worry about it. Poor guy anyway
*/

//My solution

using System;

public class NoBoring 
{
    public static int NoBoringZeros(int n) 
    {
        if (n == 0)
        {
          return 0; 
        }
      
        string numberStr = n.ToString();
        int trimmedNumber = int.Parse(numberStr.TrimEnd('0'));

        return trimmedNumber;
    }
}