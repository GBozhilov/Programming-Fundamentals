using System;

public class ReverseArrayOfStringsOtherWay
{
    public static void Main()
    {
        var array = Console.ReadLine().Split(' ');

        ReverseArray(array);

        PrintArray(array);
    }

    public static void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }

    public static void ReverseArray(string[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            SwapElements(array, i, array.Length - 1 - i);
        }
    }

    public static void SwapElements(string[] array, int i, int j)
    {
        var temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}