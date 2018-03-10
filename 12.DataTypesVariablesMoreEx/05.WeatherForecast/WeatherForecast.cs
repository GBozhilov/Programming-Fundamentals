using System;

public class WeatherForecast
{
    public static void Main()
    {
        var numberStr = Console.ReadLine();

        long number = 0;

        if (!long.TryParse(numberStr, out number))
        {
            Console.WriteLine("Rainy");
            return;
        }

        PrintMessage(number);
    }

    public static void PrintMessage(long number)
    {
        if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
        {
            Console.WriteLine("Sunny");
        }
        else if (number >= int.MinValue && number <= int.MaxValue)
        {
            Console.WriteLine("Cloudy");
        }
        else if (number >= long.MinValue && number <= long.MaxValue)
        {
            Console.WriteLine("Windy");
        }
    }
}