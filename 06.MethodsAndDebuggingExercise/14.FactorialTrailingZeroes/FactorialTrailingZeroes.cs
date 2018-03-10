using System;
using System.Numerics;

public class FactorialTrailingZeroes
{
    public static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        BigInteger nFac = CalculateFactorial(n);

        long sumLastZeros = GetTrailingZeros(nFac);

        Console.WriteLine(sumLastZeros);
    }

    static BigInteger CalculateFactorial(long n)
    {
        BigInteger factorial = 1;

        do
        {
            factorial *= n;
            n--;
        } while (n > 0);

        return factorial;
    }

    static long GetTrailingZeros(BigInteger nFac)
    {
        long sumLastZeros = 0;

        while (nFac > 0)
        {
            int lastDigit = (int)(nFac % 10);

            if (lastDigit == 0)
                sumLastZeros++;
            else // lastDigit != 0
                return sumLastZeros;

            nFac /= 10;
        }

        return sumLastZeros;
    }
}