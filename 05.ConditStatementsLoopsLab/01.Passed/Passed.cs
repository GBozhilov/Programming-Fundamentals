using System;

public class Passed
{
    public static void Main()
    {
        var grade = double.Parse(Console.ReadLine());

        Console.WriteLine(grade >= 3.00 ? "Passed!" : string.Empty);
    }
}