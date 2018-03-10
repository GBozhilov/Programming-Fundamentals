using System;
using System.Linq;

public class LargestCommonEnd
{
    public static void Main()
    {
        var firstArr = Console.ReadLine()
            .Split(' ');
        var secondArr = Console.ReadLine()
            .Split(' ');

        var leftMatches = GetMatches(firstArr, secondArr);

        Array.Reverse(firstArr);
        Array.Reverse(secondArr);

        var rightMatches = GetMatches(firstArr, secondArr);

        Console.WriteLine(Math.Max(leftMatches, rightMatches));
    }

    public static int GetMatches(string[] firstArr, string[] secondArr)
    {
        var shorterLength = Math.Min(firstArr.Length, secondArr.Length);
        var matches = 0;

        for (int i = 0; i < shorterLength; i++)
        {
            if (firstArr[i] == secondArr[i])
            {
                matches++;
                continue;
            }

            break;
        }

        return matches;
    }
}