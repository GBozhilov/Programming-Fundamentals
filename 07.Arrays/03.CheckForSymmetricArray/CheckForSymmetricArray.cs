using System;

public class CheckForSymmetricArray
{
    public static void Main()
    {
        Console.Write("Enter a pisitive integer: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Enter the values of the array:");

        for (int index = 0; index < n; index++)
        {
            array[index] = int.Parse(Console.ReadLine());
        }

        bool symmetric = true;
        for (int index = 0; index < array.Length / 2; index++) // array.Length = n
        {
            if (array[index] != array[n - index - 1])
            {
                symmetric = false;
                break;
            }
        }
        Console.WriteLine("Is symmetric? {0}", symmetric);
    }
}