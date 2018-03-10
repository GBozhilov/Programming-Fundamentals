using System;
using System.Linq;

public class SieveOfEratosthenes
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var primes = new bool[n + 1]
            .Select(x => x = true)
            .ToArray();

        for (int i = 2; i <= n; i++)
        {
            if (!primes[i])
            {
                continue;
            }

            Console.Write(i + " ");

            for (int j = i * i; j <= n; j += i)
            {
                primes[j] = false;
            }
        }

        Console.WriteLine();
    }
}