using System;
using System.Linq;

public class EnduranceRally
{
    public static void Main()
    {
        var drivers = Console.ReadLine()
            .Split(' ');
        var fuelZones = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToArray();
        var checkpoints = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        foreach (var driver in drivers)
        {
            double fuel = driver.First();
            var hasFinished = true;

            for (int zone = 0; zone < fuelZones.Length; zone++)
            {
                var fuelPoints = fuelZones[zone];
                var isCheckpoint = checkpoints.Contains(zone);

                fuel = isCheckpoint ? fuel + fuelPoints : fuel - fuelPoints;

                if (fuel <= 0)
                {
                    Console.WriteLine($"{driver} - reached {zone}");
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