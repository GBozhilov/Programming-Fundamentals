using System;
using System.Globalization;

public class SinoTheWalker
{
    public static void Main()
    {
        var timeFormat = "HH:mm:ss";

        var leavingTime = DateTime.ParseExact(Console.ReadLine(), timeFormat, 
            CultureInfo.InvariantCulture);
        var stepsCount = int.Parse(Console.ReadLine());
        var secondsPerStep = int.Parse(Console.ReadLine());

        var secondsInDay = 86400; // 24 * 60 * 60
        var totalSeconds = ((long)stepsCount * secondsPerStep) % secondsInDay;

        var arrivalTime = leavingTime.AddSeconds(totalSeconds);

        Console.WriteLine($"Time Arrival: {arrivalTime.ToString(timeFormat)}");
    }
}