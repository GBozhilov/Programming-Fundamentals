using System;

public class WaterOverflow
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        const int maxCapacity = 255;
        var tankContent = 0;

        for (int i = 0; i < n; i++)
        {
            var currentLiters = int.Parse(Console.ReadLine());

            var freeSpace = maxCapacity - tankContent;

            if (freeSpace < currentLiters)
            {
                Console.WriteLine("Insufficient capacity!");
                continue;
            }

            tankContent += currentLiters;
        }

        Console.WriteLine(tankContent);
    }
}