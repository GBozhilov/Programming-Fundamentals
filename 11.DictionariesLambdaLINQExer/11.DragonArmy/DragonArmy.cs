using System;
using System.Collections.Generic;
using System.Linq;

public class DragonArmy
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, SortedDictionary<string, decimal[]>> dragons =
            new Dictionary<string, SortedDictionary<string, decimal[]>>();

        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split(' ');

            string type = tokens[0];
            string name = tokens[1];
            decimal damage = tokens[2] != "null" ? decimal.Parse(tokens[2]) : 45;
            decimal health = tokens[3] != "null" ? decimal.Parse(tokens[3]) : 250;
            decimal armor = tokens[4] != "null" ? decimal.Parse(tokens[4]) : 10;

            if (!dragons.ContainsKey(type))
                dragons[type] = new SortedDictionary<string, decimal[]>();

            dragons[type][name] = new decimal[] { damage, health, armor };
        }

        PrintResult(dragons);
    }

    static void PrintResult(Dictionary<string, SortedDictionary<string, decimal[]>> dragons)
    {
        foreach (KeyValuePair<string, SortedDictionary<string, decimal[]>> KVP in dragons)
        {
            string type = KVP.Key;
            SortedDictionary<string, decimal[]> statsByName = KVP.Value;

            decimal averageDamage = statsByName.Values.Average(a => a[0]);
            decimal averageHealth = statsByName.Values.Average(a => a[1]);
            decimal averageArmor = statsByName.Values.Average(a => a[2]);

            Console.WriteLine($"{type}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");

            foreach (KeyValuePair<string, decimal[]> nameStatsPair in statsByName)
            {
                string name = nameStatsPair.Key;
                decimal[] stats = nameStatsPair.Value;
                decimal damage = stats[0];
                decimal health = stats[1];
                decimal armor = stats[2];

                Console.WriteLine($"-{name} -> damage: {damage}, health: {health}, armor: {armor}");
            }
        }
    }
}