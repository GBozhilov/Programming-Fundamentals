using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class NetherRealms
{
    public static void Main()
    {
        var demons = Console.ReadLine()
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var demonsByName = new SortedDictionary<string, Demon>();

        foreach (var demonName in demons)
        {
            var health = demonName
                .Where(s => !char.IsDigit(s) && s != '+' && s != '-' && s != '*' && s != '/' && s != '.')
                .Select(a => (int)a)
                .Sum();

            var pattern = @"-?\d+(?:\.\d+)?";

            var damage = Regex.Matches(demonName, pattern)
                .Cast<Match>()
                .Select(a => double.Parse(a.Value))
                .Sum();

            var modifiers = demonName
                .Where(s => s == '*' || s == '/')
                .ToArray();

            foreach (var symbol in modifiers)
            {
                if (symbol == '*')
                {
                    damage *= 2;
                }
                else if (symbol == '/')
                {
                    damage /= 2;
                }
            }

            var newDemon = new Demon() { Health = health, Damage = damage };

            demonsByName[demonName] = newDemon;
        }

        foreach (var demon in demonsByName)
        {
            var name = demon.Key;
            var health = demon.Value.Health;
            var damage = demon.Value.Damage;

            Console.WriteLine($"{name} - {health} health, {damage:F2} damage ");
        }
    }
}

public class Demon
{
    public int Health { get; set; }

    public double Damage { get; set; }
}