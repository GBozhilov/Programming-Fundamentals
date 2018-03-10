using System;
using System.Collections.Generic;
using System.Linq;

public class Palindromes
{
    public static void Main()
    {
        var words = Console.ReadLine()
            .Split(new char[] { ' ', ',', '.', '?', '!' })
            .Where(w => w != string.Empty)
            .ToArray();

        var uniquePalindromes = new SortedSet<string>();

        foreach (var word in words)
        {
            var isPalindrome = IsWordPalindrome(word);

            if (isPalindrome)
            {
                uniquePalindromes.Add(word);
            }
        }

        Console.WriteLine(string.Join(", ", uniquePalindromes));
    }

    public static bool IsWordPalindrome(string word)
    {
        var isPalindrome = true;

        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        return isPalindrome;
    }
}