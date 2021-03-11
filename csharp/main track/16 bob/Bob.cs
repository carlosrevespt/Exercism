using System.Text.RegularExpressions;

using static StatementTypes;

enum StatementTypes
{
    Question,
    YellQuestion,
    Yell,
    NothingSaid,
    EverythingElse
}

public static class Bob
{
    private static readonly string[] responses = new string[] {
        "Sure.",
        "Calm down, I know what I'm doing!",
        "Whoa, chill out!",
        "Fine. Be that way!",
        "Whatever." };

    public static string Response(string statement)
    {
        return responses[(int)GetResponse(statement.Trim())];
    }

    private static StatementTypes GetResponse(string statement)
    {
        bool isQuestion = statement.EndsWith("?");
        int letters = Regex.Replace(statement, @"[\W\d]", "").Length;
        bool allCaps = letters > 0 && Regex.Replace(statement, @"[^A-Z]", "").Length == letters;

        if (isQuestion)
        {
            return allCaps ? YellQuestion : Question;
        }
        else
        {
            if (allCaps)
            {
                return Yell;
            }
            else
            {
                bool onlyCtrlAndSpaces = Regex.Replace(statement, @"[\p{C}\s]", "").Length == 0;
                return onlyCtrlAndSpaces ? NothingSaid : EverythingElse;
            }
        }
    }
}