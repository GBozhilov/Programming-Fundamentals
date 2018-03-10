using System;

public class ComparingFloats
{
    public static void Main()
    {
        var firstNum = double.Parse(Console.ReadLine());
        var secondNum = double.Parse(Console.ReadLine());

        const double precision = 0.000001;

        var difference = Math.Abs(firstNum - secondNum);
        var areEqual = difference < precision ? true : false;

        Console.WriteLine(areEqual);
    }
}