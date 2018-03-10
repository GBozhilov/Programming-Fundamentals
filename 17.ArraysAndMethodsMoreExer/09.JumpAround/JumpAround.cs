using System;
using System.Linq;

public class JumpAround
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int position = 0;
        int sum = 0;

        while (true)
        {
            int currentNum = numbers[position];

            sum += currentNum;

            if (position + currentNum < numbers.Length)
            {
                position += currentNum;
            }
            else if (position - currentNum >= 0)
            {
                position -= currentNum;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(sum);
    }
}