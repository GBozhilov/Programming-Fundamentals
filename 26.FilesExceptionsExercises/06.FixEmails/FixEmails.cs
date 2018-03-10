using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class FixEmailsLINQ
{
    public static void Main()
    {
        var namesEmails = new Dictionary<string, string>();

        File.Delete("output.txt");

        var lines = File.ReadAllLines("input.txt");

        for (int i = 0; i < lines.Length; i += 2)
        {
            var inputLine = lines[i];

            while (!inputLine.Equals("stop"))
            {
                var name = inputLine;
                var email = lines[i + 1];

                namesEmails[name] = email;

                break;
            }
        }

        var fixedEmails = namesEmails
            .Where(kvp => !kvp.Value.EndsWith("us") && !kvp.Value.EndsWith("uk"))
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

        PrintDict(fixedEmails);
    }

    public static void PrintDict(Dictionary<string, string> namesEmails)
    {
        foreach (var nameEmailPair in namesEmails)
        {
            var name = nameEmailPair.Key;
            var email = nameEmailPair.Value;

            Console.WriteLine($"{name} -> {email}");
            File.AppendAllText("output.txt", $"{name} -> {email}");
            File.AppendAllText("output.txt", Environment.NewLine);
        }
    }
}