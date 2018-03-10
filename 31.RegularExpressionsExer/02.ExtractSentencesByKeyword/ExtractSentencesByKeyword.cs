using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class ExtractSentencesByKeyword
{
    public static void Main()
    {
        var keyWord = Console.ReadLine();
        var sentences = Regex.Split(Console.ReadLine(), @"[\!\?\.]");

        var result = new List<string>();

        foreach (var sentence in sentences)
        {
            var pattern = @"\W";
            var words = Regex.Split(sentence, pattern);

            if (words.Any(word => word == keyWord))
            {
                result.Add(sentence.Trim());
            }
        }

        Console.WriteLine(string.Join(Environment.NewLine, result));
    }
}