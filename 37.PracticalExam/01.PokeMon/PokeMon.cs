using System;

public class PokeMon
{
    public static void Main()
    {
        var pokePower = int.Parse(Console.ReadLine()); // N
        var distance = int.Parse(Console.ReadLine()); // M
        var factor = int.Parse(Console.ReadLine()); // Y

        var originalValue = pokePower;
        var halfValue = originalValue / 2M;
        var targetsCount = 0;

        while (pokePower >= distance)
        {
            pokePower -= distance;
            targetsCount++;

            if (pokePower == halfValue && factor != 0)
            {
                pokePower /= factor;
            }
        }

        Console.WriteLine(pokePower);
        Console.WriteLine(targetsCount);
    }
}