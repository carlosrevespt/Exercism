using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max) => max * max * (max * (max + 2) + 1) / 4;

    public static int CalculateSumOfSquares(int max) => (max * (max + 1) / 2) * (2 * max + 1) / 3;

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}