using System;

public class ReverseArrayOfIntegersOtherWay
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        int[] reversed = new int[n];

        // array.Length = reversed.Length = n
        for (int i = 0; i < arr.Length; i++)
            arr[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < arr.Length; i++)
            reversed[i] = arr[arr.Length - i - 1];

        for (int i = 0; i < arr.Length; i++)
            Console.Write($"{reversed[i]} ");

        Console.WriteLine();
    }
}