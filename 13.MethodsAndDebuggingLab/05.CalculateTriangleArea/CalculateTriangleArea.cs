using System;

public class CalculateTriangleArea
{
    public static void Main()
    {
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());

        var area = GetTriangleArea(width, height);

        Console.WriteLine(area);
    }

    public static double GetTriangleArea(double width, double height)
    {
        var area = width * height / 2;

        return area;
    }
}