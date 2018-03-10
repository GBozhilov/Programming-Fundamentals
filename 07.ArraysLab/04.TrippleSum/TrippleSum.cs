using System;

public class TrippleSum
{
    public static void Main()
    {
        string sequence = Console.ReadLine();

        string[] items = sequence.Split();

        int[] numbers = new int[items.Length];

        for (int i = 0; i < items.Length; i++)
            numbers[i] = int.Parse(items[i]);

        bool isFound = false;

        for (int i = 0; i < items.Length; i++)
        {
            int firstNum = numbers[i];

            for (int j = i + 1; j < items.Length; j++)
            {
                int secondNum = numbers[j];

                for (int k = 0; k < items.Length; k++)
                {
                    long sum = firstNum + secondNum;

                    if (sum == numbers[k])
                    {
                        Console.WriteLine($"{firstNum} + {secondNum} == {numbers[k]}");
                        isFound = true;
                        break;
                    }
                }
            }
        }

        if (!isFound)
            Console.WriteLine("No");
    }
}