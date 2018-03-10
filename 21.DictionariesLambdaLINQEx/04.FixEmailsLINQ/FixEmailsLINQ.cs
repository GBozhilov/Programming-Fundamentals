using System;
using System.Collections.Generic;
using System.Linq;

public class FixEmailsLINQ
{
    public static void Main()
    {
        var namesEmails = new Dictionary<string, string>();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine.Equals("stop"))
            {
                break;
            }

            var name = inputLine;
            var email = Console.ReadLine();

            namesEmails[name] = email;
        }

        var fixedEmails = namesEmails
            .Where(kvp => !(kvp.Value.EndsWith("us") || kvp.Value.EndsWith("uk")))
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

        PrintDict(namesEmails);
    }

    public static void PrintDict(Dictionary<string, string> namesEmails)
    {
        foreach (var nameEmailPair in namesEmails)
        {
            var name = nameEmailPair.Key;
            var email = nameEmailPair.Value;

            Console.WriteLine($"{name} -> {email}");
        }
    }
}