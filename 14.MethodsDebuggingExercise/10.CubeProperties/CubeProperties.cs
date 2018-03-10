using System;

public class CubeProperties
{
    public static void Main()
    {
        var cubeSide = double.Parse(Console.ReadLine());
        var parameter = Console.ReadLine();

        PrintResult(cubeSide, parameter);
    }

    public static void PrintResult(double cubeSide, string parameter)
    {
        switch (parameter)
        {
            case "face":
                Console.WriteLine($"{CalcFaceDiagonal(cubeSide):F2}");
                break;
            case "space":
                Console.WriteLine($"{CalcSpaceDiagonal(cubeSide):F2}");
                break;
            case "volume":
                Console.WriteLine($"{CalcVolume(cubeSide):F2}");
                break;
            case "area":
                Console.WriteLine($"{CalcSurfaceArea(cubeSide):F2}");
                break;
        }
    }

    public static double CalcVolume(double cubeSide)
    {
        double volume = Math.Pow(cubeSide, 3);
        return volume;
    }

    public static double CalcSpaceDiagonal(double cubeSide)
    {
        var spaceDiagonal = Math.Sqrt(3 * Math.Pow(cubeSide, 2));
        return spaceDiagonal;
    }

    public static double CalcFaceDiagonal(double cubeSide)
    {
        var faceDiagonal = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
        return faceDiagonal;
    }

    public static double CalcSurfaceArea(double cubeSide)
    {
        double surfaceArea = 6 * Math.Pow(cubeSide, 2);
        return surfaceArea;
    }
}