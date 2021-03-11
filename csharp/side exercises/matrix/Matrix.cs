using System.Linq;
using System.Collections.Generic;

public class Matrix
{
    private readonly int[,] matrix;

    public Matrix(string input)
    {
        matrix = ComposeMatrix(input);
    }

    public int Rows { get; private set; }

    public int Cols { get; private set; }

    public IEnumerable<int> Row(int row)
    {
        for (int col = 0; col < Cols; col++)
            yield return matrix[row - 1, col];
    }

    public IEnumerable<int> Column(int col)
    {
        for (int row = 0; row < Rows; row++)
            yield return matrix[row, col - 1];
    }

    private int[,] ComposeMatrix (string input){
        string[] rows = input.Split("\n");
        Rows = rows.Length;
        Cols = rows[0].Count(char.IsWhiteSpace) + 1;
        int[,] localMatrix = new int[Rows, Cols];

        for (int i = 0; i < Rows; i++){
			string[] cols = rows[i].Split(" ");
            for (int j = 0; j < Cols; j++)
                localMatrix[i, j] = int.Parse(cols[j]);
		}

        return localMatrix;
    }
}