using System;

public class MaxMethod
{
    public static void Main()
    {
        var firstNum = int.Parse(Console.ReadLine());
        var secondNum = int.Parse(Console.ReadLine());
        var thirdNum = int.Parse(Console.ReadLine());

        var biggestNum = GetMax(firstNum, GetMax(secondNum, thirdNum));

        Console.WriteLine(biggestNum);
    }

    public static int GetMax(int firstNum, int secondNum)
    {
        return Math.Max(firstNum, secondNum);
    }
}