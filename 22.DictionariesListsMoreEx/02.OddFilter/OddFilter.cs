using System;
using System.Linq;

public class OddFilter
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .Where(n => n % 2 == 0)
            .ToArray();

        var average = numbers.Average();

        numbers = numbers
            .Select(n => ConvertEvenToOdd(n, average))
            .ToArray();

        Console.WriteLine(string.Join(" ", numbers));
    }

    public static int ConvertEvenToOdd(int evenNum, double average)
    {
        var oddNum = evenNum > average ? ++evenNum : --evenNum;

        return oddNum;
    }
}
