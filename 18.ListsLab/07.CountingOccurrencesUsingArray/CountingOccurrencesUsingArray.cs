using System;
using System.Linq;

public class CountingOccurrencesUsingArray
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        var maxElement = numbers.Max();
        var counts = new int[maxElement + 1];

        foreach (var num in numbers)
        {
            counts[num]++;
        }

        for (int i = 0; i < counts.Length; i++)
        {
            if (counts[i] > 0)
            {
                Console.WriteLine($"{i} -> {counts[i]}");
            }
        }
    }
}