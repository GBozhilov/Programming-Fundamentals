using System;
using System.Numerics;

public class ConvertFromBase10ToBaseN
{
    public static void Main()
    {
        var convertParams = Console.ReadLine().Split(' ');

        var @base = int.Parse(convertParams[0]);
        var number = BigInteger.Parse(convertParams[1]);

        var binString = string.Empty;

        while (number > 0)
        {
            var remainder = number % @base;
            binString = remainder + binString;
            number /= @base;
        }

        Console.WriteLine(binString);
    }
}