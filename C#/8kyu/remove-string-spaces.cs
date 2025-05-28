/*
Write a function that removes the spaces from the string, then return the resultant string.
*/

// My solution

namespace Solution 
{
  public static class SpacesRemover
  {
    public static string NoSpace(string input)
    {
      return input.Replace(" ", "");
    }  
  }
}