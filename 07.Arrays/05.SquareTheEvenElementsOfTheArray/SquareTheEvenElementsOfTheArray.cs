using System;

public class SquareTheEvenElementsOfTheArray
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.Write("Output: ");
        for (int index = 0; index < array.Length; index += 2)
        {
            array[index] = array[index] * array[index];
            Console.Write("{0} ", array[index]);
        }
        Console.WriteLine();
    }
}