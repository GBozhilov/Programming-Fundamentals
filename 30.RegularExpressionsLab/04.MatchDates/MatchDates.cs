using System;
using System.Text.RegularExpressions;

public class MatchDates
{
    public static void Main()
    {
        var pattern = @"\b(?<day>\d{2})(?<separator>[\/|\-|\.])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";

        var inputLine = Console.ReadLine();

        var matchedDates = Regex.Matches(inputLine, pattern);

        foreach (Match date in matchedDates)
        {
            var day = date.Groups["day"];
            var month = date.Groups["month"];
            var year = date.Groups["year"];

            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
        }
    }
}