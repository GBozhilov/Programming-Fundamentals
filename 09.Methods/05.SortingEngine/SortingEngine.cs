using System;

public class SortingEngine
{
    static int[] Sort(params int[] numbers)
    {
        // The sorting logic
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            // Loop that is operating over the un-sorted part of the array
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[i])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        } // End of sorting logic
        return numbers;
    }

    static void PrintNumbers(params int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0}", numbers[i]);
            if (i < numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        int[] numbers = Sort(10, 3, 5, -1, 0, 12, 8);
        PrintNumbers(numbers);
    }
}