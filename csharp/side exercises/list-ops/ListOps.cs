using System;
using System.Collections.Generic;

public static class ListOps
{
    public static int Length<T>(List<T> input)
    {
        int total = 0;

        try {
            while (total > -1) {
                var element = input[total];
                total++;
            }
        }

        catch {}

        return total;
    }

    public static List<T> Reverse<T>(List<T> input)
    {
        int myLength = Length(input);
        if (myLength == 0) return input;
        
        for (int i = 0; i < myLength / 2; i++){
            var current = input[myLength - i - 1];
            input[myLength - i - 1] = input[i];
            input[i] = current;
        }

        return input;
    }

    public static List<TOut> Map<TIn, TOut>(List<TIn> input, Func<TIn, TOut> map)
    {
        List<TOut> result = new List<TOut>();
        foreach (var item in input){
            result.Add(map(item));
        }
        
        return result;
    }

    public static List<T> Filter<T>(List<T> input, Func<T, bool> predicate)
    {
        List<T> result = new List<T>();
        foreach (var item in input){
            if (predicate(item)) result.Add(item);
        }

        return result;
    }

    public static TOut Foldl<TIn, TOut>(List<TIn> input, TOut start, Func<TOut, TIn, TOut> func)
    {
        foreach(TIn value in input){
            start = func(start, value);
        }

        return start;
    }

    public static TOut Foldr<TIn, TOut>(List<TIn> input, TOut start, Func<TIn, TOut, TOut> func)
    {
        int myLength = Length(input);

        for (int i = myLength - 1; i >= 0; i--){
            start = func(input[i], start);
        }

        return start;
    }

    public static List<T> Concat<T>(List<List<T>> input)
    {
        List<T> newList = new List<T>();

        if (Length(input) != 0) {
            foreach(List<T> current in input){
                Append(newList, current);
            }
        }
        
        return newList;
    }

    public static List<T> Append<T>(List<T> left, List<T> right)
    {
        left.AddRange(right);
        return left;
    }
}