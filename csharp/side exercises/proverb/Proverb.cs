using System.Collections.Generic;
using System.Linq;

public static class Proverb
{
    private static List<string> proverb = new List<string>();
    private static List<string> mySubjects = new List<string>();

    public static string[] Recite(string[] subjects)
    {
        if (subjects.Length == 0) return subjects;

        proverb.Clear();
        mySubjects = subjects.ToList();
        GenerateProverb(subjects.Length);

        return proverb.ToArray();
    }

    private static void GenerateProverb(int count) {
        if (count == 1) {
            proverb.Add ($"And all for the want of a {mySubjects[0]}.");
        } else {
            proverb.Insert(0, $"For want of a {mySubjects[count - 2]} the {mySubjects[count - 1]} was lost."); 
            GenerateProverb(count - 1);
        }        
    }
}