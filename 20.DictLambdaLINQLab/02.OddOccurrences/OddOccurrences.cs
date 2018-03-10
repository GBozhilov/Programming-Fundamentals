using System;
using System.Collections.Generic;

public class OddOccurrences
{
    public static void Main()
    {
        var words = Console.ReadLine()
            .ToLower()
            .Split(' ');

        var counts = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (!counts.ContainsKey(word))
            {
                counts[word] = 0;
            }

            counts[word]++;
        }

        var oddOccurrences = new List<string>();

        foreach (var pair in counts)
        {
            var word = pair.Key;
            var occurrences = pair.Value;

            if (occurrences % 2 != 0)
            {
                oddOccurrences.Add(word);
            }
        }

        Console.WriteLine(string.Join(", ", oddOccurrences));
    }
}