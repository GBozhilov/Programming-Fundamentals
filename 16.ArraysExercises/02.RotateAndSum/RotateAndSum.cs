using System;
using System.Linq;

public class RotateAndSum
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        var rotations = int.Parse(Console.ReadLine());

        var sumArray = new int[numbers.Length];

        for (int i = 0; i < rotations; i++)
        {
            RotateArray(numbers);
            SumArrays(sumArray, numbers);
        }

        Console.WriteLine(string.Join(" ", sumArray));
    }

    public static void SumArrays(int[] sumArray, int[] numbers)
    {
        for (int j = 0; j < numbers.Length; j++)
        {
            sumArray[j] += numbers[j];
        }
    }

    public static void RotateArray(int[] array)
    {
        var lastElement = array[array.Length - 1];

        for (int i = array.Length - 1; i > 0; i--)
        {
            array[i] = array[i - 1];
        }

        array[0] = lastElement;
    }
}