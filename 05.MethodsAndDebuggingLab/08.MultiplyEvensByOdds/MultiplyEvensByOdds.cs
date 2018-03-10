using System;

public class MultiplyEvensByOdds
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int absNum = Math.Abs(number);

        int endResult = GetMultipleOfEvensAndOdds(absNum);

        Console.WriteLine(endResult);

    }

    static int GetSumOfEvenDigits(int number)
    {
        int evenSum = 0;

        while (number > 0)
        {
            int lastDigit = number % 10;

            if (lastDigit % 2 == 0)
                evenSum += lastDigit;

            number /= 10;
        }

        return evenSum;
    }

    static int GetSumOfOddDigits(int number)
    {
        int oddSum = 0;

        while (number > 0)
        {
            int lastDigit = number % 10;

            if (lastDigit % 2 != 0)
                oddSum += lastDigit;

            number /= 10;
        }

        return oddSum;
    }

    static int GetMultipleOfEvensAndOdds(int number)
    {
        int sumOfEvens = GetSumOfEvenDigits(number);
        int sumOfOdds = GetSumOfOddDigits(number);

        int result = sumOfEvens * sumOfOdds;

        return result;
    }
}