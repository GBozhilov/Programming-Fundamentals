using System;
using System.Collections.Generic;
using System.Linq;

public class CountRealNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToArray();

        var counts = new SortedDictionary<double, int>();

        foreach (var num in numbers)
        {
            if (!counts.ContainsKey(num))
            {
                counts[num] = 0;
            }

            counts[num]++;
        }

        foreach (var KVP in counts)
        {
            var number = KVP.Key;
            var occurrences = KVP.Value;

            Console.WriteLine($"{number} -> {occurrences}");
        }
    }
}