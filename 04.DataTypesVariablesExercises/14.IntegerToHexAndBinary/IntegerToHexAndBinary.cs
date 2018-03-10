using System;

public class IntegerToHexAndBinary
{
    public static void Main()
    {
        int decimalNumber = int.Parse(Console.ReadLine());

        string hexNumber = Convert.ToString(decimalNumber, 16).ToUpper();
        string binaryNumber = Convert.ToString(decimalNumber, 2);

        Console.WriteLine(hexNumber);
        Console.WriteLine(binaryNumber);
    }
}