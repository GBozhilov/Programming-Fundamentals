using System;

public class EnglishNameOfLastDigitArray
{
    public static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        string[] names = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        Console.WriteLine(names[Math.Abs(n % 10)]);
    }
}