using System;

public class EnglishNameOfLastDigitArr
{
    public static void Main()
    {
        var number = long.Parse(Console.ReadLine());

        var array = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        Console.WriteLine(array[Math.Abs(number % 10)]);
    }
}