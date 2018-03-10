using System;

public class ReverseArrayOfIntegers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int index = 0; index < array.Length; index++)
            array[index] = int.Parse(Console.ReadLine());

        for (int index = array.Length - 1; index >= 0; index--)
            Console.Write($"{array[index]} ");

        Console.WriteLine();
    }
}