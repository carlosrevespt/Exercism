using System;
using System.Collections.Generic;

public static class ResistorColorDuo
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

    public static int Value(string[] colors) => resistorColors.IndexOf(colors[0]) * 10 + 
                                                resistorColors.IndexOf(colors[1]);

}
