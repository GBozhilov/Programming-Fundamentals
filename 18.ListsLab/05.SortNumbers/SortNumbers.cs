using System;
using System.Linq;

public class SortNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToArray();

        //numbers.Sort();

        bool swapped;

        do
        {
            swapped = false;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                var currentNum = numbers[i];
                var nextNum = numbers[i + 1];

                if (currentNum > nextNum)
                {
                    numbers[i] = nextNum;
                    numbers[i + 1] = currentNum;

                    swapped = true;
                }
            }

        } while (swapped);

        Console.WriteLine(string.Join(" <= ", numbers));
    }
}