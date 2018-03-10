using System;
using System.Collections.Generic;
using System.Linq;

public class CountRealNumbersOtherWay
{
    public static void Main()
    {
        double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

        foreach (double num in numbers)
        {
            if (!counts.ContainsKey(num))
                counts[num] = 1;
            else
                counts[num]++;
        }

        foreach (double num in counts.Keys)
            Console.WriteLine($"{num} -> {counts[num]}");
    }
}