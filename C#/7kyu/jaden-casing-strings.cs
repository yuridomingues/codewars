/*
Jaden Smith, the son of Will Smith, is the star of films such as The Karate Kid (2010) and After Earth (2013). Jaden is also known for some of his philosophy that he delivers via Twitter. When writing on Twitter, he is known for almost always capitalizing every word. For simplicity, you'll have to capitalize each word, check out how contractions are expected to be in the example below.

Your task is to convert strings to how they would be written by Jaden Smith. The strings are actual quotes from Jaden Smith, but they are not capitalized in the same way he originally typed them.

Example:

Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
Jaden-Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"
*/

//My solution

using System;
using System.Text;

public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        // verify if the string is null or empty
        if (string.IsNullOrEmpty(phrase))
        {
            return phrase;
        }
        //spliting the phrase in words
        string[] words = phrase.Split(' ');
        StringBuilder builder = new StringBuilder();

        foreach (var word in words) //iterance 
        {
            if (word.Length > 0)
            {   //the first letter will be uppercased and the others letters will be normal
                builder.Append(char.ToUpper(word[0]) + word.Substring(1)).Append(" ");
            }
        }
        //return the result
        return builder.ToString().Trim();
    }
}
