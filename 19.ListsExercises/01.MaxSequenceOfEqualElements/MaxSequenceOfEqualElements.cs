using System;
using System.Collections.Generic;
using System.Linq;

public class MaxSequenceOfEqualElements
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(n => int.Parse(n))
            .ToArray();

        var tempList = new List<int>();
        var finalList = new List<int>();

        tempList.Add(numbers[0]);

        for (int i = 1; i < numbers.Length; i++)
        {
            var currentNum = numbers[i];
            var previousNum = tempList[0];

            if (currentNum.Equals(previousNum))
            {
                tempList.Add(currentNum);
            }
            else
            {
                CheckLengths(tempList, finalList);

                tempList.Clear();
                tempList.Add(currentNum);
            }

            CheckLengths(tempList, finalList);
        }

        Console.WriteLine(string.Join(" ", finalList));
    }

    static void CheckLengths(List<int> tempList, List<int> finalList)
    {
        if (tempList.Count > finalList.Count)
        {
            finalList.Clear();
            finalList.AddRange(tempList);
        }
    }
}