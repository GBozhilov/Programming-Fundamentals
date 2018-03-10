using System;
using System.Linq;

public class SafeManipulation
{
    public static void Main()
    {
        var array = Console.ReadLine().Split(' ');

        while (true)
        {
            var tokens = Console.ReadLine()
                .Split(' ');

            var command = tokens[0];

            if (command.Equals("END"))
            {
                break;
            }

            switch (command)
            {
                case "Reverse":
                    Array.Reverse(array);
                    break;
                case "Distinct":
                    array = array
                        .Distinct()
                        .ToArray();
                    break;
                case "Replace":
                    ReplaceElement(array, tokens);
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }

        Console.WriteLine(string.Join(", ", array));
    }

    public static void ReplaceElement(string[] array, string[] tokens)
    {
        var changeIndex = int.Parse(tokens[1]);
        var newElement = tokens[2];

        if (changeIndex < 0 || changeIndex >= array.Length)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        array[changeIndex] = newElement;
    }
}