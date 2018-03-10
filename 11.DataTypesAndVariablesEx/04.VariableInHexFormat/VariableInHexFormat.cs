using System;

public class VariableInHexFormat
{
    public static void Main()
    {
        var hexValue = Console.ReadLine();

        var decValue = Convert.ToInt32(hexValue, 16);

        Console.WriteLine(decValue);
    }
}