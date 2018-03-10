using System;
using System.Collections.Generic;
using System.Linq;

public class LegendaryFarming
{
    public static void Main()
    {
        var valuableStorage = new Dictionary<string, int>();
        var trashStorage = new Dictionary<string, int>();

        valuableStorage.Add("shards", 0);
        valuableStorage.Add("fragments", 0);
        valuableStorage.Add("motes", 0);

        bool weaponObtained = false;

        while (!weaponObtained)
        {
            var inputLine = Console.ReadLine();

            var tokens = inputLine
                .ToLower()
                .Split(' ');

            for (int i = 0; i < tokens.Length; i += 2)
            {
                var quantity = int.Parse(tokens[i]);
                var material = tokens[i + 1].ToLower();

                if (IsValuableMaterial(material))
                {
                    valuableStorage[material] += quantity;

                    if (valuableStorage[material] >= 250)
                    {
                        valuableStorage[material] -= 250;
                        var weaponWon = ReturnWeapon(material);
                        weaponObtained = true;

                        Console.WriteLine($"{weaponWon} obtained!");

                        break;
                    }
                }
                else
                {
                    if (!trashStorage.ContainsKey(material))
                    {
                        trashStorage[material] = 0;
                    }

                    trashStorage[material] += quantity;
                }
            }
        }

        SortResult(ref valuableStorage, ref trashStorage);

        PrintResult(valuableStorage);
        PrintResult(trashStorage);
    }

    public static void SortResult(ref Dictionary<string, int> valuableStorage, ref Dictionary<string, int> trashStorage)
    {
        valuableStorage = valuableStorage
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .ToDictionary(x => x.Key, y => y.Value);

        trashStorage = trashStorage
            .OrderBy(x => x.Key)
            .ToDictionary(x => x.Key, y => y.Value);
    }

    public static void PrintResult(Dictionary<string, int> storage)
    {
        foreach (var materialQuantityPair in storage)
        {
            var material = materialQuantityPair.Key;
            var quantity = materialQuantityPair.Value;

            Console.WriteLine($"{material}: {quantity}");
        }
    }

    public static string ReturnWeapon(string material)
    {
        switch (material)
        {
            case "shards":
                return "Shadowmourne";
            case "fragments":
                return "Valanyr";
            case "motes":
                return "Dragonwrath";
            default:
                return "";
        }
    }

    public static bool IsValuableMaterial(string material)
    {
        if (material == "shards" || material == "fragments" || material == "motes")
        {
            return true;
        }

        return false;
    }
}