using System;
using System.Linq;

public class SumArrays
{
    public static void Main()
    {
        var firstArr = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        var secondArr = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var sumArrLength = Math.Max(firstArr.Length, secondArr.Length);
        var sumArray = new int[sumArrLength];

        for (int i = 0; i < sumArrLength; i++)
        {
            sumArray[i] = firstArr[i % firstArr.Length] + secondArr[i % secondArr.Length];
        }

        Console.WriteLine(string.Join(" ", sumArray));
    }
}