using System;
using System.Collections.Generic;

public class AMinerTask
{
    public static void Main()
    {
        var resources = new Dictionary<string, int>();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine.Equals("stop"))
            {
                break;
            }

            var resource = inputLine;
            var quantity = int.Parse(Console.ReadLine());

            if (!resources.ContainsKey(resource))
            {
                resources[resource] = 0;
            }

            resources[resource] += quantity;
        }
        
        PrintResources(resources);
    }

    public static void PrintResources(Dictionary<string, int> resources)
    {
        foreach (var resourceQuantityPair in resources)
        {
            var resource = resourceQuantityPair.Key;
            var quantity = resourceQuantityPair.Value;

            Console.WriteLine($"{resource} -> {quantity}");
        }
    }
}