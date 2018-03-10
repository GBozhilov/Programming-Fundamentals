using System;

public class Megapixels
{
    public static void Main()
    {
        var width = int.Parse(Console.ReadLine());
        var height = int.Parse(Console.ReadLine());

        var pixels = width * height;
        var megaPixels = Math.Round(pixels / 1000000.0, 1);

        Console.WriteLine($"{width}x{height} => {megaPixels}MP");
    }
}