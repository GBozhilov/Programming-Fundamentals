using System;
using System.Linq;
using System.Text.RegularExpressions;

public class MatchPhoneNumber
{
    public static void Main()
    {
        var phones = Console.ReadLine();

        var pattern = @"\+359(\s|-)2\1\d{3}\1\d{4}\b";

        var phoneMatches = Regex.Matches(phones, pattern);

        var matchedPhones = phoneMatches
            .Cast<Match>()
            .Select(a => a.Value.Trim())
            .ToArray();

        Console.WriteLine(string.Join(", ", matchedPhones));
    }
}