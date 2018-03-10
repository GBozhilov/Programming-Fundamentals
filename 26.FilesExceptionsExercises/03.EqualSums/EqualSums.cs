using System;
using System.IO;
using System.Linq;

public class EqualSums
{
    public static void Main()
    {
        File.Delete("output.txt");

        var lines = File.ReadAllLines("input.txt");

        foreach (var line in lines)
        {
            var numbers = line
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNum = numbers[i];

                var leftSum = CalculateLeftSum(numbers, i);
                var rightSum = CalculateRightSum(numbers, i);

                if (leftSum.Equals(rightSum))
                {
                    isFound = true;
                    File.AppendAllText("output.txt", i.ToString() + Environment.NewLine);
                    break; ;
                }
            }

            File.AppendAllText("output.txt", !isFound ? "no" + Environment.NewLine : string.Empty);
            File.AppendAllText("output.txt", Environment.NewLine);
        }
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