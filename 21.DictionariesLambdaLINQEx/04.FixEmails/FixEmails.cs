using System;
using System.Collections.Generic;

public class FixEmails
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
            var incorrectDomain = email.EndsWith("us") || email.EndsWith("uk");

            if (incorrectDomain)
            {
                continue;
            }

            namesEmails[name] = email;
        }

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