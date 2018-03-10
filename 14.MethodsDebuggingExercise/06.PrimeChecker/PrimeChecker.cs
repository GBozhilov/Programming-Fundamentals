using System;

public class PrimeChecker
{
    public static void Main()
    {
        var number = long.Parse(Console.ReadLine());

        var isPrime = IsPrime(number);

        Console.WriteLine(isPrime);
    }

    public static bool IsPrime(long number)
    {
        var isPrime = true;

        if (number == 0 || number == 1)
        {
            isPrime = false;
            return isPrime;
        }

        var divider = 2;
        var maxDivider = (int)Math.Sqrt(number);

        while (divider <= maxDivider)
        {
            if (number % divider == 0)
            {
                isPrime = false;
                return isPrime;
            }

            divider++;
        }

        return isPrime;
    }
}