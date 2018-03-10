using System;

public class SumOfChars
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var sum = 0;

        for (int i = 0; i < n; i++)
        {
            var currentSymbol = Console.ReadLine()[0];

            sum += currentSymbol;
        }

        Console.WriteLine($"The sum equals: {sum}");
    }
}