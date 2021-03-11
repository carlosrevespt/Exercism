using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength > numbers.Length)
            throw new ArgumentException();

        if (sliceLength <= 0)
            throw new ArgumentException();

        if (numbers.Length == 0)
            throw new ArgumentException();

        List<string> series = new List<string>();

        for (int sliceStart = 0; sliceStart <= numbers.Length - sliceLength; sliceStart++)
            series.Add(numbers.Substring(sliceStart, sliceLength));

        return series.ToArray();
    }
}