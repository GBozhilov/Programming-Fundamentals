using System;

public class CircleArea
{
    public static void Main()
    {
        double radius = double.Parse(Console.ReadLine());

        double circleArea = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("{0:F12}", circleArea);
    }
}