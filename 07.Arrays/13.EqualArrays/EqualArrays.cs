using System;

public class EqualArrays
{
    public static void Main()
    {
        Console.Write("Enter the length of the first array:  ");
        int length = int.Parse(Console.ReadLine());

        int[] firstArray = new int[length];

        bool equalArrays = true;

        // Initialize the elements of the first array;
        for (int index = 0; index < firstArray.Length; index++)
        {
            Console.Write("Element[{0}] = ", index);
            firstArray[index] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the length of the second array:  ");
        if (length != int.Parse(Console.ReadLine()))
            Console.WriteLine("Arrays have different lengths!");
        else
        {
            int[] secondArray = new int[length];

            // Initialize the elements of the second array;
            for (int index = 0; index < firstArray.Length; index++)
            {
                Console.Write("Element[{0}] = ", index);
                secondArray[index] = int.Parse(Console.ReadLine());

                if (firstArray[index] != secondArray[index])
                {
                    Console.WriteLine("Arrays are different.");
                    equalArrays = false;
                    break;
                }
            }

            if (equalArrays)
                Console.WriteLine("Arrays are same.");
        }
    }
}