using System;

public class RefactorSpecialNumbers
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        for (int currentNum = 1; currentNum <= n; currentNum++)
        {
            var digits = currentNum;
            var sumOfDigits = 0;

            while (digits > 0)
            {
                sumOfDigits += digits % 10;
                digits /= 10;
            }

            var isSpecialNum = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

            Console.WriteLine($"{currentNum} -> {isSpecialNum}");
        }
    }
}