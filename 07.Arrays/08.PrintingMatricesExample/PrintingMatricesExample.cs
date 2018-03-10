using System;

public class PrintingMatricesExample
{
    public static void Main()
    {
        // Declare and initialize a matrix of size 2 x 4
        int[,] matrix =
        {
            { 1, 2, 3, 4 }, // row 0 values
            { 5, 6, 7, 8 }, // row 1 values
        };

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write($"{matrix[row, col]} ");
            }
            Console.WriteLine();
        }
    }
}