using System;

public class MasterNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int currentNum = 1; currentNum <= n; currentNum++)
        {
            if (IsPalindrome(currentNum.ToString()) && IsSumDiv7(currentNum) && ContainsEvenDigit(currentNum))
                Console.WriteLine(currentNum);
        }
    }

    static bool IsPalindrome(string currentNum)
    {
        bool isPalindrome = true;

        for (int i = 0; i < currentNum.Length / 2; i++)
        {
            if (currentNum[i] != currentNum[currentNum.Length - 1 - i])
            {
                isPalindrome = false;
                return isPalindrome;
            }
        }

        return isPalindrome;
    }

    static bool IsSumDiv7(int n)
    {
        bool isSumDiv = false;
        int sumOfDigits = 0;

        while (n > 0)
        {
            int lastDigit = n % 10;
            sumOfDigits += lastDigit;
            n /= 10;
        }

        if (sumOfDigits % 7 == 0)
        {
            isSumDiv = true;
            return isSumDiv;
        }

        return isSumDiv;
    }

    static bool ContainsEvenDigit(int n)
    {
        bool hasEvenDigit = false;

        while (n > 0)
        {
            int lastDigit = n % 10;

            if (lastDigit % 2 == 0)
            {
                hasEvenDigit = true;
                return hasEvenDigit;
            }

            n /= 10;
        }

        return hasEvenDigit;
    }
}