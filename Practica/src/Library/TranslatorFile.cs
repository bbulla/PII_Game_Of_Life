using System;
using System.IO;

namespace GameOfLife

{
class TranslatorFile

{
    public string filePath;
    public bool[,] board;

    public TranslatorFile
    (string filePath)
    {
        this.filePath = filePath;
        ReadFileAndCreateBoard();
    }

    public void ReadFileAndCreateBoard()
    {
        string content = File.ReadAllText(filePath);
        string[] contentLines = content.Split('\n');
        int rows = contentLines.Length;
        int cols = contentLines[0].Length;

        board = new bool[rows, cols];

        for (int y = 0; y < rows; y++)
        {
            for (int x = 0; x < cols; x++)
            {
                if (contentLines[y][x] == '1')
                {
                    board[y, x] = true;
                }
            }
        }
    }

    public bool[,] GetBoolBoard()
    {
        return board;
    }
}
}