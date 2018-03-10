using System;
using System.Linq;

public class GrabAndGo
{
    public static void Main()
    {
        var array = Console.ReadLine()
            .Split(' ')
            .Select(n => int.Parse(n))
            .ToArray();
        var numToSearch = int.Parse(Console.ReadLine());

        long sum = 0;
        var isFound = false;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            var currentNum = array[i];

            if (currentNum.Equals(numToSearch))
            {
                isFound = true;

                for (int j = i - 1; j >= 0; j--)
                {
                    sum += array[j];
                }

                break;
            }
        }

        Console.WriteLine(isFound ? $"{sum}" : "No occurrences were found!");
    }
}