using System;
using System.Text.RegularExpressions;

public class Regexmon
{
    public static void Main()
    {
        var text = Console.ReadLine();

        while (true)
        {
            var didiPattern = @"[^A-Z\-a-z]+";
            var didiMatch = Regex.Match(text, didiPattern);

            if (!didiMatch.Success)
            {
                break;
            }

            var matchIndex = didiMatch.Index;
            text = text.Substring(matchIndex + didiMatch.Length);

            Console.WriteLine(didiMatch.Value);

            var bojoPattern = @"[A-Za-z]+-[A-Za-z]+";
            var bojoMatch = Regex.Match(text, bojoPattern);

            if (!bojoMatch.Success)
            {
                break;
            }

            matchIndex = bojoMatch.Index;
            text = text.Substring(matchIndex + bojoMatch.Length);

            Console.WriteLine(bojoMatch.Value);
        }
    }
}