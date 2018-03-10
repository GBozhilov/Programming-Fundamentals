using System;

public class MaximalSequenceOfEqualElements
{
    public static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] array = new int[arrayLength];

        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Element[{0}] = ", index);
            array[index] = int.Parse(Console.ReadLine());
        }

        int count = 1, tempCount = 1, number = 0;

        for (int index = 0; index < array.Length - 1; index++)
        {
            if (array[index] == array[index + 1])
                tempCount++;
            else
                tempCount = 1;

            if (tempCount > count)
            {
                count = tempCount;
                number = array[index];
            }
        }

        for (int index = 0; index < count; index++)
            Console.Write("{0} ", number);

        Console.WriteLine();
    }
}