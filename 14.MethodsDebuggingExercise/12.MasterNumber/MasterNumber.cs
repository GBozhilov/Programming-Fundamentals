using System;

public class MasterNumber
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        for (int currentNum = 1; currentNum <= n; currentNum++)
        {
            var isSymmetric = IsSymmetric(currentNum);
            var isSumDivBySeven = IsSumDivBySeven(currentNum);
            var hasEvenDigit = ContainsEvenDigit(currentNum);

            if (isSymmetric && isSumDivBySeven && hasEvenDigit)
            {
                Console.WriteLine(currentNum);
            }
        }
    }

    public static bool ContainsEvenDigit(int currentNum)
    {
        while (currentNum > 0)
        {
            var lastDigit = currentNum % 10;

            if (lastDigit % 2 == 0)
            {
                return true;
            }

            currentNum /= 10;
        }

        return false;
    }

    public static bool IsSumDivBySeven(int currentNum)
    {
        var sumOfDigits = SumOfDigits(currentNum);

        if (sumOfDigits % 7 == 0)
        {
            return true;
        }

        return false;
    }

    public static bool IsSymmetric(int currentNum)
    {
        var digits = currentNum;
        var reversedNum = 0;

        while (digits > 0)
        {
            var lastDigit = digits % 10;
            reversedNum = reversedNum * 10 + lastDigit;
            digits /= 10;
        }

        if (reversedNum == currentNum)
        {
            return true;
        }

        return false;
    }

    public static int SumOfDigits(int currentNum)
    {
        var sumOfDigits = 0;
        var digits = currentNum;

        while (digits > 0)
        {
            var lastDigit = digits % 10;
            sumOfDigits += lastDigit;
            digits /= 10;
        }

        return sumOfDigits;
    }
}