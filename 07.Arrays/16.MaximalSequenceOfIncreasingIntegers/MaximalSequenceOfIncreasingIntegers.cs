using System;

public class MaximalSequenceOfIncreasingIntegers
{
    public static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());

        int sames = 1, bestSames = 1, lastElement = 0, bestStart = 0;

        int[] array = new int[length];

        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Element[{0}] = ", index);
            array[index] = int.Parse(Console.ReadLine());
        }

        for (int index = 0; index < array.Length - 1; index++)
        {
            if (array[index] + 1 == array[index + 1])
            {
                sames++;
                if (sames > bestSames)
                {
                    bestSames = sames;
                    lastElement = index + 1;
                    bestStart = lastElement - bestSames + 1;
                }
            }
            else
                sames = 1;
        }

        for (int index = bestStart; index < bestStart + bestSames; index++)
            Console.Write("{0} ", array[index]);

        Console.WriteLine();
    }
}