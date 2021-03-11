using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if (input == "")
            return false;

        input = input.ToLower();
        bool[] letters = new bool[26];

        foreach (char currChar in input)
        {
            int charIndex = currChar - 97;
            if (charIndex < 26 && charIndex >= 0)
                letters[charIndex] = true;
        }

        foreach (bool letter in letters)
            if (!letter)
                return false;

        return true;
    }
}
