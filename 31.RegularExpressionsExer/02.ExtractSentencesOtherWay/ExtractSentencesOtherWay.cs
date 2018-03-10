using System;
using System.Text.RegularExpressions;

public class ExtractSentencesByKeyword
{
    public static void Main()
    {
        var keyWord = Console.ReadLine();
        var sentences = Regex.Split(Console.ReadLine(), @"[\!\?\.]");

        foreach (var sentence in sentences)
        {
            var pattern = $@"\b{keyWord}\b";

            var match = Regex.Match(sentence, pattern);

            if (match.Success)
            {
                Console.WriteLine(sentence.Trim());
            }
        }
    }
}