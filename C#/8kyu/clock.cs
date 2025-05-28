/*
Clock shows h hours, m minutes and s seconds after midnight.

Your task is to write a function which returns the time since midnight in milliseconds.
*/

// My solution

using System;
public static class Clock
{
  public static int Past(int h, int m, int s)
  {
    int hoursMilliseconds = h * 3600000;
    int minuteMilliseconds = m * 60000;
    int secondsMiliseconds = s * 1000;   
    return (hoursMilliseconds + minuteMilliseconds + secondsMiliseconds);
  }
}
