using System;
using System.Text.RegularExpressions;

public class ExtractEmails
{
    public static void Main()
    {
        var pattern = @"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]+([-.]\w*)*(\.[a-z]+)";

        var inputText = Console.ReadLine();

        var matches = Regex.Matches(inputText, pattern);

        foreach (Match email in matches)
        {
            Console.WriteLine(email);
        }
    }
}