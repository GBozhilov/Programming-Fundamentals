using System;
using System.Linq;

public class ArrayStatistics
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var minNum = FindMinNumber(numbers);
        var maxNum = FindMaxNumber(numbers);
        var sum = CalculateSum(numbers);
        var average = (double)sum / numbers.Length;

        Console.WriteLine($"Min = {minNum}");
        Console.WriteLine($"Max = {maxNum}");
        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Average = {average}");
    }

    public static long CalculateSum(int[] numbers)
    {
        long sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            var currentNum = numbers[i];
            sum += currentNum;
        }

        return sum;
    }

    public static int FindMinNumber(int[] numbers)
    {
        var minNum = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            var currentNum = numbers[i];

            if (currentNum < minNum)
            {
                minNum = currentNum;
            }
        }

        return minNum;
    }

    public static int FindMaxNumber(int[] numbers)
    {
        var maxNum = int.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            var currentNum = numbers[i];

            if (currentNum > maxNum)
            {
                maxNum = currentNum;
            }
        }

        return maxNum;
    }
}