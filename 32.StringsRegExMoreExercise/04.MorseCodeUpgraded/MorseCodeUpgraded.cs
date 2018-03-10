using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class MorseCodeUpgraded
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var result = new StringBuilder();

        var messageParts = inputLine
            .Split('|');

        foreach (var part in messageParts)
        {
            var zeroesCount = part
                .Where(a => a == '0')
                .Count();
            var onesCount = part
                .Where(a => a == '1')
                .Count();

            var sum = zeroesCount * 3 + onesCount * 5;

            var pattern = @"11+|00+";
            var matches = Regex.Matches(part, pattern);

            sum += matches
                .Cast<Match>()
                .Sum(a => a.Length);

            result.Append((char)sum);
        }

        Console.WriteLine(result);
    }
}