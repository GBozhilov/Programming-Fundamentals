using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class CameraView
{
    public static void Main()
    {
        var numbers = Regex
            .Split(Console.ReadLine(), @"\s+")
            .Select(int.Parse)
            .ToArray();
        var text = Console.ReadLine();

        var pattern = @"(?<=\|<)(\w+)";
        var matches = Regex.Matches(text, pattern);

        var skipCount = numbers.First();
        var takeCount = numbers.Last();

        var result = new List<string>();

        foreach (Match match in matches)
        {
            var str = new string(match.Value.Skip(skipCount).Take(takeCount).ToArray());
            result.Add(str);
        }

        Console.WriteLine(string.Join(", ", result));
    }
}