using System;
using System.Linq;

public class SearchForANumber
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        var arr = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var hasElement = numbers
            .Take(arr[0])
            .Skip(arr[1])
            .Contains(arr[2]);

        Console.WriteLine(hasElement ? "YES!" : "NO!");
    }
}