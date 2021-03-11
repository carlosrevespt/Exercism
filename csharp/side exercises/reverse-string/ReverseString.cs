using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] text = input.ToCharArray();
        Array.Reverse(text);

        return new string(text);
    }
}