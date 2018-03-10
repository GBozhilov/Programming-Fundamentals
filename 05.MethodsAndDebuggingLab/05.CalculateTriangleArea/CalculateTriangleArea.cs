using System;

public class CalculateTriangleArea
{
    public static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double triangleArea = GetTriangleArea(width, height);

        Console.WriteLine(triangleArea);
    }

    static double GetTriangleArea(double width, double height)
    {
        double area = width * height / 2;
        return area;
    }
}