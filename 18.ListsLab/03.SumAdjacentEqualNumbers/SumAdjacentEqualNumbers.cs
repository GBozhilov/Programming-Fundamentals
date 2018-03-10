using System;
using System.Linq;

public class SumAdjacentEqualNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(decimal.Parse)
            .ToList();

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            var currentNum = numbers[i];
            var nextNum = numbers[i + 1];

            if (currentNum == nextNum)
            {
                numbers[i] += nextNum;
                numbers.RemoveAt(i + 1);
                i = -1;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}