using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Hideout
{
    public static void Main()
    {
        var map = Console.ReadLine();

        while (true)
        {
            var clues = Console.ReadLine().Split(' ');

            var searchedChar = clues.First();
            var minSearchLength = clues.Last();

            var pattern = $@"\{searchedChar}{{{minSearchLength},}}";

            var regex = new Regex(pattern);
            var match = regex.Match(map);

            if (match.Success)
            {
                Console.WriteLine($"Hideout found at index {match.Index} and it is with size {match.Length}!");
                break;
            }
        }
    }
}