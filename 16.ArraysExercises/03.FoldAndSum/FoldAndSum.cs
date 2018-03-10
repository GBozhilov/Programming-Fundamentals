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
        var upperArr = new int[2 * k];

        for (int i = 0; i < k; i++)
        {
            upperArr[i] = numbers[k - 1 - i];
        }

        for (int i = 0; i < k; i++)
        {
            upperArr[i + k] = numbers[4 * k - 1 - i];
        }

        var lowerArr = new int[2 * k];

        for (int i = 0; i < 2 * k; i++)
        {
            lowerArr[i] = numbers[i + k];
        }

        var sumArr = new int[2 * k];

        for (int i = 0; i < 2 * k; i++)
        {
            sumArr[i] = lowerArr[i] + upperArr[i];
        }

        Console.WriteLine(string.Join(" ", sumArr));
    }
}