using System;
using System.Collections.Generic;

public class AppendLists
{
    public static void Main()
    {
        var lists = Console.ReadLine()
            .Split('|');

        var resultList = new List<string>();

        for (int i = lists.Length - 1; i >= 0; i--)
        {
            var currentList = lists[i]
                .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

            resultList.AddRange(currentList);
        }

        Console.WriteLine(string.Join(" ", resultList));
    }
}