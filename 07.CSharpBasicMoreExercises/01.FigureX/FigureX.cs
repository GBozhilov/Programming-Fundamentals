using System;

public class FigureX
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        // Top
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string(' ', i) + "x");
            Console.WriteLine(new string(' ', n - 2 - 2 * i) + "x");
        }

        // Middle row
        Console.WriteLine(new string(' ', n / 2) + "x");

        // Bottom
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string(' ', n / 2 - 1 - i) + "x");
            Console.WriteLine(new string(' ', 2 * i + 1) + "x");
        }
    }
}