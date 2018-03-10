using System;

public class EqualSums
{
    public static void Main()
    {
        string[] array = Console.ReadLine()
            .Split(' ');

        int[] numbers = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
            numbers[i] = int.Parse(array[i]);

        for (int i = 0; i < array.Length; i++)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int j = 0; j < i; j++)
                leftSum += numbers[j];

            for (int j = i + 1; j < array.Length; j++)
                rightSum += numbers[j];

            if (leftSum == rightSum)
            {
                Console.WriteLine($"{i}");
                return;
            }
        }

        Console.WriteLine("no");
    }
}