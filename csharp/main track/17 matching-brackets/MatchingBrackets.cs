using System.Collections.Generic;

public static class MatchingBrackets
{
    private static readonly List<char> openingBrackets = new List<char> { '{', '[', '(' };
    private static readonly List<char> closingBrackets = new List<char> { '}', ']', ')' };

    public static bool IsPaired(string input)
    {
        if (input == "") return true;

        Stack<char> brackets = new Stack<char>();

        foreach (char next in input)
        {
            if (openingBrackets.Contains(next))
            {
                brackets.Push(next);
            }
            else
            {
                if (closingBrackets.Contains(next))
                {
                    if (brackets.Count > 0)
                    {
                        char previous = brackets.Peek();

                        if (closingBrackets.IndexOf(next) == openingBrackets.IndexOf(previous))
                        {
                            brackets.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        return brackets.Count == 0;
    }
}
