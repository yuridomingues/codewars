/*
Implement a function that accepts 3 integer values a, b, c. The function should return true if a triangle can be built with the sides of given length and false in any other case.

(In this case, all triangles must have surface greater than 0 to be accepted).
*/

// My solution

public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            return false;
        }
        else if (a + b > c && a + c > b && b + c > a)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}