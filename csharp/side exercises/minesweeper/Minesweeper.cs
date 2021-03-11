using System;
using System.Text;
using System.Collections.Generic;

public static class Minesweeper
{
    public static string[] Annotate(string[] input)
    {
        return input switch {
            string[] a when a.Length < 1    => input,
            string[] a when a[0].Length < 1 => input, 
            _                               => GenerateBoard(input)
        };
    }

    private static string[] GenerateBoard (string[] input){
        int rows = input.Length;
        int columns = input[0].Length;
        //int[][] board = new int[rows][];
        List<List<int>> board = new List<List<int>>();

        for (int i = 0; i < rows; i++){
            board.Add(new List<int>(new int[columns]));
        }

        for (int i = 0; i< rows; i++){
            for (int j = 0; j < columns; j++){
                if (input[i][j] == '*'){
                    int rowStart = (i == 0) ? 0 : -1;
                    int rowEnd = (i == rows - 1) ? 0 : 1;
                    int columnStart = (j == 0) ? 0 : -1;
                    int columnEnd = (j == columns - 1) ? 0 : 1;
                    for (int m = i + rowStart; m <= i + rowEnd; m++){
                        for (int n = j + columnStart; n <= j + columnEnd; n++){
                            board[m][n]++;
                        }
                    }
                }
            }
        }
        
        return GenerateAnnotation(board, rows, columns, input);
    }

    private static string[] GenerateAnnotation(List<List<int>> board, int rows, int columns, string[] input){
        string[] annotated = new string[rows];
        StringBuilder boardLine = new StringBuilder();

        for (int row = 0; row < rows; row++){
            for (int column = 0; column < columns; column++){
                string charToAppend;
                if (input[row][column] == '*') {
                    charToAppend = "*";
                } else {
                    charToAppend = board[row][column] switch {
                        0 => " ",
                        _ => board[row][column].ToString()
                    };
                }
                boardLine.Append(charToAppend);
            }
            annotated[row] = boardLine.ToString();
            boardLine.Clear();
        }

        return annotated;
    }
}
