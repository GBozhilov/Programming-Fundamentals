using System;
using System.Linq;

public class MostFrequentNumber
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int maxCounter = 0, mostFrequent = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int counter = 0;

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                    counter++;
            }

            if (counter > maxCounter)
            {
                maxCounter = counter;
                mostFrequent = numbers[i];
            }
        }

        Console.WriteLine(mostFrequent);
    }
}