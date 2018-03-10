using System;
using System.Collections.Generic;

public class PhonebookUpgrade
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var phonebook = new SortedDictionary<string, string>();

        while (inputLine != "END")
        {
            var tokens = inputLine.Split(' ');
            var command = tokens[0];

            if (command == "A")
            {
                var number = tokens[2];
                var name = tokens[1];

                phonebook[name] = number;
            }
            else if (command == "S")
            {
                var name = tokens[1];
                var containsName = phonebook.ContainsKey(name);

                Console.WriteLine(containsName ? $"{name} -> {phonebook[name]}" :
                    $"Contact {name} does not exist.");
            }
            else // command == "ListAll"
                PrintPhonebook(phonebook);

            inputLine = Console.ReadLine();
        }
    }

    static void PrintPhonebook(SortedDictionary<string, string> phonebook)
    {
        foreach (var namePhone in phonebook)
        {
            var name = namePhone.Key;
            var phone = namePhone.Value;

            Console.WriteLine($"{name} -> {phone}");
        }
    }
}