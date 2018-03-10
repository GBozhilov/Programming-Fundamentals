using System;
using System.Linq;

public class EnduranceRally
{
    public static void Main()
    {
        var drivers = Console.ReadLine()
            .Split(' ');
        var trackLayout = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToArray();
        var checkpoints = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        foreach (var driver in drivers)
        {
            double fuel = driver[0];
            var hasFinished = true;

            for (int i = 0; i < trackLayout.Length; i++)
            {
                var fuelPoints = trackLayout[i];
                var isCheckpoint = checkpoints.Contains(i);

                fuel = isCheckpoint ? fuel += fuelPoints : fuel -= fuelPoints;

                if (fuel <= 0)
                {
                    Console.WriteLine($"{driver} - reached {i}");
                    hasFinished = false;
                    break;
                }
            }

            if (hasFinished)
            {
                Console.WriteLine($"{driver} - fuel left {fuel:F2}");
            }
        }
    }
}