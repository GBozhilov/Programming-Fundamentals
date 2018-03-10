using System;
using System.Collections.Generic;

public class ImmuneSystem
{
    public static void Main()
    {
        var initialHealth = int.Parse(Console.ReadLine());

        var health = initialHealth;
        var defeatedViruses = new HashSet<string>();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine.Equals("end"))
            {
                break;
            }

            var virusName = inputLine;
            var strength = CalculateStrength(virusName);
            var defeatTime = strength * virusName.Length;

            if (defeatedViruses.Contains(virusName))
            {
                defeatTime /= 3;
            }

            var defeatMinutes = defeatTime / 60;
            var defeatSeconds = defeatTime % 60;

            health -= defeatTime;

            Console.WriteLine($"Virus {virusName}: {strength} => {defeatTime} seconds");

            if (health > 0)
            {
                defeatedViruses.Add(virusName);

                Console.WriteLine($"{virusName} defeated in {defeatMinutes}m {defeatSeconds}s.");
                Console.WriteLine($"Remaining health: {health}");
            }
            else
            {
                Console.WriteLine("Immune System Defeated.");
                return;
            }

            health += (int)(0.2 * health);
            health = Math.Min(health, initialHealth);
        }

        Console.WriteLine($"Final Health: {health}");
    }

    public static int CalculateStrength(string virusName)
    {
        var strength = 0;

        foreach (var symbol in virusName)
        {
            strength += symbol;
        }
        strength /= 3;

        return strength;
    }
}