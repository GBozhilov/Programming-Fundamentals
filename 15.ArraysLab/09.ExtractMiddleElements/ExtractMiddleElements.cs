using System;
using System.Linq;

public class ExtractMiddleElements
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var length = numbers.Length;

        if (length == 1)
        {
            PrintArray(numbers);
        }
        else if (length % 2 == 0)
        {
            var middleTwoElements = ExtractMiddleTwoElements(numbers);
            PrintArray(middleTwoElements);
        }
        else
        {
            var middleThreeElements = ExtractMiddleThreeElements(numbers);
            PrintArray(middleThreeElements);
        }
    }

    public static int[] ExtractMiddleThreeElements(int[] array)
    {
        var middleThreeElements = new int[3];

        middleThreeElements[0] = array[array.Length / 2 - 1];
        middleThreeElements[1] = array[array.Length / 2];
        middleThreeElements[2] = array[array.Length / 2 + 1];

        return middleThreeElements;
    }

    public static int[] ExtractMiddleTwoElements(int[] array)
    {
        var middleTwoElements = new int[2];

        middleTwoElements[0] = array[array.Length / 2 - 1];
        middleTwoElements[1] = array[array.Length / 2];

        return middleTwoElements;
    }

    public static void PrintArray(int[] array)
    {
        Console.WriteLine("{" + string.Join(", ", array) + "}");
    }
}