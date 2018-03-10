using System;
using System.Globalization;
using System.Linq;

public class CountWorkingDays
{
    public static void Main()
    {
        var timeFormat = "dd-MM-yyyy";

        var startDate = DateTime.ParseExact(Console.ReadLine(), timeFormat,
            CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(), timeFormat,
            CultureInfo.InvariantCulture);

        var officialHolidays = new DateTime[]
        {
            new DateTime(2017, 1, 1),
            new DateTime(2017, 3, 3),
            new DateTime(2017, 5, 1),
            new DateTime(2017, 5, 6),
            new DateTime(2017, 5, 24),
            new DateTime(2017, 9, 6),
            new DateTime(2017, 9, 22),
            new DateTime(2017, 11, 1),
            new DateTime(2017, 12, 24),
            new DateTime(2017, 12, 25),
            new DateTime(2017, 12, 26)
        };

        var workingDaysCount = 0;

        for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
        {
            var isSaturdayOrSunday = (currentDate.DayOfWeek == DayOfWeek.Saturday) ||
                (currentDate.DayOfWeek == DayOfWeek.Sunday);
            var isHoliday = officialHolidays
                .Any(d => (d.Day == currentDate.Day) && (d.Month == currentDate.Month));

            if (!(isSaturdayOrSunday || isHoliday))
            {
                workingDaysCount++;
            }
        }

        Console.WriteLine(workingDaysCount);
    }
}