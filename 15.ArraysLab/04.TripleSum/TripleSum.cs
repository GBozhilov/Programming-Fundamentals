using System;
using System.Linq;

public class TripleSum
{
    public static void Main()
    {
        var array = Console.ReadLine()
            .Split(' ')
            .Select(long.Parse)
            .ToArray();

        var hasMatch = false;

        for (int i = 0; i < array.Length; i++)
        {
            var firstNum = array[i];

            for (int j = i + 1; j < array.Length; j++)
            {
                var secondNum = array[j];

                for (int k = 0; k < array.Length; k++)
                {
                    var thirdNum = array[k];

                    if (firstNum + secondNum == thirdNum)
                    {
                        hasMatch = true;
                        Console.WriteLine($"{firstNum} + {secondNum} == {thirdNum}");
                        break;
                    }
                }
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("No");
        }
    }
}