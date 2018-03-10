using System;

public class OddNumber
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        while (true)
        {
            if (number % 2 != 0)
            {
                break;
            }

            Console.WriteLine("Please write an odd number.");
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"The number is: {Math.Abs(number)}");
    }
}