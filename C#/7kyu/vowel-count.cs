/*
Return the number (count) of vowels in the given string.

We will consider a, e, i, o, u as vowels for this Kata (but not y).

The input string will only consist of lower case letters and/or spaces.
*/

// My solution

using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
    
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        int total = str.Count(c => vowels.Contains(c));
    
        vowelCount = total;
    
        return vowelCount;
    }
}
