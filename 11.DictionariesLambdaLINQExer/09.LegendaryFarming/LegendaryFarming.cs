using System;
using System.Collections.Generic;
using System.Linq;

public class LegendaryFarming
{
    public static void Main()
    {
        Dictionary<string, int> trashStorage = new Dictionary<string, int>();
        Dictionary<string, int> valuableStorage = new Dictionary<string, int>
        {
            {"shards", 0},
            {"fragments", 0},
            {"motes", 0}
        };

        bool weaponObtained = false;

        while (!weaponObtained)
        {
            string[] tokens = Console.ReadLine()
                .ToLower()
                .Split(' ');

            int quantity = 0;

            for (int i = 0; i < tokens.Length; i++)
            {
                if (i % 2 == 0)
                    quantity = int.Parse(tokens[i]);
                else
                {
                    string material = tokens[i];
                    //Check if valuable
                    if (CheckMaterial(material))
                    {
                        //if (!valuableStorage.ContainsKey(material))
                        //    valuableStorage[material] = 0;

                        valuableStorage[material] += quantity;

                        if (valuableStorage[material] >= 250)
                        {
                            valuableStorage[material] -= 250;
                            string weaponWon = ReturnWeapon(material);
                            Console.WriteLine($"{weaponWon} obtained!");
                            weaponObtained = true;
                            break;
                        }
                    }
                    //Else if not valuable
                    else
                    {
                        if (!trashStorage.ContainsKey(material))
                            trashStorage[material] = 0;

                        trashStorage[material] += quantity;
                    }
                }
            }
        }

        valuableStorage = valuableStorage
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);

        trashStorage = trashStorage
            .OrderBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);

        PrintResult(valuableStorage);
        PrintResult(trashStorage);
    }

    static void PrintResult(Dictionary<string, int> storage)
    {
        foreach (KeyValuePair<string, int> materialQuantityPair in storage)
        {
            string material = materialQuantityPair.Key;
            int quantity = materialQuantityPair.Value;

            Console.WriteLine($"{material}: {quantity}");
        }
    }

    static string ReturnWeapon(string material)
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

    static bool CheckMaterial(string material)
    {
        if (material.Equals("shards") || material.Equals("fragments") || material.Equals("motes"))
            return true;

        return false;
    }
}