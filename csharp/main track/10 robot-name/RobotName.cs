using System;
using System.Collections.Generic;

public class Robot
{
    private string myName;
    private static HashSet<string> allNames = new HashSet<string>();
    private static Random rng = new Random();

    public Robot() { myName = generateName(); }

    public string Name => myName;

    public void Reset() { allNames.Remove(myName); myName = generateName(); }

    private string generateName(){
        string newName;

        do {
            char c1 = (char) rng.Next(65, 91);
            char c2 = (char) rng.Next(65, 91);
            int num = rng.Next(0, 1000);
            newName = $"{c1}{c2}{num.ToString("D3")}";
        } while (!allNames.Add(newName));

        return newName;
    }
}