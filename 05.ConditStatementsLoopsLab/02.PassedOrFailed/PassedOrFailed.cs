using System;

public class PassedOrFailed
{
    public static void Main()
    {
        var grade = double.Parse(Console.ReadLine());

        Console.WriteLine(grade < 3.00 ? "Failed!" : "Passed!");
    }
}