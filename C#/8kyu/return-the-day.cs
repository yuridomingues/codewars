/*
Complete the function which returns the weekday according to the input number:

    1 returns "Sunday"
    2 returns "Monday"
    3 returns "Tuesday"
    4 returns "Wednesday"
    5 returns "Thursday"
    6 returns "Friday"
    7 returns "Saturday"
    Otherwise returns "Wrong, please enter a number between 1 and 7"
*/

//My solution
public class Kata
{
    public static string WhatDay(int n)
    {
        if (n == 1)
        {
            return "Sunday";
        }
        else if (n == 2)
        {
            return "Monday";
        }
        else if (n == 3)
        {
            return "Tuesday";
        }
        else if (n == 4)
        {
            return "Wednesday";
        }
        else if (n == 5)
        {
            return "Thursday";
        }
        else if (n == 6)
        {
            return "Friday";
        }
        else if (n == 7)
        {
            return "Saturday";
        }
        else
        {
            return "Wrong, please enter a number between 1 and 7";
        }
    }
}