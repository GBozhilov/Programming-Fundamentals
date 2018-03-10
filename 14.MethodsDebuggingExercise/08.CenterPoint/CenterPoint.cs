using System;

public class CenterPoint
{
    public static void Main()
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());

        PrintClosestPoint(x1, y1, x2, y2);
    }

    public static void PrintClosestPoint(double x1, double y1, double x2, double y2)
    {
        //var disToCenterA = Math.Sqrt(x1 * x1 + y1 * y1);
        //var disToCenterB = Math.Sqrt(x2 * x2 + y2 * y2);

        var disToCenterA = GetDistanceBetweenTwoPoints(x1, y1, 0, 0);
        var disToCenterB = GetDistanceBetweenTwoPoints(x2, y2, 0, 0);

        Console.WriteLine(disToCenterA <= disToCenterB ? $"({x1}, {y1})" : $"({x2}, {y2})");
    }

    static double GetDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

        return distance;
    }
}