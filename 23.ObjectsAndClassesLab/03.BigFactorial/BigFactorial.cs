using System;
using System.Numerics;

public class BigFactorial
{
    public static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        do
        {
            factorial *= n;
            n--;
        } while (n >= 2);

        Console.WriteLine(factorial);
    }
}