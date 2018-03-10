using System;

public class MultiplicationTableDoWhile
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var startMultiplier = int.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine($"{n} X {startMultiplier} = {n * startMultiplier}");
            startMultiplier++;
        } while (startMultiplier <= 10);
    }
}