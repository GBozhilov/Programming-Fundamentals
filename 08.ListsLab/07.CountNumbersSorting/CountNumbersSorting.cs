using System;
using System.Collections.Generic;
using System.Linq;

public class CountNumbersSorting
{
    public static void Main()
    {
        List<int> numbers = ReadNumbers();

        numbers.Sort();

        int pos = 0;

        while (pos < numbers.Count)
        {
            int num = numbers[pos];
            int count = 1;

            while ((pos + count < numbers.Count) && (numbers[pos + count] == num))
                count++;

            pos += count;

            Console.WriteLine($"{num}-> {count}");
        }
    }

    static List<int> ReadNumbers()
    {
        return Console.ReadLine().Split().Select(int.Parse).ToList();
    }
}