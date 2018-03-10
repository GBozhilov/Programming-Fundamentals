using System;
using System.Numerics;

public class Factorial
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var factorial = CalculateFactorial(n);

        Console.WriteLine(factorial);
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