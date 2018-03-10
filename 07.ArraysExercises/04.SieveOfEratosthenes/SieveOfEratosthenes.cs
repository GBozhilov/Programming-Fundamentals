using System;

public class SieveOfEratosthenes
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        FindPrimes(n);
    }

    public static void FindPrimes(int n)
    {
        bool[] primes = new bool[n + 1];

        for (int i = 2; i <= n; i++)
        {
            primes[i] = true;
        }

        for (int i = 2; i <= n; i++)
        {
            if (!primes[i])
            {
                continue;
            }

            Console.Write($"{i} ");

            for (int j = i * i; j <= n; j += i)
            {
                primes[j] = false;
            }
        }

        Console.WriteLine();
    }
}