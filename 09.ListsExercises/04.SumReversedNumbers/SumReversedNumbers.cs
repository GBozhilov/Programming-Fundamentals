using System;
using System.Collections.Generic;
using System.Linq;

public class SumReversedNumbers
{
    public static void Main()
    {
        string[] sequence = Console.ReadLine().Split(' ');

        long sum = 0;

        foreach (string num in sequence)
        {
            List<char> reversedNum = num.Reverse().ToList();
            string reversedNumStr = string.Join("", reversedNum);
            int parsedNum = int.Parse(reversedNumStr);
            sum += parsedNum;
        }

        Console.WriteLine(sum);
    }
}