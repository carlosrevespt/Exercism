using System.Linq;
using System.Collections.Generic;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> result = new Dictionary<string, int>(); 
        foreach (var item in old){
            foreach (string s in item.Value){
                string sNew = s.ToLower();
                if (result.ContainsKey(sNew)){
                    result[sNew] += item.Key;
                } else {
                    result.Add(sNew, item.Key);
                }
            }
        }
        
        return result.OrderBy(i => i.Key).ToDictionary(i => i.Key, i => i.Value);
    }
}