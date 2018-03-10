using System;

public class ReversedChars
{
    public static void Main()
    {
        var firstLetter = Console.ReadLine()[0];
        var secondLetter = Console.ReadLine()[0];
        var thirdLetter = Console.ReadLine()[0];

        Console.WriteLine($"{thirdLetter}{secondLetter}{firstLetter}");
    }
}