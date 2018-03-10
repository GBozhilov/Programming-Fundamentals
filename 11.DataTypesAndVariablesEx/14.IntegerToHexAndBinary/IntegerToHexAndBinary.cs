using System;

public class IntegerToHexAndBinary
{
    public static void Main()
    {
        var decValue = int.Parse(Console.ReadLine());

        //var hexValue = string.Format($"{decValue:X}");
        var hexValue = decValue.ToString("X");
        var binValue = Convert.ToString(decValue, 2);

        Console.WriteLine(hexValue);
        Console.WriteLine(binValue);
    }
}