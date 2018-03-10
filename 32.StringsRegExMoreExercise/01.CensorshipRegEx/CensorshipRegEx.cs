using System;
using System.Text.RegularExpressions;

public class CensorshipRegEx
{
    public static void Main()
    {
        var word = Console.ReadLine();
        var sentence = Console.ReadLine();

        var pattern = Regex.Escape($@"{word}");
        var replacement = new string('*', word.Length);
        var result = Regex.Replace(sentence, pattern, replacement);

        Console.WriteLine(result);
    }
}