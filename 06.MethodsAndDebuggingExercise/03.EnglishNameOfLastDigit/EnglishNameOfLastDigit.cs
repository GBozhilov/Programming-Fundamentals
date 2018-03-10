using System;

public class EnglishNameOfLastDigit
{
    public static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        string lastDigitString = GetNameOfLastDigit(n);

        Console.WriteLine(lastDigitString);
    }

    static string GetNameOfLastDigit(long n)
    {
        string name = string.Empty;
        int lastDigitInt = Math.Abs(n % 10);

        switch (lastDigitInt)
        {
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
            default:
                name = "zero";
                break;
        }

        return name;
    }
}