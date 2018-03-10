using System;
using System.Linq;

public class Largest3Numbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToArray();

        var largestThreeNums = numbers
            .OrderByDescending(n => n)
            .Take(3)
            .ToArray();

        Console.WriteLine(string.Join(" ", largestThreeNums));
    }
}