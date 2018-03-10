﻿using System;
using System.Numerics;

public class DifferentIntegersSize
{
    public static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());

        if (number > long.MaxValue)
            Console.WriteLine($"{number} can't fit in any type");
        else
        {
            Console.WriteLine($"{number} can fit in:");
            CheckType(number);
        }
    }

    static void CheckType(BigInteger number)
    {
        if ((number >= sbyte.MinValue) && number <= (sbyte.MaxValue))
            Console.WriteLine("* sbyte");

        if ((number >= byte.MinValue) && number <= (byte.MaxValue))
            Console.WriteLine("* byte");

        if ((number >= short.MinValue) && number <= (short.MaxValue))
            Console.WriteLine("* short");

        if ((number >= ushort.MinValue) && number <= (ushort.MaxValue))
            Console.WriteLine("* ushort");

        if ((number >= int.MinValue) && number <= (int.MaxValue))
            Console.WriteLine("* int");

        if ((number >= uint.MinValue) && number <= (uint.MaxValue))
            Console.WriteLine("* uint");

        if ((number >= long.MinValue) && number <= (long.MaxValue))
            Console.WriteLine("* long");
    }
}