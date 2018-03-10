using System;

public class IntervalOfNumbers
{
    public static void Main()
    {
        var firstNum = int.Parse(Console.ReadLine());
        var secondNum = int.Parse(Console.ReadLine());

        var start = Math.Min(firstNum, secondNum);
        var end = Math.Max(firstNum, secondNum);

        for (int num = start; num <= end; num++)
        {
            Console.WriteLine(num);
        }
    }
}