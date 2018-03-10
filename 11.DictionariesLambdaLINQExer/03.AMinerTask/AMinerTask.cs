using System;
using System.Collections.Generic;

public class AMinerTask
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var resourceQuantity = new Dictionary<string, int>();

        while (inputLine != "stop")
        {
            var resource = inputLine;
            var quantity = int.Parse(Console.ReadLine());

            if (!resourceQuantity.ContainsKey(resource))
                resourceQuantity[resource] = 0;

            resourceQuantity[resource] += quantity;

            inputLine = Console.ReadLine();
        }

        PrintResult(resourceQuantity);
    }

    static void PrintResult(Dictionary<string, int> resourceQuantity)
    {
        foreach (var KVP in resourceQuantity)
        {
            var resource = KVP.Key;
            var quantity = KVP.Value;

            Console.WriteLine($"{resource} -> {quantity}");
        }
    }
}