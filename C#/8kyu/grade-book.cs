/*
Complete the function so that it finds the average of the three scores passed to it and returns the letter value associated with that grade.
Numerical Score 	Letter Grade
90 <= score <= 100 	'A'
80 <= score < 90 	'B'
70 <= score < 80 	'C'
60 <= score < 70 	'D'
0 <= score < 60 	'F'

Tested values are all between 0 and 100. Theres is no need to check for negative values or values greater than 100.
*/

// My solution

using System;

public class Kata
{
    public static char GetGrade(int s1, int s2, int s3)
    {
        // Calculate the average score
        int averageScore = (s1 + s2 + s3) / 3;

        // Determine the letter grade based on the average score
        if (averageScore >= 90)
        {
            return 'A';
        }
        else if (averageScore >= 80)
        {
            return 'B';
        }
        else if (averageScore >= 70)
        {
            return 'C';
        }
        else if (averageScore >= 60)
        {
            return 'D';
        }
        else
        {
            return 'F';
        }
    }
}


// 1. Pegar a média dos 3 valores
// 2. Usar a média e devolver a letra de acordo com a grade numérica
// 3. Retornar a letra