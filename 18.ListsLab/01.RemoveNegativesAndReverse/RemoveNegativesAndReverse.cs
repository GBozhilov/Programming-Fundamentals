using System;
using System.Collections.Generic;
using System.Linq;

public class RemoveNegativesAndReverse
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        var positiveNums = new List<int>();

        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            var currentNum = numbers[i];

            if (currentNum < 0)
            {
                continue;
            }

            positiveNums.Add(currentNum);
        }

        Console.WriteLine(positiveNums.Any() ? string.Join(" ", positiveNums) : "empty");
    }
}