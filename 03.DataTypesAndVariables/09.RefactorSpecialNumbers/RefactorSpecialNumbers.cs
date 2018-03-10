using System;

public class RefactorSpecialNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int currentNumber = 1; currentNumber <= n; currentNumber++)
        {
            int sumOfDigits = 0;
            int digits = currentNumber;

            while (digits > 0)
            {
                sumOfDigits += digits % 10;
                digits = digits / 10;
            }

            bool isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) ||
                (sumOfDigits == 11);

            Console.WriteLine($"{currentNumber} -> {isSpecial}");
        }
    }
}