using System;
using System.Collections.Generic;

public class Phonebook
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var phonebook = new Dictionary<string, string>();

        while (inputLine != "END")
        {
            var tokens = inputLine.Split(' ');
            var command = tokens[0];
            var name = tokens[1];

            if (command == "A")
            {
                var number = tokens[2];

                phonebook[name] = number;
            }
            else // command == "S"
            {
                var containsName = phonebook.ContainsKey(name);

                Console.WriteLine(containsName ? $"{name} -> {phonebook[name]}" :
                    $"Contact {name} does not exist.");
            }

            inputLine = Console.ReadLine();
        }
    }
}