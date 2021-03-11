using System;
using System.Text;

public static class Raindrops
{
    private static readonly string[] answers = new string[] { "Pling", "Plang", "Plong" };
    private static readonly int[] divisors = new int[] { 3, 5, 7 };

    public static string Convert(int number)
    {
        StringBuilder answer = new StringBuilder();

        for (int i = 0; i < answers.Length; i++)
            if (number % divisors[i] == 0)
                answer.Append(answers[i]);

        return answer.Length == 0 ? number.ToString() : answer.ToString();
    }
}