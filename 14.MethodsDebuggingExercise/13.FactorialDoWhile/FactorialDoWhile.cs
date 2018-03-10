using System;
using System.Numerics;

public class FactorialDoWhile
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger factorial = CalculateFactorial(n);

        Console.WriteLine(factorial);
    }

    static BigInteger CalculateFactorial(int n)
    {
        BigInteger factorial = 1;

        do
        {
            factorial *= n;
            n--;
        } while (n >= 2);

        return factorial;
    }
}