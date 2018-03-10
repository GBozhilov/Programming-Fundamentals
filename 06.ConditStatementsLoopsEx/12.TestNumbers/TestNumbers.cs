using System;

public class TestNumbers
{
    public static void Main()
    {
        var firstNum = int.Parse(Console.ReadLine());
        var secondNum = int.Parse(Console.ReadLine());
        var maxSum = int.Parse(Console.ReadLine());

        var sum = 0;
        var combinationsCount = 0;

        for (int a = firstNum; a >= 1; a--)
        {
            for (int b = 1; b <= secondNum; b++)
            {
                sum += 3 * a * b;
                combinationsCount++;

                if (sum >= maxSum)
                {
                    Console.WriteLine($"{combinationsCount} combinations");
                    Console.WriteLine($"Sum: {sum} >= {maxSum}");

                    return;
                }
            }
        }

        Console.WriteLine($"{combinationsCount} combinations");
        Console.WriteLine($"Sum: {sum}");
    }
}