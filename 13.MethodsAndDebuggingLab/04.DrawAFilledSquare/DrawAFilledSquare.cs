using System;

public class DrawAFilledSquare
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        PrintHeaderRow(n);

        for (int i = 0; i < n - 2; i++)
        {
            PrintMiddleRow(n);
        }

        PrintHeaderRow(n);
    }

    public static void PrintMiddleRow(int n)
    {
        Console.Write("-");

        for (int j = 0; j < n - 1; j++)
        {
            Console.Write("\\/");
        }

        Console.WriteLine("-");
    }

    public static void PrintHeaderRow(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }
}