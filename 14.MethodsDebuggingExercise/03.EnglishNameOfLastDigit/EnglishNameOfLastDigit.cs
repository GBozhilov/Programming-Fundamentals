using System;

public class EnglishNameOfLastDigit
{
    public static void Main()
    {
        var number = long.Parse(Console.ReadLine());

        var name = GetNameOfLastDigit(number);

        Console.WriteLine(name);
    }

    public static string GetNameOfLastDigit(long number)
    {
        var lastDigit = Math.Abs(number % 10);
        var name = string.Empty;

        switch (lastDigit)
        {
            case 0:
                name = "zero";
                break;
            case 1:
                name = "one";
                break;
            case 2:
                name = "two";
                break;
            case 3:
                name = "three";
                break;
            case 4:
                name = "four";
                break;
            case 5:
                name = "five";
                break;
            case 6:
                name = "six";
                break;
            case 7:
                name = "seven";
                break;
            case 8:
                name = "eight";
                break;
            case 9:
                name = "nine";
                break;
        }

        return name;
    }
}