using System;

public class SumOfOddNumbers
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var oddSum = 0;

        for (int i = 1; i <= 2 * n; i += 2)
        {
            oddSum += i;
            Console.WriteLine(i);
        }

        Console.WriteLine($"Sum: {oddSum}");
    }
}