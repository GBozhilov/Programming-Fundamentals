using System;
using System.Numerics;

public class ConvertFromBaseNToBase10
{
    public static void Main()
    {
        var convertParams = Console.ReadLine().Split(' ');

        var @base = int.Parse(convertParams[0]);
        var number = BigInteger.Parse(convertParams[1]);

        var sum = new BigInteger();
        var power = 0;

        while (number > 0)
        {
            var lastDigit = (int)(number % 10);
            sum += lastDigit * BigInteger.Pow(@base, power);
            number /= 10;
            power++;
        }

        Console.WriteLine(sum);
    }
}