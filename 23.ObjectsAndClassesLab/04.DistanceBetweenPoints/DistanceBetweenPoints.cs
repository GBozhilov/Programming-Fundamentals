using System;
using System.Linq;

public class DistanceBetweenPoints
{
    public static void Main()
    {
        Point firstPoint = ReadPoint();
        Point secondPoint = ReadPoint();

        double distance = CalculateDistance(firstPoint, secondPoint);

        Console.WriteLine($"{distance:F3}");
    }

    public static double CalculateDistance(Point firstPoint, Point secondPoint)
    {
        double squareX = Math.Pow(firstPoint.X - secondPoint.X, 2);
        double squareY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

        double distance = Math.Sqrt(squareX + squareY);

        return distance;
    }

    public static Point ReadPoint()
    {
        int[] pointInfo = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Point point = new Point();

        point.X = pointInfo[0];
        point.Y = pointInfo[1];

        return point;
    }
}

public class Point
{
    public int X { get; set; }
    
    public int Y { get; set; }
}