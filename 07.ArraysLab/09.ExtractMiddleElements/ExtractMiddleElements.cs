﻿using System;
using System.Linq;

public class ExtractMiddleElements
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int middle = numbers.Length / 2;

        if (numbers.Length == 1)
            Console.WriteLine(numbers[0]);
        else if (numbers.Length % 2 == 0)
            Console.WriteLine($"{numbers[middle - 1]}, {numbers[middle]}");
        else
            Console.WriteLine($"{numbers[middle - 1]}, {numbers[middle]}, {numbers[middle + 1]}");
    }
}