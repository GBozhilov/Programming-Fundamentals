using System;

public class HouseBuilder
{
    public static void Main()
    {
        var firstPrice = long.Parse(Console.ReadLine());
        var secondPrice = long.Parse(Console.ReadLine());

        long sbytePrice = 0;
        long intPrice = 0;

        if (firstPrice >= 0 && firstPrice <= 127)
        {
            sbytePrice = firstPrice;
            intPrice = secondPrice;
        }
        else
        {
            sbytePrice = secondPrice;
            intPrice = firstPrice;
        }

        var sbyteMaterials = 4 * sbytePrice;
        var intMaterials = 10 * intPrice;
        var totalPrice = sbyteMaterials + intMaterials;

        Console.WriteLine(totalPrice);
    }
}