using System;

public class ForeachLoop
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.Write("Reversed: ");
        for (int index = array.Length - 1; index >= 0; index--)
        {
            Console.Write(array[index] + " ");
        }
        Console.WriteLine();
    }
}