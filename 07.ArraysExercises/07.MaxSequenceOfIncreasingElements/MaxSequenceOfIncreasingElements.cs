using System;
using System.Linq;

public class MaxSequenceOfIncreasingElements
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int sames = 1, bestSames = 1, lastElement = 0, bestStart = 0;

        for (int index = 0; index < numbers.Length - 1; index++)
        {
            int currentNum = numbers[index];
            int nextNum = numbers[index + 1];

            sames = currentNum < nextNum ? sames += 1 : sames = 1;

            if (sames > bestSames)
            {
                bestSames = sames;
                lastElement = index + 1;
                bestStart = lastElement - bestSames + 1;
            }
        }

        for (int i = bestStart; i < bestStart + bestSames; i++)
        {
            Console.Write($"{numbers[i]} ");
        }
    }
}