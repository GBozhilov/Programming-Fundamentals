using System;

public class SignOfIntegerNumber
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        PrintSign(number);
    }

    public static void PrintSign(int number)
    {
        if (number == 0)
        {
            Console.WriteLine($"The number {number} is zero.");
            return;
        }

        Console.WriteLine(number > 0 ? $"The number {number} is positive."
            : $"The number {number} is negative.");
    }
}