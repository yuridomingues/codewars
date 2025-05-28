/*
Complete the method/function so that it converts dash/underscore delimited words into camel casing. The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case). The next words should be always capitalized.
Examples

"the-stealth-warrior" gets converted to "theStealthWarrior"

"The_Stealth_Warrior" gets converted to "TheStealthWarrior"

"The_Stealth-Warrior" gets converted to "TheStealthWarrior"

*/

//My solution

using System;
using System.Text;
public class Kata
{
  public static string ToCamelCase(string str)
  {     
    var result = new StringBuilder(); //to change de str
    bool toUpperCase = false; 

    foreach (char c in str)
    {
    if (c == '-' || c == '_' || c == ' ') 
    {
        toUpperCase = true; 
    }
    else 
    {
        if (toUpperCase)
        {
            result.Append(char.ToUpper(c)); // add the uppercase letter
            toUpperCase = false; //stop the uppercase funcion 
        }
        else 
        {
            result.Append(c); //result the original letter
        }
    }
    }
    return result.ToString(); //return the camel case solucion 
  }
}