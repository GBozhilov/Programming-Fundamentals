﻿using System;

public class NumberChecker
{
    public static void Main()
    {
        try
        {
            var number = long.Parse(Console.ReadLine());

            Console.WriteLine("integer");
        }
        catch (Exception)
        {
            Console.WriteLine("floating-point");
        }
    }
}