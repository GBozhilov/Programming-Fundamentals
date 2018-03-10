using System;
using System.Text.RegularExpressions;

public class OnlyLetters
{
    public static void Main()
    {
        var input = Console.ReadLine();

        var pattern = @"(?<number>\d+)(?<symbol>.)";

        var matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            var replacement = match.Groups["symbol"].Value;
            var startIndex = input.IndexOf(match.Value);

            input = input.Remove(startIndex, match.Value.Length - 1);
            input = input.Insert(startIndex, replacement);
        }

        Console.WriteLine(input);
    }
}