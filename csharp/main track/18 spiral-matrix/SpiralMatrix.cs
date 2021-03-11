using System;

public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[] defineLine = { 0, 1, 0, -1 };
        int[] defineColumn = { 1, 0, -1, 0 };
        int line = 0;
        int column = -1;
        int value = 0;
        int[,] matrix = new int[size, size];

        for (int i = 0, iMatrix = 0; i < 2 * size - 1; ++i, iMatrix = i % 4)
            for (int j = 0, jLen = (2 * size - i) / 2; j < jLen; ++j)
                matrix[line += defineLine[iMatrix], column += defineColumn[iMatrix]] = ++value;

        return matrix;
    }
}
