/*
Create a function that accepts a string and a single character, and returns an integer of the count of occurrences the 2nd argument is found in the first one.

If no occurrences can be found, a count of 0 should be returned.

("Hello", 'o')  =>  1
("Hello", 'l')  =>  2
("", 'z')       =>  0
*/

// My solution

class Kata
{
    public static int StrCount(string str, char letter)
    {
    int count = 0;
    foreach (char c in str)                  
    { 
      if (c == letter)
      {
        count++;
      }
    }
    return count;  
    }
}