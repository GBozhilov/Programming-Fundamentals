using System;

public class CircleArea
{
    public static void Main()
    {
        var radius = double.Parse(Console.ReadLine());

        var circleArea = Math.PI * radius * radius;
        //var circleArea = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine($"{circleArea:F12}");
    }
}