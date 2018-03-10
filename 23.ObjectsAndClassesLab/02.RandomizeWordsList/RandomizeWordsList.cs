using System;
using System.Collections.Generic;
using System.Linq;

public class RandomizeWordsList
{
    public static void Main()
    {
        List<string> words = Console.ReadLine()
            .Split(' ')
            .ToList();

        Random rndGen = new Random();
        int count = words.Count;

        for (int i = 0; i < count; i++)
        {
            int rndIndex = rndGen.Next(0, words.Count);
            string rndWord = words[rndIndex];
            words.RemoveAt(rndIndex);

            Console.WriteLine(rndWord);
        }
    }
}