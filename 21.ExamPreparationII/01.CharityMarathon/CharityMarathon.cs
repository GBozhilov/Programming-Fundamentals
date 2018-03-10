using System;

public class CharityMarathon
{
    public static void Main()
    {
        var marathonDays = int.Parse(Console.ReadLine());
        var participants = int.Parse(Console.ReadLine());
        var averageLapsPerRunner = int.Parse(Console.ReadLine());
        var lapLength = int.Parse(Console.ReadLine());
        var trackCapacity = int.Parse(Console.ReadLine());
        var moneyPerKilometer = double.Parse(Console.ReadLine());

        long maxRunners = trackCapacity * marathonDays;
        var totalRunners = Math.Min(participants, maxRunners);
        var totalMeters = totalRunners * averageLapsPerRunner * lapLength;
        var totalKilometers = totalMeters / 1000.0;

        var moneyRaised = totalKilometers * moneyPerKilometer;

        Console.WriteLine($"Money raised: {moneyRaised:F2}");
    }
}