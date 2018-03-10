using System;
using System.Collections.Generic;
using System.Linq;

public class SquareNumbers
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        List<int> squares = new List<int>();

        foreach (int num in numbers)
            if (Math.Sqrt(num) % 1 == 0)
                squares.Add(num);

        squares.Sort((a, b) => b.CompareTo(a));

        Console.WriteLine(string.Join(" ", squares));
    }
}