using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class NetherRealms
{
    public static void Main()
    {
        var book = new List<Demon>();

        var demons = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        foreach (var name in demons)
        {
            var healthSymbols = name
                .Where(s => !char.IsDigit(s) && s != '+' && s != '-' && s != '*' && s != '/' && s != '.')
                .ToArray();

            var health = 0;

            foreach (var symbol in healthSymbols)
            {
                health += symbol;
            }

            var pattern = @"\+?\-?\d+\.?\d*";
            var matches = Regex.Matches(name, pattern);

            var damage = 0.0;

            foreach (Match match in matches)
            {
                damage += double.Parse(match.Value);
            }

            var modifiers = name
                .Where(s => s == '*' || s == '/')
                .ToArray();

            foreach (var modifier in modifiers)
            {
                damage = modifier == '*' ? damage *= 2 : damage /= 2;
            }

            var newDemon = new Demon()
            {
                Name = name,
                Health = health,
                Damage = damage
            };

            book.Add(newDemon);
        }

        foreach (var demon in book.OrderBy(d => d.Name))
        {
            var name = demon.Name;
            var health = demon.Health;
            var damage = demon.Damage;

            Console.WriteLine($"{name} - {health} health, {damage:F2} damage");
        }
    }
}

public class Demon
{
    public string Name { get; set; }

    public int Health { get; set; }

    public double Damage { get; set; }
}