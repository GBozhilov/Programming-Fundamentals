using System;

public class TouristInformation
{
    public static void Main()
    {
        var entryUnit = Console.ReadLine();
        var entryUnitValue = double.Parse(Console.ReadLine());

        var convertedValue = 0.0;
        var metricUnit = string.Empty;

        switch (entryUnit)
        {
            case "miles":
                convertedValue = entryUnitValue * 1.6;
                metricUnit = "kilometers";
                break;
            case "inches":
                convertedValue = entryUnitValue * 2.54;
                metricUnit = "centimeters";
                break;
            case "feet":
                convertedValue = entryUnitValue * 30;
                metricUnit = "centimeters";
                break;
            case "yards":
                convertedValue = entryUnitValue * 0.91;
                metricUnit = "meters";
                break;
            case "gallons":
                convertedValue = entryUnitValue * 3.8;
                metricUnit = "liters";
                break;
        }

        Console.WriteLine($"{entryUnitValue} {entryUnit} = {convertedValue:F2} {metricUnit}");
    }
}