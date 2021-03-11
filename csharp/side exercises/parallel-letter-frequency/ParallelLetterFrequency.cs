using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

public static class ParallelLetterFrequency
{
    public static Dictionary<char, int> Calculate(IEnumerable<string> texts)
    {
        return texts
            .AsParallel()
            .SelectMany(c => c.ToLower()
                                .Where(char.IsLetter))
            .GroupBy(c => c)
            .ToDictionary(c => c.Key, c => c.Count());
    }
}