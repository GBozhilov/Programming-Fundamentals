using System;
using System.Collections.Generic;

public class SplitByWordCasing
{
    public static void Main()
    {
        var separators = new char[]
            { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };

        var words = Console.ReadLine().Split(separators,
            StringSplitOptions.RemoveEmptyEntries);

        var lowercaseWords = new List<string>();
        var mixedcaseWords = new List<string>();
        var uppercaseWords = new List<string>();

        foreach (var word in words)
        {
            var lowercaseLetters = 0;
            var uppercaseLetters = 0;

            foreach (var symbol in word)
            {
                if (char.IsLower(symbol))
                {
                    lowercaseLetters++;
                }
                else if (char.IsUpper(symbol))
                {
                    uppercaseLetters++;
                }
            }

            if (lowercaseLetters.Equals(word.Length))
            {
                lowercaseWords.Add(word);
            }
            else if (uppercaseLetters.Equals(word.Length))
            {
                uppercaseWords.Add(word);
            }
            else
            {
                mixedcaseWords.Add(word);
            }
        }

        Console.WriteLine($"Lower-case: {string.Join(", ", lowercaseWords)}");
        Console.WriteLine($"Mixed-case: {string.Join(", ", mixedcaseWords)}");
        Console.WriteLine($"Upper-case: {string.Join(", ", uppercaseWords)}");
    }
}