using System;
using System.Collections.Generic;

public static class ResistorColorTrio
{
    private static readonly List<string> resistorColors = new List<string>()
    {
        "black",
        "brown",
        "red",
        "orange",
        "yellow",
        "green",
        "blue",
        "violet",
        "grey",
        "white"
    };

    public static string Label(string[] colors)
    {
        int labelValue = resistorColors.IndexOf(colors[0]) * 10 + resistorColors.IndexOf(colors[1]);
        labelValue *= (int)Math.Pow(10, resistorColors.IndexOf(colors[2]));

        return (labelValue > 1000 ? (labelValue / 1000 +  " kiloohms") : (labelValue +  " ohms"));
    }
}
