using System;

public class ExactSumOfRealNumbers
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var sum = 0M;

        for (int i = 0; i < n; i++)
        {
            sum += decimal.Parse(Console.ReadLine());
        }

        Console.WriteLine(sum);
    }
}