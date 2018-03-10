using System;
using System.Linq;

public class RotateAndSum
{
    public static void Main()
    {
        int[] inputArr = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int rotations = int.Parse(Console.ReadLine());

        int[] tempArr = new int[inputArr.Length - 1];
        int[] rotatedArr = new int[inputArr.Length];
        int[] sumArr = new int[inputArr.Length];

        for (int rot = 0; rot < rotations; rot++)
        {
            for (int i = 0; i < inputArr.Length - 1; i++)
            {
                tempArr[i] = inputArr[i];
            }

            rotatedArr[0] = inputArr[inputArr.Length - 1];

            for (int i = 0; i < inputArr.Length - 1; i++)
            {
                rotatedArr[i + 1] = tempArr[i];
            }

            inputArr = rotatedArr;

            for (int i = 0; i < inputArr.Length; i++)
            {
                sumArr[i] += rotatedArr[i];
            }
        }

        Console.WriteLine(string.Join(" ", sumArr));
    }
}