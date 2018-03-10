using System;

public class GameOfNumbers
{
    public static void Main()
    {
        var firstNum = int.Parse(Console.ReadLine());
        var secondNum = int.Parse(Console.ReadLine());
        var magicNum = int.Parse(Console.ReadLine());

        var count = 0;

        for (int i = secondNum; i >= firstNum; i--)
        {
            for (int j = secondNum; j >= firstNum; j--)
            {
                count++;

                if (i + j == magicNum)
                {
                    Console.WriteLine($"Number found! {i} + {j} = {magicNum}");
                    return;
                }
            }
        }

        Console.WriteLine($"{count} combinations - neither equals {magicNum}");
    }
}