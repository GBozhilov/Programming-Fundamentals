using System;

public class DayOfWeek
{
    public static void Main()
    {
        string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday",
            "Thursday", "Friday", "Saturday", "Sunday" };

        int day = int.Parse(Console.ReadLine());

        bool IsCorrectDay = (day >= 1) && (day <= 7);

        Console.WriteLine(IsCorrectDay ? daysOfWeek[day - 1] : "Invalid day!");
    }
}