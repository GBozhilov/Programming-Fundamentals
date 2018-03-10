using System;

public class NumberChecker
{
    public static void Main()
    {
        try
        {
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine("It is a number.");
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input!");
        }
    }
}