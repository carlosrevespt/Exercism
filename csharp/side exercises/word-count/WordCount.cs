using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class WordCount
{
    public static IDictionary<string, int> CountWords(string phrase)
    {
        //Regex rex = new Regex(@"\b[^\s,]+\b");
        Regex rex = new Regex(@"[^\w-[']]");
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        
        foreach (Match word in rex.Matches(phrase)){
            string currentWord = word.ToString().ToLower();
            if (currentWord != string.Empty && wordCount.ContainsKey(currentWord)){
                wordCount[currentWord]++;
            } else {
                wordCount.Add(currentWord, 1);
            }
        }

        return wordCount;
    }
}