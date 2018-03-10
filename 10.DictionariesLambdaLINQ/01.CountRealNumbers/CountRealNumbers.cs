using System;
using System.Collections.Generic;
using System.Linq;

public class CountRealNumbers
{
    public static void Main()
    {
        double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        SortedDictionary<double, int> numberCount = new SortedDictionary<double, int>();

        foreach (double number in numbers)
        {
            if (!numberCount.ContainsKey(number))
                numberCount[number] = 0;

            numberCount[number]++;
        }

        foreach (KeyValuePair<double, int> pair in numberCount)
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
    }
}