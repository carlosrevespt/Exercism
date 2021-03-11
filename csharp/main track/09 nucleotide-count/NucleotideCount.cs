using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {     
        IDictionary<char, int> nucleotCount = new Dictionary<char, int> {{'A', 0}, {'C', 0}, {'G', 0}, {'T', 0}};
        
        foreach (char c in sequence) {
            if (nucleotCount.ContainsKey(c)) {
                nucleotCount[c]++;
            } else {
                throw new ArgumentException();
            }
        }

        return nucleotCount;
    }
}