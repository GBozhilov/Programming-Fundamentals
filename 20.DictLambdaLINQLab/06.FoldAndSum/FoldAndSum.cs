using System;
using System.Linq;

public class FoldAndSum
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var k = numbers.Length / 4;

        var leftPart = numbers
            .Take(k)
            .Reverse()
            .ToArray();
        var rightPart = numbers
            .Reverse()
            .Take(k)
            .ToArray();

        var upperRow = leftPart
            .Concat(rightPart)
            .ToArray();
        var lowerRow = numbers
            .Skip(k)
            .Take(2 * k)
            .ToArray();

        var sumArr = lowerRow
            .Select((x, index) => x + upperRow[index])
            .ToArray();

        Console.WriteLine(string.Join(" ", sumArr));
    }
}