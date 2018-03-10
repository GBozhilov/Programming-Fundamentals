using System;

public class BackIn30Minutes
{
    public static void Main()
    {
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());

        minutes += 30;

        if (minutes > 59)
        {
            hours += minutes / 60;
            minutes %= 60;
        }

        if (hours >= 24)
        {
            hours %= 24;
        }

        Console.WriteLine($"{hours}:{minutes:D2}");
    }
}