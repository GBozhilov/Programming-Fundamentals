using System;
using System.Linq;

public class CondenseArrayToNumber
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var count = numbers.Length - 1;

        while (count > 0)
        {
            for (int i = 0; i < count; i++)
            {
                numbers[i] += numbers[i + 1];
            }

            count--;
        }

        Console.WriteLine(numbers[0]);
    }
}