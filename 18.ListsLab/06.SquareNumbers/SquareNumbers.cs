using System;
using System.Collections.Generic;
using System.Linq;

public class SquareNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        var squareNums = new List<int>();

        foreach (var num in numbers)
        {
            var sqrtNum = Math.Sqrt(num);

            if (sqrtNum == (int)sqrtNum)
            {
                squareNums.Add(num);
            }
        }

        //squareNums = squareNums
        //    .OrderByDescending(num => num)
        //    .ToList();

        squareNums.Sort((a, b) => b.CompareTo(a));

        Console.WriteLine(string.Join(" ", squareNums));
    }
}