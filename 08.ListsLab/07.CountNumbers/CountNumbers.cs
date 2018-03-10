﻿using System;
using System.Collections.Generic;
using System.Linq;

public class CountNumbers
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        int[] count = new int[numbers.Max() + 1];

        foreach (int num in numbers)
            count[num]++;

        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] > 0)
                Console.WriteLine($"{i} -> {count[i]}");
        }
    }
}