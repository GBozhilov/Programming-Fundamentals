using System;

public class MaxMethod
{
    public static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());

        int biggestNum = GetMax(GetMax(firstNum, secondNum), thirdNum);

        Console.WriteLine(biggestNum);
    }

    static int GetMax(int firstNum, int secondNum)
    {
        int biggerNum = Math.Max(firstNum, secondNum);

        return biggerNum;
    }
}