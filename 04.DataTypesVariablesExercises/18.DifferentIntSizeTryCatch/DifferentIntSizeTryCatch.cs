using System;
using System.Numerics;

public class DifferentIntSizeTryCatch
{
    public static void Main()
    {
        // sbyte < byte < short < ushort < int < uint < long
        string numberStr = Console.ReadLine();

        bool isFit = false;
        string message = "can fit in:\n";

        try
        {
            sbyte sbyteNumber = sbyte.Parse(numberStr);
            message += "* sbyte\n";
            isFit = true;
        }
        catch (Exception)
        {
        }

        try
        {
            byte byteNumber = byte.Parse(numberStr);
            message += "* byte\n";
            isFit = true;
        }
        catch (Exception)
        {
        }

        try
        {
            short shortNumber = short.Parse(numberStr);
            message += "* short\n";
            isFit = true;
        }
        catch (Exception)
        {
        }

        try
        {
            ushort ushortNumber = ushort.Parse(numberStr);
            message += "* ushort\n";
            isFit = true;
        }
        catch (Exception)
        {
        }

        try
        {
            int intNumber = int.Parse(numberStr);
            message += "* int\n";
            isFit = true;
        }
        catch (Exception)
        {
        }

        try
        {
            uint uintNumber = uint.Parse(numberStr);
            message += "* uint\n";
            isFit = true;
        }
        catch (Exception)
        {
        }

        try
        {
            long longNumber = long.Parse(numberStr);
            message += "* long\n";
            isFit = true;
        }
        catch (Exception)
        {
        }

        if (isFit)
        {
            Console.Write($"{numberStr} {message}");
        }
        else
        {
            Console.WriteLine("{0} can't fit in any type", numberStr);
        }
    }
}