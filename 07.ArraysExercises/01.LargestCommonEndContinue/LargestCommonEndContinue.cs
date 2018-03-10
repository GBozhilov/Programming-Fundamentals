using System;

public class LargestCommonEndContinue
{
    public static void Main()
    {
        string[] firstArr = Console.ReadLine().Split(' ');
        string[] secondArr = Console.ReadLine().Split(' ');

        int leftCommonElements = 0;
        int rightCommonElements = 0;
        int shorterLength = Math.Min(firstArr.Length, secondArr.Length);

        for (int i = 0; i < shorterLength; i++)
        {
            if (firstArr[i] == secondArr[i])
            {
                leftCommonElements++;
                continue;
            }

            break;
        }

        for (int i = 1; i <= secondArr.Length; i++)
        {
            if (firstArr[firstArr.Length - i] == secondArr[secondArr.Length - i])
            {
                rightCommonElements++;
                continue;
            }

            break;
        }

        int result = Math.Max(leftCommonElements, rightCommonElements);

        Console.WriteLine(result);
    }
}