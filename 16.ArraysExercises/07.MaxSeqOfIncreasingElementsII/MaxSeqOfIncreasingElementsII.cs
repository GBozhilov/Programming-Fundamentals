using System;
using System.Linq;

public class MaxSequenceOfIncreasingElements
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int sames = 1, bestSames = 1, bestStart = 0, lastElement = 0;

        for (int pos = 0; pos < numbers.Length - 1; pos++)
        {
            var currentNum = numbers[pos];
            var nextNum = numbers[pos + 1];

            sames = currentNum < nextNum ? sames += 1 : sames = 1;

            if (sames > bestSames)
            {
                bestSames = sames;
                lastElement = pos + 1;
                bestStart = lastElement - bestSames + 1;
            }
        }

        for (int i = bestStart; i < bestStart + bestSames; i++)
        {
            Console.Write($"{numbers[i]} ");
        }

        Console.WriteLine();
    }
}