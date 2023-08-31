using System;
using System.Text;
using System.Threading;


namespace GameOfLife
{
class Program
{ 
    static void Main(string[] args)
    {
        string filePath = "ruta_del_archivo.txt"; // Cambia esto a la ruta de tu archivo
        TranslatorFile reader = new TranslatorFile(filePath);
        bool[,] initialBoard = reader.GetBoolBoard();

        NextGenerationCalculator calculator = new NextGenerationCalculator(initialBoard);
        Print printer = new Print(calculator);
        Board board = new Board(initialBoard);

        Thread printThread = new Thread(new ThreadStart(printer.PrintBoard));
        printThread.Start();

        // Código adicional si es necesario

        printThread.Join(); // Esperar hasta que la impresión termine (esto puede ser opcional)
    }
}
}