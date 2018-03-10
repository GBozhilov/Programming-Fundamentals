using System;

public class Censorship
{
    public static void Main()
    {
        var word = Console.ReadLine();
        var sentence = Console.ReadLine();

        while (sentence.Contains(word))
        {
            sentence = sentence.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(sentence);
    }
}