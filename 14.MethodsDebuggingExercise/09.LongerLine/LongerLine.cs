using System;

public class LongerLine
{
    public static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());

        PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
    }

    public static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        if (GetLineLength(x1, y1, x2, y2) >= GetLineLength(x3, y3, x4, y4))
        {
            PrintClosestPoint(x1, y1, x2, y2);
        }
        else
        {
            PrintClosestPoint(x3, y3, x4, y4);
        }
    }

    public static double GetLineLength(double x1, double y1, double x2, double y2)
    {
        double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

        return length;
    }

    public static double DistanceToCenter(double x, double y)
    {
        double distance = Math.Sqrt(x * x + y * y);
        return distance;
    }

    public static void PrintClosestPoint(double x1, double y1, double x2, double y2)
    {
        if (DistanceToCenter(x1, y1) > DistanceToCenter(x2, y2))
        {
            Console.Write($"({x2}, {y2})");
            Console.WriteLine($"({x1}, {y1})");
        }
        else
        {
            Console.Write($"({x1}, {y1})");
            Console.WriteLine($"({x2}, {y2})");
        }
    }
}