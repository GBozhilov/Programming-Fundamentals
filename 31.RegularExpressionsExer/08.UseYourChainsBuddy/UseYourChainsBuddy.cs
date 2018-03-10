using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class UseYourChainsBuddy
{
    public static void Main()
    {
        var paragraphRegex = new Regex(@"<p>(?<message>.+?)<\/p>");

        var text = Console.ReadLine();

        var paragraphs = paragraphRegex.Matches(text)
            .Cast<Match>()
            .Select(a => a.Groups["message"].Value)
            .Select(a => Regex.Replace(a, @"[^a-z\d]", " "))
            .Select(a => Regex.Replace(a, @"\s+", " "))
            .ToArray();

        for (int i = 0; i < paragraphs.Length; i++)
        {
            paragraphs[i] = RotThirteenString(paragraphs[i]);
        }

        var result = new StringBuilder();

        foreach (var paragraph in paragraphs)
        {
            result.Append(paragraph);
        }

        Console.WriteLine(result.ToString());
    }

    public static string RotThirteenString(string input)
    {
        var result = new StringBuilder();

        foreach (var symbol in input)
        {
            result.Append(RotThirteenChar(symbol));
        }

        return result.ToString();
    }

    public static char RotThirteenChar(char symbol)
    {
        if (!char.IsLetter(symbol))
        {
            return symbol;
        }

        var offset = char.IsUpper(symbol) ? 'A' : 'a';
        var rotatedLetter = (char)((symbol - offset + 13) % 26 + offset);

        return rotatedLetter;
    }
}