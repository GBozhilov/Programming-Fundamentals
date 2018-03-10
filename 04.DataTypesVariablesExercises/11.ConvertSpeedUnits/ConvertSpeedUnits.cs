using System;

public class ConvertSpeedUnits
{
    public static void Main()
    {
        int disInMeters = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());

        float disInKilometers = disInMeters / 1000F;
        float disInMiles = disInMeters / 1609F;
        float timeInHours = hours + minutes / 60F + seconds / 3600F;
        float timeInSeconds = hours * 3600 + minutes * 60 + seconds;

        float metersPerSecond = disInMeters / timeInSeconds;
        float kilometersPerHour = disInKilometers / timeInHours;
        float milesPerHour = disInMiles / timeInHours;

        Console.WriteLine(metersPerSecond);
        Console.WriteLine(kilometersPerHour);
        Console.WriteLine(milesPerHour);
    }
}