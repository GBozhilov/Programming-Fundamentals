using System;

public class BPMCounter
{
    public static void Main()
    {
        var beatsPerMinute = int.Parse(Console.ReadLine());
        var numberOfBeats = int.Parse(Console.ReadLine());

        var bars = Math.Round(numberOfBeats / 4.0, 1); 

        var beatsPerSecond = beatsPerMinute / 60.0;
        var totalSeconds = numberOfBeats / beatsPerSecond;

        var minutes = (int)totalSeconds / 60;
        var seconds = (int)totalSeconds % 60;

        Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
    }
}