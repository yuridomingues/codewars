/*
You are given two interior angles (in degrees) of a triangle.

Write a function to return the 3rd.

Note: only positive integers will be tested.
*/

// My solution

sing System;

public static class Kata
{
  public static int OtherAngle(int a, int b)
  {
    int twoAngles = a + b; 
    int maxAnglesValue = 180;
    return maxAnglesValue - twoAngles;
  }
}