using System;

public class HouseBuilder
{
    public static void Main()
    {
        var firstPrice = long.Parse(Console.ReadLine());
        var secondPrice = long.Parse(Console.ReadLine());

        Console.WriteLine(4 * Math.Min(firstPrice, secondPrice)
            + 10 * Math.Max(firstPrice, secondPrice));
    }
}