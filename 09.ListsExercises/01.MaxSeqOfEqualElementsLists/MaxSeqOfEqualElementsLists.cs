using System;
using System.Collections.Generic;
using System.Linq;

public class MaxSeqOfEqualElementsLists
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        List<int> maxSeq = new List<int>();
        List<int> currentSeq = new List<int>(); 

        currentSeq.Add(numbers[0]);

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
                currentSeq.Add(numbers[i + 1]);
            else
            {
                currentSeq.Clear();
                currentSeq.Add(numbers[i + 1]);
            }

            if (currentSeq.Count > maxSeq.Count)
            {
                maxSeq.Clear();
                maxSeq.AddRange(currentSeq);
            }
        }

        if (maxSeq.Count == 1)
        {
            Console.WriteLine(numbers[0]);
            return;
        }

        Console.WriteLine(string.Join(" ", maxSeq));
    }
}