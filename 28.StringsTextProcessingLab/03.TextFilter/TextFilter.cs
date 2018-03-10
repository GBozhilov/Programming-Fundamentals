using System;
using System.Linq;

public class TextFilter
{
    public static void Main()
    {
        var bannedWords = Console.ReadLine()
            .Split(',', ' ')
            .Where(w => w != string.Empty)
            .ToArray();
        var text = Console.ReadLine();

        foreach (var word in bannedWords)
        {
            if (text.Contains(word))
            {
                text = text.Replace(word, new string('*', word.Length));
            }
        }

        Console.WriteLine(text);
    }
}