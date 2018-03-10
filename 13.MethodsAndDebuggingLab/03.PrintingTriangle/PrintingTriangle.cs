using System;

public class PrintingTriangle
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        PrintTriangle(n);
    }

    public static void PrintTriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            PrintLine(1, i);
        }

        for (int i = n - 1; i >= 1; i--)
        {
            PrintLine(1, i);
        }
    }

    public static void PrintLine(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(i != end ? $"{i} " : $"{i}");
        }

        Console.WriteLine();
    }
}