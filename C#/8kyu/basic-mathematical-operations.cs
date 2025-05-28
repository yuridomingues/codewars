/*
Your task is to create a function that does four basic mathematical operations.

The function should take three arguments - operation(string/char), value1(number), value2(number).
The function should return result of numbers after applying the chosen operation.
*/

// My solution

namespace Solution
{
  public static class Program
  {
    public static double Sum(double value1, double value2)
    {
      return value1 + value2; 
    }
    public static double Subtraction(double value1, double value2)
    {
      return value1 - value2;
    }
    public static double Multiplication(double value1, double value2)
    {
      return value1 * value2; 
    }
    public static double Division(double value1, double value2)
    {
      return value1 / value2; 
    }
    public static double basicOp(char operation, double value1, double value2)
    {
      switch (operation)
      { 
        case '+': return Sum(value1, value2);      
        case '-': return Subtraction(value1, value2);
        case '/': return Division(value1, value2);
        default: return Multiplication(value1, value2); 
      }
    }
  }
}