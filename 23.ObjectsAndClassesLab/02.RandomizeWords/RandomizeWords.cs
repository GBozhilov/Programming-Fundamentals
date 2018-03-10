using System;

public class RandomizeWords
{
    public static void Main()
    {
        string[] words = Console.ReadLine().Split(' ');

        Random randGen = new Random();

        for (int i = 0; i < words.Length; i++)
        {
            int randomPos = randGen.Next(0, words.Length);

            string currentWord = words[i];
            words[i] = words[randomPos];
            words[randomPos] = currentWord;
        }

        Console.WriteLine(string.Join(Environment.NewLine, words));
    }
}