using System;
using System.Collections.Generic;
using System.IO;

public class AMinerTask
{
    public static void Main()
    {
        var resources = new Dictionary<string, int>();

        File.Delete("output.txt");
        var lines = File.ReadAllLines("input.txt");

        for (int i = 0; i < lines.Length; i += 2)
        {
            var inputLine = lines[i];

            while (!inputLine.Equals("stop"))
            {
                var resource = inputLine;
                var quantity = int.Parse(lines[i + 1]);

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }

                resources[resource] += quantity;
                break;
            }
        }

        foreach (var resourceQuantityPair in resources)
        {
            var resource = resourceQuantityPair.Key;
            var quantity = resourceQuantityPair.Value;

            File.AppendAllText("output.txt", $"{resource} -> {quantity}");
            File.AppendAllText("output.txt", Environment.NewLine);
        }
    }
}