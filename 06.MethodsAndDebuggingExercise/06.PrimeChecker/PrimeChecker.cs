using System;

public class PrimeChecker
{
    public static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        bool isPrime = IsPrime(n);

        Console.WriteLine(isPrime);
    }

    static bool IsPrime(long n)
    {
        bool isPrime = true;

        if (n == 0 || n == 1)
        {
            isPrime = false;
            return isPrime;
        }

        int divider = 2;
        int maxDivider = (int)Math.Sqrt(n);

        while (divider <= maxDivider)
        {
            if (n % divider == 0)
            {
                isPrime = false;
                return isPrime;
            }

            divider++;
        }

        return isPrime;
    }
}