using System;

public class Hotel
{
    public static void Main()
    {
        var month = Console.ReadLine();
        var nights = int.Parse(Console.ReadLine());

        var studioPerNight = 0.0;
        var doublePerNight = 0.0;
        var suitePerNight = 0.0;

        switch (month)
        {
            case "May":
            case "October":
                studioPerNight = 50;
                doublePerNight = 65;
                suitePerNight = 75;

                if (nights > 7)
                {
                    studioPerNight -= 0.05 * studioPerNight;
                }
                break;
            case "June":
            case "September":
                studioPerNight = 60;
                doublePerNight = 72;
                suitePerNight = 82;

                if (nights > 14)
                {
                    doublePerNight -= 0.10 * doublePerNight;
                }
                break;
            case "July":
            case "August":
            case "December":
                studioPerNight = 68;
                doublePerNight = 77;
                suitePerNight = 89;

                if (nights > 14)
                {
                    suitePerNight -= 0.15 * suitePerNight;
                }
                break;
        }

        var studioPrice = nights * studioPerNight;
        var doublePrice = nights * doublePerNight;
        var suitePrice = nights * suitePerNight;

        if (nights > 7 && (month == "September" || month == "October"))
        {
            studioPrice -= studioPerNight;
        }

        Console.WriteLine($"Studio: {studioPrice:F2} lv.");
        Console.WriteLine($"Double: {doublePrice:F2} lv.");
        Console.WriteLine($"Suite: {suitePrice:F2} lv.");
    }
}