using System;

public static class StringExtensions
{
    public static bool IsUpperCase(this string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (Char.IsLetter(text[i]) && !Char.IsUpper(text[i]))
            {
                return false;
            }
        }
        return true;
    }
}