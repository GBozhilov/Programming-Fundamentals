using System;
using System.Linq;

public class CountingOccurrencesAfterSorting
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Array.Sort(numbers);
        var pos = 0;

        while (pos < numbers.Length)
        {
            var num = numbers[pos];
            var count = 1;

            while (pos + count < numbers.Length && num == numbers[pos + count])
            {
                count++;
            }

            Console.WriteLine($"{num} -> {count}");

            pos += count;
        }
    }
}