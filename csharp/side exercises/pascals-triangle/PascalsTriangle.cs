using System;
using System.Collections.Generic;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        for (int i = 0; i < rows; i++){
            yield return NthRow(i);
        }
    }

    private static IEnumerable<int> NthRow (int row){
        int previous = 1;
        yield return previous;

        for (int i = 1; i <= row; i++){
            int current = (previous * (row - i + 1) / i);
            yield return current;
            previous = current;
        }        
    }

}