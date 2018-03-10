using System;
using System.Linq;
using System.Text.RegularExpressions;

public class MatchNumbers
{
    public static void Main()
    {
        var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

        var inputLine = Console.ReadLine();

        var matches = Regex.Matches(inputLine, pattern);

        var numbers = matches
            .Cast<Match>()
            .Select(a => a.Value)
            .Select(double.Parse)
            .ToArray();

        Console.WriteLine(string.Join(" ", numbers));
    }
}