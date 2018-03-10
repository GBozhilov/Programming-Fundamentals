using System;
using System.Linq;

public class MaxSequenceOfEqualElements
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int start = 0, bestStart = 0, length = 1, bestLength = 1;

        for (int pos = 1; pos < numbers.Length; pos++)
        {
            var currentNum = numbers[pos];
            var previousNum = numbers[pos - 1];

            if (currentNum.Equals(previousNum))
            {
                length++;
            }
            else
            {
                length = 1;
                start = pos;
            }

            if (length > bestLength)
            {
                bestLength = length;
                bestStart = start;
            }
        }

        for (int i = bestStart; i < bestStart + bestLength; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine();
    }
}