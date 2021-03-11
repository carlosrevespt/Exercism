using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly List<int> myHighScores;

    public HighScores(List<int> list)
    {
        myHighScores = list;
    }

    public List<int> Scores() => myHighScores;

    public int Latest() => myHighScores.Last();

    public int PersonalBest() => myHighScores.Max();

    public List<int> PersonalTopThree() => myHighScores.OrderByDescending(i => i).Take(3).ToList();
}