using System;

public class ConvertSpeedUnits
{
    public static void Main()
    {
        var meters = int.Parse(Console.ReadLine());
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());
        var seconds = int.Parse(Console.ReadLine());

        var kilometers = meters / 1000F;
        var miles = meters / 1609F;
        var timeInSeconds = hours * 3600 + minutes * 60 + seconds;
        var timeInHours = hours + minutes / 60F + seconds / 3600F;

        var metersPerSecond = meters / (float)timeInSeconds;
        var kilometersPerHour = kilometers / timeInHours;
        var milesPerHour = miles / timeInHours;

        Console.WriteLine(metersPerSecond);
        Console.WriteLine(kilometersPerHour);
        Console.WriteLine(milesPerHour);
    }
}