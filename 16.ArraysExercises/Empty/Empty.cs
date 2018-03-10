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

        int sames = 1, bestSames = 1, start = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            var currentNum = numbers[i];
            var nextNum = numbers[i + 1];

            sames = currentNum < nextNum ? sames += 1 : sames = 1;

            if (sames > bestSames)
            {
                bestSames = sames;
                var indexOfLastElement = i + 1;
                start = indexOfLastElement - bestSames + 1;
            }
        }

        var end = start + bestSames;

        for (int i = start; i < end; i++)
        {
            Console.Write($"{numbers[i]} ");
        }

        Console.WriteLine();
    }
}