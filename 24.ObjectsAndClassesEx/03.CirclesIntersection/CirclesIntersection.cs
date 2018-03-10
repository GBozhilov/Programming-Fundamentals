using System;

public class CirclesIntersection
{
    public static void Main()
    {
        var firstCircle = ReadCircle();
        var secondCircle = ReadCircle();

        Console.WriteLine(firstCircle.Intersect(secondCircle) ? "Yes" : "No");
    }

    public static Circle ReadCircle()
    {
        var circleInfo = Console.ReadLine().Split(' ');

        var center = new Point()
        {
            X = int.Parse(circleInfo[0]),
            Y = int.Parse(circleInfo[1])
        };

        var radius = int.Parse(circleInfo[2]);

        return new Circle
        {
            Center = center,
            Radius = radius
        };
    }
}

public class Point
{
    public int X { get; set; }

    public int Y { get; set; }
}

public class Circle
{
    public Point Center { get; set; }

    public int Radius { get; set; }

    public double CalculateDistance(Point firstPoint, Point secondPoint)
    {
        double squareX = Math.Pow(firstPoint.X - secondPoint.X, 2);
        double squareY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

        double distance = Math.Sqrt(squareX + squareY);

        return distance;
    }

    public bool Intersect(Circle circle)
    {
        var distance = CalculateDistance(Center, circle.Center);

        if (distance <= Radius + circle.Radius)
        {
            return true;
        }

        return false;
    }
}