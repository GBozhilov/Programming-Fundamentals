using System;

public class MultiplicationTableWhile
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        var times = 1;

        while (times <= 10)
        {
            Console.WriteLine($"{number} X {times} = {number * times}");
            times++;
        }
    }
}