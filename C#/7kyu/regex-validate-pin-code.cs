using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidatePin(string pin)
  {
    
    pin = Regex.Escape(pin);
    
    if ((pin.Length != 4 && pin.Length != 6) || !Regex.IsMatch(pin, @"^\d+$"))
    {
      return false;
    }

    return true;
  }
}