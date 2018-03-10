using System;
using System.Linq;

public class SinoTheWalker
{
    public static void Main()
    {
        var leavingTimeParams = Console.ReadLine()
            .Split(':')
            .Select(int.Parse)
            .ToArray();
        var stepsCount = int.Parse(Console.ReadLine());
        var secondsPerStep = int.Parse(Console.ReadLine());

        var leavingSeconds = leavingTimeParams[0] * 3600 + leavingTimeParams[1] * 60 + leavingTimeParams[2];
        var travelSeconds = (long)stepsCount * secondsPerStep;
        var finalSeconds = leavingSeconds + travelSeconds;

        var hours = (finalSeconds / 3600) % 24;
        var minutes = (finalSeconds / 60) % 60;
        var seconds = finalSeconds % 60;

        Console.WriteLine($"Time Arrival: {hours:D2}:{minutes:D2}:{seconds:D2}");
    }
}