using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Mines
{
    public static void Main()
    {
        var mineField = Console.ReadLine();

        var pattern = @"<(?<bombChars>..)>";
        var mines = Regex.Matches(mineField, pattern);

        foreach (Match mine in mines)
        {
            var bombChars = mine.Groups["bombChars"].Value;

            var firstChar = bombChars.First();
            var secondChar = bombChars.Last();

            var mineStrength = Math.Abs(firstChar - secondChar);

            var destructionPattern = $@".{{0,{mineStrength}}}{mine.Value}.{{0,{mineStrength}}}";
            var destructionMatch = Regex.Match(mineField, destructionPattern);
            var replacement = new string('_', destructionMatch.Length);

            mineField = Regex.Replace(mineField, destructionPattern, replacement);
        }

        Console.WriteLine(mineField);
    }
}