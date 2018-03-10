using System;
using System.Numerics;

public class FactorialDoWhile
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

        do
        {
            factorial *= n;
            n--;
        } while (n > 0);

        return factorial;
    }
}