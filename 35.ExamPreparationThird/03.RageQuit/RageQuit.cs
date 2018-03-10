using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class RageQuit
{
    public static void Main()
    {
        var inputText = Console.ReadLine();

        var pattern = @"(?<text>.*?)(?<count>\d+)";
        //var pattern = @"(?<text>[^0-9]+)(?<count>\d+)";
        var matches = Regex.Matches(inputText, pattern);

        var result = new StringBuilder();

        foreach (Match match in matches)
        {
            var text = match.Groups["text"].Value.ToUpper();
            var count = int.Parse(match.Groups["count"].Value);

            for (int i = 0; i < count; i++)
            {
                result.Append(text);
            }
        }

        var uniqueSymbols = new HashSet<char>(result.ToString());

        Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
        Console.WriteLine(result);
    }
}