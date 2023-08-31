using System;
using System.Text;
using System.Threading;

namespace GameOfLife
{
class Print
{
    public NextGenerationCalculator calculator;

    public Print(NextGenerationCalculator calculator)
    {
        this.calculator = calculator;
    }

    public void PrintBoard()
    {
        while (true)
        {
            Console.Clear();
            bool[,] currentBoard = calculator.GetNextGeneration();
            StringBuilder s = new StringBuilder();
            
            // Código para imprimir el tablero actual, similar a lo que ya habíamos implementado
            
            Console.WriteLine(s.ToString());
            
            calculator.CalculateNextGeneration(); // Calcular siguiente generación

            Thread.Sleep(300);
        }
    }
}
}