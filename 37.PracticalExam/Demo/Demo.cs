using System;
using System.Linq;

public class SymmetricNumbers
{
    public static void Main()
    {
        Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .OrderByDescending(n => n)
            .Take(3)
            .ToList()
            .ForEach(Console.WriteLine);
    }
}