using System;

public class BeerKegs
{
    public static void Main()
    {
        var kegsCount = int.Parse(Console.ReadLine());

        var biggestModel = string.Empty;
        double biggestVolume = 0;

        while (kegsCount > 0)
        {
            var model = Console.ReadLine();
            var radius = double.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var volume = Math.PI * Math.Pow(radius, 2) * height;

            if (volume > biggestVolume)
            {
                biggestModel = model;
                biggestVolume = volume;
            }

            kegsCount--;
        }

        Console.WriteLine(biggestModel);
    }
}