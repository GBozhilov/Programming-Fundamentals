using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class WordCount
{
    public static void Main()
    {
        File.WriteAllText("words.txt", "quick is fault");
        string[] words = File.ReadAllText("words.txt")
            .ToLower()
            .Split(' ');

        string[] text = File.ReadAllText("input.txt")
            .ToLower()
            .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' })
            .Where(x => x != "")
            .ToArray();

        var wordCount = new Dictionary<string, int>();

        foreach (var word in words)
        {
            wordCount[word] = 0;
        }

        foreach (var word in text)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
        }

        var wordsArr = wordCount
            .OrderByDescending(a => a.Value)
            .Select(a => a.Key + " - " + a.Value)
            .ToArray();

        File.WriteAllLines("output.txt", wordsArr);
    }
}