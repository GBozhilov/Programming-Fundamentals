using System;
using System.Linq;

public class MostFrequentNumber
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int maxCount = 0, mostFrequent = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                    count++;
            }

            if (count > maxCount)
            {
                maxCount = count;
                mostFrequent = numbers[i];
            }

        }

        Console.WriteLine(mostFrequent);
    }
}