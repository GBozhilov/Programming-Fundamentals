using System;
using System.Linq;

public class RotateAndSumOtherWay
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        var rotationsCount = int.Parse(Console.ReadLine());

        var sumArr = new int[numbers.Length];
        var rotatedArr = new int[numbers.Length];
        var tempArr = new int[numbers.Length - 1];

        for (int rot = 0; rot < rotationsCount; rot++)
        {
            for (int i = 0; i < tempArr.Length; i++)
            {
                tempArr[i] = numbers[i];
            }

            rotatedArr[0] = numbers[numbers.Length - 1];

            for (int i = 0; i < tempArr.Length; i++)
            {
                rotatedArr[i + 1] = tempArr[i];
            }

            numbers = rotatedArr;

            for (int i = 0; i < numbers.Length; i++)
            {
                sumArr[i] += rotatedArr[i];
            }
        }

        Console.WriteLine(string.Join(" ", sumArr));
    }
}