using System;
using System.Linq;

public class ClosestTwoPoints
{
    public static void Main()
    {
        Point[] points = ReadPoints();

        Point[] closestTwoPoints = FindClosestPoints(points);

        Point firstPoint = closestTwoPoints[0];
        Point secondPoint = closestTwoPoints[1];

        double minDistance = CalculateDistance(firstPoint, secondPoint);

        Console.WriteLine($"{minDistance:F3}");
        Console.WriteLine($"({firstPoint.X}, {firstPoint.Y})");
        Console.WriteLine($"({secondPoint.X}, {secondPoint.Y})");
    }

    public static Point[] ReadPoints()
    {
        int n = int.Parse(Console.ReadLine());

        Point[] points = new Point[n];

        for (int i = 0; i < n; i++)
        {
            Point currentPoint = ReadPoint();

            points[i] = currentPoint;
        }

        return points;
    }

    public static Point[] FindClosestPoints(Point[] points)
    {
        double minDistance = double.MaxValue;
        Point[] closestTwoPoints = new Point[2];

        for (int i = 0; i < points.Length; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                Point currentPoint = points[i];
                Point checkedPoint = points[j];

                double distance = CalculateDistance(currentPoint, checkedPoint);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestTwoPoints[0] = currentPoint;
                    closestTwoPoints[1] = checkedPoint;
                }
            }
        }

        return closestTwoPoints;
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

        Point point = new Point()
        {
            X = pointInfo[0],
            Y = pointInfo[1]
        };

        return point;
    }
}

public class Point
{
    public int X { get; set; }

    public int Y { get; set; }
}