using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1) { throw new ArgumentOutOfRangeException(); }

        int difference = -number * 2;
        int increment = number % 2 == 0 ? 1 : 2;

        for (int i = 1; i < Math.Sqrt(number); i += increment){
            if (number % i == 0) { 
                difference += i;

                if (number / i != i) { difference += number / i; }
            }
        }

        return difference == 0 ? Classification.Perfect : difference < 0 ? Classification.Deficient : Classification.Abundant;
    }
}
