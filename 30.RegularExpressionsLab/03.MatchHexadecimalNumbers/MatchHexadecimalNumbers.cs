using System;
using System.Linq;
using System.Text.RegularExpressions;

public class MatchHexadecimalNumbers
{
    public static void Main()
    {
        var pattern = @"\b(?:0x)?[0-9A-F]+\b";

        var numberString = Console.ReadLine();

        var matches = Regex.Matches(numberString, pattern);

        var hexNums = matches
            .Cast<Match>()
            .Select(m => m.Value)
            .ToArray();

        Console.WriteLine(string.Join(" ", hexNums));
    }
}