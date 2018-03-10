using System;

public class ReverseString
{
    public static void Main()
    {
        char[] textArr = Console.ReadLine()
            .ToCharArray();

        Array.Reverse(textArr);

        Console.WriteLine(new string(textArr));
    }
}