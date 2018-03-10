using System;
using System.Linq;

public class CompareCharArraysOtherWay
{
    public static void Main()
    {
        var firstArray = Console.ReadLine()
            .ToCharArray()
            .Where(s => s != ' ')
            .ToArray();
        var secondArray = Console.ReadLine()
            .ToCharArray()
            .Where(s => s != ' ')
            .ToArray();

        var smallLength = Math.Min(firstArray.Length, secondArray.Length);

        for (int i = 0; i < smallLength; i++)
        {
            var firstChar = firstArray[i];
            var secondChar = secondArray[i];

            if (firstChar < secondChar)
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
                return;
            }
            else if (firstChar > secondChar)
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
                return;
            }
        }

        if (firstArray.Length <= secondArray.Length)
        {
            Console.WriteLine(string.Join("", firstArray));
            Console.WriteLine(string.Join("", secondArray));
        }
        else
        {
            Console.WriteLine(string.Join("", secondArray));
            Console.WriteLine(string.Join("", firstArray));
        }
    }
}