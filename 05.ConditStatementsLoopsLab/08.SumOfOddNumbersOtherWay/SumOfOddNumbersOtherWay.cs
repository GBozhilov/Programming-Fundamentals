using System;

public class SumOfOddNumbersOtherWay
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var oddSum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{2 * i - 1}");
            oddSum += 2 * i - 1;
        }

        Console.WriteLine($"Sum: {oddSum}");
    }
}