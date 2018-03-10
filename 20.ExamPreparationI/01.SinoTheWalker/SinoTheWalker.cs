using System;
using System.Globalization;

public class SinoTheWalker
{
    public static void Main()
    {
        var timeFormat = "HH:mm:ss";
        var leavingTime = DateTime.ParseExact(Console.ReadLine(), timeFormat,
            CultureInfo.InvariantCulture);
        var numberOfSteps = long.Parse(Console.ReadLine());
        var timePerStep = int.Parse(Console.ReadLine());

        var secondsInDay = 24 * 60 * 60;
        var travelSeconds = numberOfSteps * timePerStep % secondsInDay;
        var arrivalTime = leavingTime.AddSeconds(travelSeconds);

        Console.WriteLine($"Time Arrival: {arrivalTime.ToString(timeFormat)}");
    }
}