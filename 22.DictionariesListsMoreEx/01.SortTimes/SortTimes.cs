using System;
using System.Linq;

public class SortTimes
{
    public static void Main()
    {
        var times = Console.ReadLine()
            .Split(' ')
            .OrderBy(t => t)
            .ToArray();

        Console.WriteLine(string.Join(", ", times));
    }
}