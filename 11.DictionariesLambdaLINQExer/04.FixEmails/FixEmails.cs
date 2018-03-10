using System;
using System.Collections.Generic;
using System.Linq;

public class FixEmails
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var namesEmails = new Dictionary<string, string>();

        while (inputLine != "stop")
        {
            var name = inputLine;
            var email = Console.ReadLine();

            var domain = email.ToLower().Split('.').Last();
            var correctDomain = (domain != "us") && (domain != "uk");

            if (correctDomain)
                namesEmails[name] = email;

            inputLine = Console.ReadLine();
        }

        PrintResult(namesEmails);
    }

    static void PrintResult(Dictionary<string, string> namesEmails)
    {
        foreach (var KVP in namesEmails)
        {
            var name = KVP.Key;
            var email = KVP.Value;

            Console.WriteLine($"{name} -> {email}");
        }
    }
}