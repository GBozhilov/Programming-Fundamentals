using System;

public class CharityMarathon
{
    public static void Main()
    {
        var marathonDays = int.Parse(Console.ReadLine());
        var listedParticipants = int.Parse(Console.ReadLine());
        var averageNumberOfLaps = int.Parse(Console.ReadLine());
        var lapLength = int.Parse(Console.ReadLine());
        var trackCapacity = int.Parse(Console.ReadLine());
        var moneyPerKilometer = decimal.Parse(Console.ReadLine());

        var maxRunners = (long)marathonDays * trackCapacity;
        var participants = Math.Min(listedParticipants, maxRunners);
        var totalMeters = participants * averageNumberOfLaps * lapLength;
        var totalKilometers = totalMeters / 1000M;

        var moneyRaised = totalKilometers * moneyPerKilometer;

        Console.WriteLine($"Money raised: {moneyRaised:F2}");
    }
}