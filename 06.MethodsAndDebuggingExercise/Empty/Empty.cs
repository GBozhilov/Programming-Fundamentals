using System;

public class Empty
{
    public static void Main()
    {
        string NumberStr = Console.ReadLine();

        string lastDigitName = GetLastDigitName(NumberStr);

        Console.WriteLine(lastDigitName);
    }

    static string GetLastDigitName(string NumberStr)
    {
        char lastDigit = NumberStr[NumberStr.Length - 1];

        switch (lastDigit)
        {
            case '1':
                return "one";
            case '2':
                return "two";
            case '3':
                return "three";
            case '4':
                return "four";
            case '5':
                return "five";
            case '6':
                return "six";
            case '7':
                return "seven";
            case '8':
                return "eight";
            case '9':
                return "nine";
            default:
                return "zero";
        }
    }
}