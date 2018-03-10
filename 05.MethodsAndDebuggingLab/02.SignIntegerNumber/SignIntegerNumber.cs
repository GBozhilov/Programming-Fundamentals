using System;

public class SignIntegerNumber
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        PrintIntegerSign(number);
    }

    static void PrintIntegerSign(int n)
    {
        if (n > 0)
            Console.WriteLine($"The number {n} is positive.");
        else if (n < 0)
            Console.WriteLine($"The number {n} is negative.");
        else
            Console.WriteLine($"The number {n} is zero.");
    }
}