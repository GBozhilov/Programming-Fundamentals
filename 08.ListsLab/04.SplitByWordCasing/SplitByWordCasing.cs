using System;
using System.Collections.Generic;
using System.Linq;

public class SplitByWordCasing
{
    public static void Main()
    {
        char[] separators =
            { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };

        List<string> words = Console.ReadLine().Split(separators,
            StringSplitOptions.RemoveEmptyEntries).ToList();

        List<string> lowerCaseWords = new List<string>();
        List<string> mixedCaseWords = new List<string>();
        List<string> upperCaseWords = new List<string>();

        foreach (string word in words)
        {
            int lowerCaseCount = 0;
            int upperCaseCount = 0;

            foreach (var letter in word)
            {
                if (char.IsLower(letter))
                    lowerCaseCount++;
                else if (char.IsUpper(letter))
                    upperCaseCount++;
            }

            if (lowerCaseCount == word.Length)
                lowerCaseWords.Add(word);
            else if (upperCaseCount == word.Length)
                upperCaseWords.Add(word);
            else
                mixedCaseWords.Add(word);
        }

        Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
        Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
        Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
    }
}