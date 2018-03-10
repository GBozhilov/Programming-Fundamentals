using System;
using System.Linq;

public class FoldAndSum
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(n => int.Parse(n))
            .ToArray();

        var k = numbers.Length / 4;

        var upperLeftRow = numbers
            .Take(k)
            .Reverse()
            .ToArray();
        var upperRightRow = numbers
            .Reverse()
            .Take(k)
            .ToArray();

        var upperRow = upperLeftRow
            .Concat(upperRightRow)
            .ToArray();
        var lowerRow = numbers
            .Skip(k)
            .Take(2 * k)
            .ToArray();

        var sumArr = lowerRow
            .Select((x, index) => x + upperRow[index]);

        Console.WriteLine(string.Join(" ", sumArr));
    }
}