using System;

public class LargestCommonEnd
{
    public static void Main()
    {
        string[] firstArr = Console.ReadLine()
            .Split(' ');
        string[] secondArr = Console.ReadLine()
            .Split(' ');

        int length = Math.Min(firstArr.Length, secondArr.Length);
        int leftElements = 0;

        for (int i = 0; i < length; i++)
        {
            if (firstArr[i] == secondArr[i])
                leftElements++;
            else
                break;
        }

        Array.Reverse(firstArr);
        Array.Reverse(secondArr);

        int rightElements = 0;

        for (int i = 0; i < length; i++)
        {
            if (firstArr[i] == secondArr[i])
                rightElements++;
            else
                break;
        }

        Console.WriteLine(Math.Max(leftElements, rightElements));
    }
}