using System;

public class CubeProperties
{
    public static void Main()
    {
        double cubeSide = double.Parse(Console.ReadLine());
        string parameter = Console.ReadLine().ToLower();

        PrintResult(cubeSide, parameter);
    }

    static void PrintResult(double cubeSide, string parameter)
    {
        switch (parameter)
        {
            case "face":
                Console.WriteLine($"{GetFaceDiagonal(cubeSide):F2}");
                break;
            case "space":
                Console.WriteLine($"{GetSpaseDiagonal(cubeSide):F2}");
                break;
            case "volume":
                Console.WriteLine($"{GetVolume(cubeSide):F2}");
                break;
            case "area":
                Console.WriteLine($"{GetSurfaceArea(cubeSide):F2}");
                break;
            default:
                Console.WriteLine("Invalid parameter!");
                break;
        }
    }

    static double GetVolume(double cubeSide)
    {
        double volume = Math.Pow(cubeSide, 3);
        return volume;
    }

    static double GetFaceDiagonal(double cubeSide)
    {
        double faceDiagonal = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
        return faceDiagonal;
    }

    static double GetSpaseDiagonal(double cubeSide)
    {
        double spaceDiagonal = Math.Sqrt(3 * Math.Pow(cubeSide, 2));
        return spaceDiagonal;
    }

    static double GetSurfaceArea(double cubeSide)
    {
        double surfaceArea = 6 * Math.Pow(cubeSide, 2);
        return surfaceArea;
    }
}