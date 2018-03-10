using System;

public class DoublingTheElementsOfArray
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.Write("Output: ");
        for (int index = 0; index < array.Length; index++)
        {
            array[index] *= 2;
            Console.Write(array[index] + " ");
        }
        Console.WriteLine();
    }
}