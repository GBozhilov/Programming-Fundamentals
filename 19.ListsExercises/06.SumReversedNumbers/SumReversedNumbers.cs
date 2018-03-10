using System;
using System.Linq;

public class SumReversedNumbers
{
    public static void Main()
    {
        var arr = Console.ReadLine().Split(' ');

        var sum = 0;

        foreach (var item in arr)
        {
            var reversedNum = item.Reverse().ToArray();
            var reversedNumStr = new string(reversedNum);
            var parsedNum = int.Parse(reversedNumStr);

            sum += parsedNum;
        }

        Console.WriteLine(sum);
    }
}