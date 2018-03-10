using System;

public class DrawFilledSquare
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintEndRow(n);

        for (int row = 0; row < n - 2; row++)
            PrintMiddleRow(n);

        PrintEndRow(n);
    }

    static void PrintEndRow(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }

    static void PrintMiddleRow(int n)
    {
        Console.Write('-');
        for (int row = 0; row < n - 1; row++)
        {
            Console.Write("\\/");
        }
        Console.WriteLine('-');
    }
}