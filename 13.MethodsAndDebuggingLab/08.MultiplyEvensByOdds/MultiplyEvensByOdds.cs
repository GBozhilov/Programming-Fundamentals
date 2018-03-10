using System;

public class MultiplyEvensByOdds
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        var product = GetMultipleOfEvensAndOdds(Math.Abs(number));

        Console.WriteLine(product);
    }
    public static int GetMultipleOfEvensAndOdds(int number)
    {
        int evenSum = GetSumOfEvenDigits(number);
        int oddSum = GetSumOfOddDigits(number);

        return evenSum * oddSum;
    }

    public static int GetSumOfOddDigits(int number)
    {
        int oddSum = 0;

        while (number > 0)
        {
            var lastDigit = number % 10;

            if (lastDigit % 2 != 0)
            {
                oddSum += lastDigit;
            }

            number /= 10;
        }

        return oddSum;
    }

    public static int GetSumOfEvenDigits(int number)
    {
        int evenSum = 0;

        while (number > 0)
        {
            var lastDigit = number % 10;

            if (lastDigit % 2 == 0)
            {
                evenSum += lastDigit;
            }

            number /= 10;
        }

        return evenSum;
    }
}