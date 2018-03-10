using System;

public class IndexOfLetters
{
    public static void Main()
    {
        var text = Console.ReadLine();

        var alphabet = new char[26];

        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)(97 + i);
        }

        for (int i = 0; i < text.Length; i++)
        {
            var currentLetter = text[i];
            var index = Array.IndexOf(alphabet, currentLetter);

            Console.WriteLine($"{currentLetter} -> {index}");
        }
    }
}