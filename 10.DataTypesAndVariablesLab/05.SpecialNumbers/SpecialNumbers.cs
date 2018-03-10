using System;

public class SpecialNumbers
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        for (int currentNum = 1; currentNum <= n; currentNum++)
        {
            var sumOfDigits = GetSumOfDigits(currentNum);

            var isSpecialNum = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

            Console.WriteLine($"{currentNum} -> {isSpecialNum}");
        }
    }

    public static int GetSumOfDigits(int currentNum)
    {
        var sum = 0;

        while (currentNum > 0)
        {
            sum += currentNum % 10;
            currentNum /= 10;
        }

        return sum;
    }
}