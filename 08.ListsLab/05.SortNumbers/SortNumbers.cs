using System;
using System.Collections.Generic;

public class SortNumbers
{
    public static void Main()
    {
        string[] sequence = Console.ReadLine().Split(' ');

        List<decimal> numbers = new List<decimal>();

        foreach (string num in sequence)
            numbers.Add(decimal.Parse(num));

        numbers.Sort();

        Console.WriteLine(string.Join(" <= ", numbers));

    }
}