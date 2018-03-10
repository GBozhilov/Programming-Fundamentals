using System;
using System.Collections.Generic;
using System.Linq;

public class PhonebookUpgradeOtherWay
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var phonebook = new Dictionary<string, string>();

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
                SortAndPrintPhonebook(phonebook);

            inputLine = Console.ReadLine();
        }
    }

    static void SortAndPrintPhonebook(Dictionary<string, string> phonebook)
    {
        phonebook = phonebook
            .OrderBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var namePhone in phonebook)
        {
            var name = namePhone.Key;
            var phone = namePhone.Value;

            Console.WriteLine($"{name} -> {phone}");
        }
    }
}