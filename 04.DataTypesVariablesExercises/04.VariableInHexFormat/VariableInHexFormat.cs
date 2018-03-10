using System;

public class VariableInHexFormat
{
    public static void Main()
    {
        string numHexFormat = Console.ReadLine();

        int numDecFormat = Convert.ToInt32(numHexFormat, 16);

        Console.WriteLine(numDecFormat);
    }
}