using System;

public class Empty
{
    public static void Main()
    {
        Console.Write("Enter array length: ");
        int length = Int32.Parse(Console.ReadLine());

        int[] arr = new int[length];
        int sames = 1, bestSames = 1, bestStart = 0, lastElement = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter {0} element: ", i);
            arr[i] = Int32.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] + 1 == arr[i + 1])
            {
                sames++;
                if (sames > bestSames)
                {
                    bestSames = sames;
                    lastElement = i + 1;
                    bestStart = lastElement - bestSames + 1;
                }
            }
            else sames = 1;
        }

        for (int i = bestStart; i < bestSames + bestStart; i++) Console.Write("{0}, ", arr[i]);
    }
}