using System;
using System.Collections.Generic;

public class Phonebook
{
    public static void Main()
    {
        var phonebook = new Dictionary<string, string>();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine.Equals("END"))
            {
                return;
            }

            var tokens = inputLine.Split(' ');
            var command = tokens[0];
            var name = tokens[1];

            if (command.Equals("A"))
            {
                var phone = tokens[2];

                phonebook[name] = phone;
            }
            else if (command.Equals("S"))
            {
                if (!phonebook.ContainsKey(name))
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                    continue;
                }

                Console.WriteLine($"{name} -> {phonebook[name]}");
            }
        }
    }
}