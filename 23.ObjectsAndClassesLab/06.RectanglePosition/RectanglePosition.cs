using System;
using System.Linq;

public class RectanglePosition
{
    public static void Main()
    {
        Rectangle firstRect = ReadRectangle();
        Rectangle secondRect = ReadRectangle();

        Console.WriteLine(firstRect.IsInside(secondRect) ? "Inside" : "Not inside");
    }

    public static Rectangle ReadRectangle()
    {
        int[] rectangleParams = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Rectangle rect = new Rectangle()
        {
            Left = rectangleParams[0],
            Top = rectangleParams[1],
            Width = rectangleParams[2],
            Height = rectangleParams[3],
        };

        return rect;
    }
}

public class Rectangle
{
    public int Left { get; set; }

    public int Top { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public int Right { get { return Left + Width; } }

    public int Bottom { get { return Top + Height; } }

    public int CalculateArea()
    {
        return Width * Height;
    }

    public bool IsInside(Rectangle rect)
    {
        bool isInLeft = Left >= rect.Left;
        bool isInRight = Right <= rect.Right;
        bool isInTop = Top >= rect.Top;
        bool isInBottom = Bottom <= rect.Bottom;

        bool isInsideHorizontal = isInLeft && isInRight;
        bool isInsideVertical = isInTop && isInBottom;

        return isInsideHorizontal && isInsideVertical;
    }
}