using System;

public class CenterPoint
{
    public static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double distanceToCenterA = GetDistanceBetweenTwoPoints(x1, y1, 0, 0);
        double distanceToCenterB = GetDistanceBetweenTwoPoints(x2, y2, 0, 0);

        PrintCloserPoint(x1, y1, x2, y2, distanceToCenterA, distanceToCenterB);
    }

    static void PrintCloserPoint(double x1, double y1, double x2, double y2, 
        double disToCenterA, double disToCenterB)
    {
        if (disToCenterA > disToCenterB)
            Console.WriteLine($"({x2}, {y2})");
        else // disToCenterA <= disToCenterB       
            Console.WriteLine($"({x1}, {y1})");
    }

    static double GetDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

        return distance;
    }
}