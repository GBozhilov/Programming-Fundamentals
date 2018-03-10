using System;

public class PrintingTriangle
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        PrintUpperTriangle(number);
        PrintBottomTriangle(number);
    }

    static void PrintUpperTriangle(int n)
    {
        for (int row = 0; row <= n; row++)
        {
            PrintLine(1, row);
        }
    }

    static void PrintBottomTriangle(int n)
    {
        for (int row = n - 1; row >= 1; row--)
        {
            PrintLine(1, row);
        }
    }

    static void PrintLine(int start, int end)
    {
        for (int currentNum = start; currentNum <= end; currentNum++)
        {
            Console.Write($"{currentNum} ");
        }
        Console.WriteLine();
    }
}