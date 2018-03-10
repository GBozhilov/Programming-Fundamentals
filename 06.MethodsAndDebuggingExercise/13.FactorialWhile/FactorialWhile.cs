using System;
using System.Numerics;

public class FactorialWhile
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger nFac = CalculateFactorial(n);

        Console.WriteLine(nFac);
    }

    static BigInteger CalculateFactorial(int n)
    {
        BigInteger factorial = 1;

        while (true)
        {
            factorial *= n;
            n--;
            if (n <= 1)
                return factorial;
        }
    }
}