using System;
using System.Linq;

public class SumMinMaxAverage
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var numbers = new int[n];

        for (int i = 0; i < n; i++)
            numbers[i] = int.Parse(Console.ReadLine());

        var sum = numbers.Sum();
        var min = numbers.Min();
        var max = numbers.Max();
        var average = numbers.Average();

        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Min = {min}");
        Console.WriteLine($"Max = {max}");
        Console.WriteLine($"Average = {average}");
    }
}