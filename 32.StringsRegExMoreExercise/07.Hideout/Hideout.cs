using System;
using System.Text.RegularExpressions;

public class Hideout
{
    public static void Main()
    {
        var map = Console.ReadLine();

        while (true)
        {
            var clues = Console.ReadLine()
                .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

            var searchedChar = clues[0];
            var minSearchLength = clues[1];

            var pattern = $@"\{searchedChar}{{{minSearchLength},}}";
            var match = Regex.Match(map, pattern);

            if (match.Success)
            {
                Console.WriteLine($"Hideout found at index {match.Index} and it is with size {match.Length}!");
                break;
            }
        }
    }
}