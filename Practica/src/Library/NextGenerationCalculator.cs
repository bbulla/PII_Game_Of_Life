using System;

namespace GameOfLife
{
class NextGenerationCalculator
{
    public bool[,] currentBoard;
    public int width;
    public int height;

    public NextGenerationCalculator(bool[,] initialBoard)
    {
        currentBoard = initialBoard;
        width = currentBoard.GetLength(0);
        height = currentBoard.GetLength(1);
    }

    public void CalculateNextGeneration()
    {
        bool[,] nextGeneration = new bool[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                int aliveNeighbors = CountAliveNeighbors(x, y);

                if (currentBoard[x, y])
                {
                    // Reglas para células vivas
                    if (aliveNeighbors < 2 || aliveNeighbors > 3)
                    {
                        nextGeneration[x, y] = false;
                    }
                    else
                    {
                        nextGeneration[x, y] = true;
                    }
                }
                else
                {
                    // Regla para células muertas
                    if (aliveNeighbors == 3)
                    {
                        nextGeneration[x, y] = true;
                    }
                    else
                    {
                        nextGeneration[x, y] = false;
                    }
                }
            }
        }

        currentBoard = nextGeneration;
    }

    public int CountAliveNeighbors(int x, int y)
    {
        int aliveNeighbors = 0;
        for (int i = x - 1; i <= x + 1; i++)
        {
            for (int j = y - 1; j <= y + 1; j++)
            {
                if (i >= 0 && i < width && j >= 0 && j < height && currentBoard[i, j])
                {
                    aliveNeighbors++;
                }
            }
        }
        return aliveNeighbors;
    }

    public bool[,] GetNextGeneration()
    {
        return currentBoard;
    }
}

}