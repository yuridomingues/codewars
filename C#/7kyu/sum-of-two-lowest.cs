/*
Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers. No floats or non-positive integers will be passed.
*/

// My solution

using System;
using System.Linq;

public static class Kata
{
	public static int sumTwoSmallestNumbers(int[] numbers)
	{
    var secondLowest = numbers.OrderBy(num => num).ElementAt(1);
    return (numbers.Min() + secondLowest);
	}
}