using System;
using System.Collections.Generic;
using System.Linq;

public class OddOccurrences
{
    public static void Main()
    {
        List<string> words = Console.ReadLine().ToLower().Split(' ').ToList();

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (!wordCount.ContainsKey(word))
                wordCount[word] = 0;

            wordCount[word]++;
        }

        List<string> result = new List<string>();

        foreach (KeyValuePair<string, int> pair in wordCount)
        {
            if (pair.Value % 2 != 0)
                result.Add(pair.Key);
        }

        Console.WriteLine(string.Join(", ", result));
    }
}