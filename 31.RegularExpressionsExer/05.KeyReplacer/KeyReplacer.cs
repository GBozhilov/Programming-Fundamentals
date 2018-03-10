using System;
using System.Text;
using System.Text.RegularExpressions;

public class KeyReplacer
{
    public static void Main()
    {
        var keyString = Console.ReadLine();
        var text = Console.ReadLine();

        var keyPattern = @"(?<startKey>[A-Za-z]+)[\|<\\].*[\|<\\](?<endKey>[A-Za-z]+)";
        var keyMatch = Regex.Match(keyString, keyPattern);

        var startKey = keyMatch.Groups["startKey"].Value;
        var endKey = keyMatch.Groups["endKey"].Value;

        var textPattern = $@"{startKey}(?<item>.*?){endKey}";
        var matches = Regex.Matches(text, textPattern);

        var result = new StringBuilder();

        foreach (Match match in matches)
        {
            var item = match.Groups["item"].Value;

            result.Append(item);
        }

        Console.WriteLine(result.Length != 0 ? result.ToString() : "Empty result");
    }
}