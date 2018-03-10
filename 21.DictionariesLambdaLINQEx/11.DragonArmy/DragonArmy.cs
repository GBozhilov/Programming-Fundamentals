using System;
using System.Collections.Generic;
using System.Linq;

public class DragonArmy
{
    public static void Main()
    {
        var dragonsAndStatsByType = new Dictionary<string, SortedDictionary<string, int[]>>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split(' ');

            var type = tokens[0];
            var dragonName = tokens[1];
            var damage = tokens[2] != "null" ? int.Parse(tokens[2]) : 45;
            var health = tokens[3] != "null" ? int.Parse(tokens[3]) : 250;
            var armor = tokens[4] != "null" ? int.Parse(tokens[4]) : 10;

            if (!dragonsAndStatsByType.ContainsKey(type))
            {
                dragonsAndStatsByType[type] = new SortedDictionary<string, int[]>();
            }

            dragonsAndStatsByType[type][dragonName] = new int[] { damage, health, armor };
        }

        PrintDragons(dragonsAndStatsByType);
    }

    public static void PrintDragons(Dictionary<string, SortedDictionary<string, int[]>> dragonsAndStatsByType)
    {
        foreach (var typeEntry in dragonsAndStatsByType)
        {
            var type = typeEntry.Key;
            var dragonsAndStats = typeEntry.Value;

            var averageDamage = dragonsAndStats.Values.Average(a => a[0]);
            var averageHealth = dragonsAndStats.Values.Average(a => a[1]);
            var averageArmor = dragonsAndStats.Values.Average(a => a[2]);

            Console.WriteLine($"{type}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");

            foreach (var dragonStatsPair in dragonsAndStats)
            {
                var dragonName = dragonStatsPair.Key;
                var dragonStats = dragonStatsPair.Value;
                var damage = dragonStats[0];
                var health = dragonStats[1];
                var armor = dragonStats[2];

                Console.WriteLine($"-{dragonName} -> damage: {damage}, health: {health}, armor: {armor}");
            }
        }
    }
}