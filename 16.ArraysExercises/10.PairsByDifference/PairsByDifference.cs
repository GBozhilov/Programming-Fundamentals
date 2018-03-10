using System;
using System.Linq;

public class PairsByDifference
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        var difference = int.Parse(Console.ReadLine());

        var pairsCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            var currentNum = numbers[i];

            for (int j = 0; j < numbers.Length; j++)
            {
                var checkedNum = numbers[j];

                if (currentNum - checkedNum == difference)
                {
                    pairsCount++;
                }
            }
        }

        Console.WriteLine(pairsCount);
    }
}