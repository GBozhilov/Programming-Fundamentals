using System;
using System.Linq;

public class EqualSums
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            var currentNum = numbers[i];

            var leftSum = CalculateLeftSum(numbers, i);
            var rightSum = CalculateRightSum(numbers, i);

            if (leftSum.Equals(rightSum))
            {
                Console.WriteLine(i);
                return;
            }
        }

        Console.WriteLine("no");
    }

    public static int CalculateRightSum(int[] numbers, int i)
    {
        var rightSum = 0;

        for (int j = i + 1; j < numbers.Length; j++)
        {
            rightSum += numbers[j];
        }

        return rightSum;
    }

    public static int CalculateLeftSum(int[] numbers, int i)
    {
        var leftSum = 0;

        for (int j = 0; j < i; j++)
        {
            leftSum += numbers[j];
        }

        return leftSum;
    }
}