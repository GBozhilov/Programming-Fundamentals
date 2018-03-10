using System;

public class CondenseArrayToNumber
{
    public static void Main()
    {
        string sequence = Console.ReadLine();

        string[] items = sequence.Split();
        int[] numbers = new int[items.Length];

        for (int i = 0; i < items.Length; i++)
            numbers[i] = int.Parse(items[i]);

        int len = numbers.Length;

        do
        {
            for (int i = 0; i < len - 1; i++)
                numbers[i] = numbers[i] + numbers[i + 1];

            len--;
        } while (len > 1);

        Console.WriteLine(numbers[0]);
    }
}