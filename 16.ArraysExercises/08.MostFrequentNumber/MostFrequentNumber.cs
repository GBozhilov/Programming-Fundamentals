using System;
using System.Linq;

public class MostFrequentNumber
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var bestCount = 0;
        var mostFrequent = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            var count = 0;
            var currentNum = numbers[i];

            for (int j = 0; j < numbers.Length; j++)
            {
                var checkedNumber = numbers[j];

                if (currentNum == checkedNumber)
                {
                    count++;
                }
            }

            if (count > bestCount)
            {
                bestCount = count;
                mostFrequent = currentNum;
            }
        }

        Console.WriteLine(mostFrequent);
    }
}