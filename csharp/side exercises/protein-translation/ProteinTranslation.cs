using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    private static readonly Dictionary<string, string> proteins = new Dictionary<string, string>() {
        { "AUG", "Methionine" },
        { "UUU", "Phenylalanine" }, { "UUC", "Phenylalanine"},
        { "UUA", "Leucine" }, { "UUG", "Leucine" },
        { "UCU", "Serine" }, { "UCC", "Serine" }, { "UCA", "Serine" }, { "UCG", "Serine" },
        { "UAU", "Tyrosine" }, { "UAC", "Tyrosine" },
        { "UGU", "Cysteine" }, { "UGC", "Cysteine" },
        { "UGG", "Tryptophan" },
        { "UAA", "STOP" }, { "UAG", "STOP" }, { "UGA", "STOP" }
    };

    public static string[] Proteins(string strand)
    {
        List<string> result = new List<string>();

        for (int i = 0; i < strand.Length; i += 3)
        {
            string codon = strand.Substring(i, 3);

            if (proteins[codon].Equals("STOP"))
                return result.ToArray();

            result.Add(proteins[codon]);
        }

        return result.ToArray();
    }
}