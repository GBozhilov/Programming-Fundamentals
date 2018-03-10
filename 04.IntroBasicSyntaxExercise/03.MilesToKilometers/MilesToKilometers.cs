using System;

public class MilesToKilometers
{
    public static void Main()
    {
        var miles = double.Parse(Console.ReadLine());
        const double factor = 1.60934;

        var kilometers = miles * factor;

        Console.WriteLine($"{kilometers:F2}");
    }
}