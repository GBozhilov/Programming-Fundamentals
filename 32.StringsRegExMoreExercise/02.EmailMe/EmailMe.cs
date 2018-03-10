using System;
using System.Linq;
using System.Text.RegularExpressions;

public class EmailMe
{
    public static void Main()
    {
        var email = Console.ReadLine();

        var pattern = @"(?<left>.*)@(?<right>.*)";

        var match = Regex.Match(email, pattern);

        var leftSum = match.Groups["left"]
            .ToString()
            .ToCharArray()
            .Select(a => (int)a)
            .Sum();
        var rightSum = match.Groups["right"]
            .ToString()
            .ToCharArray()
            .Select(a => (int)a)
            .Sum();

        var difference = leftSum - rightSum;

        Console.WriteLine(difference >= 0 ? "Call her!" : "She is not the one.");
    }
}