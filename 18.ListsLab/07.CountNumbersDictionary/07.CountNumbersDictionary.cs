using System;
using System.Collections.Generic;
using System.Linq;

public class CountNumbersDictionary
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        var numberOccurrences = new SortedDictionary<int, int>();

        foreach (var number in numbers)
        {
            if (!numberOccurrences.ContainsKey(number))
            {
                numberOccurrences[number] = 0;
            }

            numberOccurrences[number]++;
        }

        foreach (var KVP in numberOccurrences)
        {
            var number = KVP.Key;
            var occurrences = KVP.Value;

            Console.WriteLine($"{number} -> {occurrences}");
        }
    }
}