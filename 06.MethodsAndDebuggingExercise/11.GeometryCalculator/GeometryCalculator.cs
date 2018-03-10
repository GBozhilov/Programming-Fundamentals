using System;

public class GeometryCalculator
{
    public static void Main()
    {
        string figureType = Console.ReadLine().ToLower();

        ChooseFigure(figureType);
    }

    private static void ChooseFigure(string figureType)
    {
        switch (figureType)
        {
            case "triangle":
                PrintResult(GetTriangleArea());
                break;
            case "square":
                PrintResult(GetSquareArea());
                break;
            case "rectangle":
                PrintResult(GetRectangleArea());
                break;
            case "circle":
                PrintResult(GetCircleArea());
                break;
            default:
                Console.WriteLine("Invalid Figure!");
                break;
        }
    }

    static double GetTriangleArea()
    {
        double side = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double triangleArea = side * height / 2;

        return triangleArea;
    }

    static double GetSquareArea()
    {
        double side = double.Parse(Console.ReadLine());

        double squareArea = side * side; // Math.Pow(side, 2)

        return squareArea;
    }

    static double GetRectangleArea()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double rectangleArea = width * height;

        return rectangleArea;
    }

    static double GetCircleArea()
    {
        double radius = double.Parse(Console.ReadLine());

        double circleArea = Math.PI * Math.Pow(radius, 2);

        return circleArea;
    }

    static void PrintResult(double result)
    {
        Console.WriteLine($"{result:F2}");
    }
}