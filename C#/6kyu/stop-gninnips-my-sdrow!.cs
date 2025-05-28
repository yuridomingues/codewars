/*
Write a function that takes in a string of one or more words, and returns the same string, but with all words that have five or more letters reversed (Just like the name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.

Examples:

"Hey fellow warriors"  --> "Hey wollef sroirraw" 
"This is a test        --> "This is a test" 
"This is another test" --> "This is rehtona test"
*/

// My solution

using System;
using System.Linq;

public class Kata
{
    public static string SpinWords(string sentence)
    {
        string[] words = sentence.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length >= 5)
            {
                words[i] = new string(words[i].Reverse().ToArray());
            }
        }
        return string.Join(" ", words);
    }
}