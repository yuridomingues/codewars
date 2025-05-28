using System;

public class Kata
{   
  public static string NameShuffler(string str)
  {
    string[] names = str.Split(" ");
    string name = names[0];
    string lastName = names[1];
      
    return lastName + " " + name;
  }
}