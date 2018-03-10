using System;
using System.Collections.Generic;

public class SquareNumbers
{
    public static void Main()
    {
        string[] sequence = Console.ReadLine().Split();

        int[] numbers = new int[sequence.Length];

        for (int i = 0; i < sequence.Length; i++)
            numbers[i] = int.Parse(sequence[i]);

        List<int> squares = new List<int>();

        foreach (int num in numbers)
            if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                squares.Add(num);

        squares.Sort((a, b) => b.CompareTo(a));

        Console.WriteLine(string.Join(" ", squares));
    }
}