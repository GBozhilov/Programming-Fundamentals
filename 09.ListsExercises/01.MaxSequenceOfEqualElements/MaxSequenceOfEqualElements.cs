using System;

public class MaxSequenceOfEqualElements
{
    public static void Main()
    {
        string[] sequence = Console.ReadLine().Split(' ');

        int[] numbers = new int[sequence.Length];

        for (int i = 0; i < sequence.Length; i++)
            numbers[i] = int.Parse(sequence[i]);

        int count = 1, tempCount = 1, number = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
                tempCount++;
            else
                tempCount = 1;

            if (tempCount > count)
            {
                count = tempCount;
                number = numbers[i];
            }
        }

        if (count != 1)
        {
            for (int i = 0; i < count; i++)
                Console.Write($"{number} ");
        }
        else
            Console.Write(numbers[0]);

        Console.WriteLine();
    }
}