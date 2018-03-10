using System;
using System.Linq;

public class ReverseArrayOfStrings
{
    public static void Main()
    {
        Console.WriteLine(string.Join(" ", Console.ReadLine()
            .Split(' ')
            .Reverse()));
    }
}