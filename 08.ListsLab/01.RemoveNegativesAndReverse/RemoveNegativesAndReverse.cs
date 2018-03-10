using System;
using System.Collections.Generic;
using System.Linq;

public class RemoveNegativesAndReverse
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<int> positiveNums = new List<int>();

        foreach (int num in numbers)
        {
            if (num >= 0)
                positiveNums.Add(num);
        }

        positiveNums.Reverse();

        if (positiveNums.Count != 0)
            Console.WriteLine(string.Join(" ", positiveNums));
        else
            Console.WriteLine("empty");
    }
}