using System;
using System.Text.RegularExpressions;

public class ReplaceTag
{
    public static void Main()
    {
        var text = Console.ReadLine();

        while (text != "end")
        {
            var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            var replacement = @"[URL href=$1]$2[/URL]";

            string replaced = Regex.Replace(text, pattern, replacement);

            Console.WriteLine(replaced);

            text = Console.ReadLine();
        }
    }
}