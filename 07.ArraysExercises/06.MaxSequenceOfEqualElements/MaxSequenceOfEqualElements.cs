using System;
using System.Linq;

public class MaxSequenceOfEqualElements
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int bestNum = 0, length = 1, bestLength = 1;

        for (int pos = 0; pos < numbers.Length - 1; pos++)
        {
            int currentNum = numbers[pos];
            int nextNum = numbers[pos + 1];

            if (currentNum.Equals(nextNum))
            {
                length++;
            }
            else
            {
                length = 1;
            }

            if (length > bestLength)
            {
                bestLength = length;
                bestNum = currentNum;
            }
        }

        for (int i = 0; i < bestLength; i++)
        {
            Console.Write($"{bestNum} ");
        }

        Console.WriteLine();
    }
}