using System;
using System.Linq;
using System.Collections.Generic;

public static class RnaTranscription
{
    private static Dictionary<string, string> pairs = new Dictionary<string, string> {{"A", "u"}, {"C", "g"}, {"G", "c"}, {"T", "a"}};
    public static string ToRna(string nucleotide) => pairs.Aggregate(nucleotide, (dna, rna) 
                                                  => dna.Replace(rna.Key, rna.Value)).ToUpper();
}