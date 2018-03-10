using System;
using System.Numerics;

public class FactorialTrailingZeroes
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var factorial = CalculateFactorial(n);
        var trailingZeroes = GetTrailingZeros(factorial);

        Console.WriteLine(trailingZeroes);
    }

    public static int GetTrailingZeros(BigInteger number)
    {
        var trailingZeroes = 0;

        while (number > 0)
        {
            var lastDigit = (int)(number % 10);

            if (lastDigit == 0)
            {
                trailingZeroes++;
                number /= 10;
                continue;
            }

            return trailingZeroes;
        }

        return trailingZeroes;
    }

    public static BigInteger CalculateFactorial(int n)
    {
        BigInteger factorial = 1;

        while (n >= 2)
        {
            factorial *= n;
            n--;
        }

        return factorial;
    }
}