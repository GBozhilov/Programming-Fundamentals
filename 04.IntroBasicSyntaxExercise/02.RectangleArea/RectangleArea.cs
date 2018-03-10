using System;

public class RectangleArea
{
    public static void Main()
    {
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());

        var rectangleArea = width * height;

        Console.WriteLine("{0:F2}", rectangleArea);
    }
}