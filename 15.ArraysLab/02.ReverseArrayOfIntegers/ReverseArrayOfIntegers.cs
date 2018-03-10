using System;

public class ReverseArrayOfIntegers
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                Console.WriteLine(array[i]);
                return;
            }

            Console.Write(array[i] + " ");
        }
    }
}