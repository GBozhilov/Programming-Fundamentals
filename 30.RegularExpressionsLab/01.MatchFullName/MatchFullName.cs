using System;
using System.Text.RegularExpressions;

public class MatchFullName
{
    public static void Main()
    {
        var names = Console.ReadLine();

        var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

        var matchedNames = Regex.Matches(names, pattern);

        foreach (Match name in matchedNames)
        {
            Console.Write(name.Value + " ");
        }

        Console.WriteLine();
    }
}