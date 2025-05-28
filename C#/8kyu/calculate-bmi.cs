/*
Write function bmi that calculates body mass index (bmi = weight / height2).

if bmi <= 18.5 return "Underweight"

if bmi <= 25.0 return "Normal"

if bmi <= 30.0 return "Overweight"

if bmi > 30 return "Obese"
*/

// My solution

public class Kata
{
  public static string Bmi(double weight, double height)
  {

    double bodyMass = weight / (height * height);

    if (bodyMass <= 18.5) 
    {
        return "Underweight";
    }

    if (bodyMass <= 25.0) 
    {
        return "Normal";
    }

    if (bodyMass <= 30.0) 
    {
        return "Overweight";
    }

  }
}