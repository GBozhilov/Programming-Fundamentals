using System;
using System.Collections.Generic;
using System.Linq;

public class Empty
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var currentNums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var resultList = new List<int>();

            for (int j = 0; j < currentNums.Length; j++)
            {
                var currentNum = currentNums[j];

                if (currentNum >= 0)
                {
                    resultList.Add(currentNum);
                }
                else if (j + 1 < currentNums.Length)
                {
                    var nextNum = currentNums[j + 1];
                    currentNum += nextNum;

                    if (currentNum >= 0)
                    {
                        resultList.Add(currentNum);
                    }

                    j++;
                }
            }

            Console.WriteLine(resultList.Any() ? string.Join(" ", resultList) : "(empty)");
        }
    }
}