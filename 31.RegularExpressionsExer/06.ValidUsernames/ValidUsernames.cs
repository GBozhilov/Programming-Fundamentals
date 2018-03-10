using System;
using System.Linq;
using System.Text.RegularExpressions;

public class ValidUsernames
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var pattern = @"\b[A-Za-z]\w{2,24}\b";

        var validUsernames = Regex.Matches(inputLine, pattern)
            .Cast<Match>()
            .Select(a => a.Value)
            .ToArray();

        var bestSumOfLengths = int.MinValue;
        var bestCurrentIndex = 0;
        var bestNextIndex = 0;

        for (int i = 0; i < validUsernames.Length - 1; i++)
        {
            var currentUsername = validUsernames[i];
            var nextUsername = validUsernames[i + 1];

            var currentLength = currentUsername.Length;
            var nextLength = nextUsername.Length;
            var sumOfLengths = currentLength + nextLength;

            if (sumOfLengths > bestSumOfLengths)
            {
                bestSumOfLengths = sumOfLengths;
                bestCurrentIndex = i;
                bestNextIndex = i + 1;
            }
        }

        Console.WriteLine(validUsernames[bestCurrentIndex]);
        Console.WriteLine(validUsernames[bestNextIndex]);
    }
}