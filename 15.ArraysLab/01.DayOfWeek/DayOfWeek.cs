using System;

public class DayOfWeek
{
    public static void Main()
    {
        var day = int.Parse(Console.ReadLine());

        var daysOfWeek = new string[]
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

        var isValidDay = day >= 1 && day <= 7;

        Console.WriteLine(isValidDay ? daysOfWeek[day - 1] : "Invalid Day!");
    }
}