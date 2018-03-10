using System;
using System.Numerics;

public class Factorial
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

        for (int i = 2; i <= n; i++)       
            factorial *= i;        

        return factorial;
    }
}